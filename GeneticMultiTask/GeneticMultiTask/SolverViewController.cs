using Shared.AbstractClasses;
using Shared.Entities;
using SingleTask.Crossover;
using SingleTask.Mutation;
using SingleTask.Solver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeneticMultiTask
{
    class SolverViewController
    {
        SolverView View;
        public static XDocument tspXmlFile;
        GeneticSolver solverSingleThread;
        GeneticSolver solverMultiThread;
        bool isMultiThreadChecked { get { return View.chkMultiThreadEnable.Checked; } }
        bool isSigleThreadChecked { get { return View.chkSingleThreadEnable.Checked; } }
        int mutationIndex { get { return View.cbxMutationType.SelectedIndex; } }
        int crossoverIndex { get { return View.cbxCrossoverType.SelectedIndex; } }
        int selectorIndex { get { return View.cbxSelectionType.SelectedIndex; } }
        int populationSize { get { return int.Parse(View.tbxSelectionSize.Text); } }
        float mutationChance { get { return float.Parse(View.tbxMutationChance.Text.ToString(), CultureInfo.InvariantCulture); } }
        int timeMS { get { return int.Parse(View.tbxTime.Text.ToString()); } }
        int selectorSize { get { return int.Parse(View.tbxSelectionSize.Text); } }
        float crossoverChance { get { return float.Parse(View.tbxCrossoverChance.Text.ToString(), CultureInfo.InvariantCulture); } }
        public List<GeneticSolver> listTask;
        public SolverViewController(SolverView view)
        {
            View = view;
            listTask = new List<GeneticSolver>();
        }
        public void RunSolution()
        {
            if (isMultiThreadChecked)
            {
                solverMultiThread = createNewSolver(true);
                listTask.Add(solverMultiThread);
            }
               
            if (isSigleThreadChecked)
            {
                solverSingleThread = createNewSolver(false);
                listTask.Add(solverSingleThread);
            }
            var tasks = new List<Task<Result>>();
            foreach (var solver in listTask)
                tasks.Add(Task.Factory.StartNew<Result>(() => solver.Solve()));
            ClockDefender(tasks);
            Task.WaitAll(tasks.ToArray());
            foreach (var item in tasks)
            {
                item.Result.ToFile();
            }
            listTask.Clear();
        }
        private void ClockDefender(Object data)
        {
            List<Task<Result>> taskList = (List<Task<Result>>)data;
            while (CheckTasks(taskList))
            {


                for (int i = 0; i < taskList.Count; i++)
                {
                    if (listTask[i].time.IsRunning && (taskList[i].Status == TaskStatus.WaitingForActivation || taskList[i].Status == TaskStatus.WaitingToRun))
                    {
                        listTask[i].time.Stop();
                    }
                }

            }

        }
        private bool CheckTasks(List<Task<Result>> taskList)
        {
            foreach (var task in taskList)
            {
                if (task.Status == TaskStatus.WaitingForActivation || task.Status == TaskStatus.WaitingToRun
                     || task.Status == TaskStatus.Running || task.Status == TaskStatus.WaitingForChildrenToComplete)
                {
                    return true;
                }
            }
            return false;
        }
        internal void loadTSPfile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "tspXMLFile|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tspXmlFile = XDocument.Load(ofd.FileName);
                View.lblFileName.Text = ofd.SafeFileName;
            }
        }

        internal GeneticSolver createNewSolver(bool isMultiThread)
        {
            MutationType mutation = null;
            CrossoverType crossover = null;
            SelectionType selection = null;
            AdjacencyMatrix matrix = new AdjacencyMatrix(tspXmlFile);

            switch (mutationIndex)
            {
                case 0:
                    {
                        mutation = new InversionMutation(mutationChance);
                        break;
                    }
                case 1:
                    {
                        mutation = new TranspositionMutation(mutationChance);
                        break;
                    }

            }

            switch (crossoverIndex)
            {
                case 0:
                    {
                        crossover = new PMXCrossover(crossoverChance);
                        break;
                    }
                case 1:
                    {
                        crossover = new OXCrossover(crossoverChance);
                        break;
                    }
            }

            switch (selectorIndex)
            {
                case 0:
                    {
                        selection = new TournamentSelection(selectorSize);
                        break;
                    }
                case 1:
                    {
                        selection = new RouletteSelection(selectorSize);
                        break;
                    }
            }
            GeneticSolver solver = null;//add parameters TO DO
            if (mutation != null && selection != null && crossover != null)
            {
                if (isMultiThread) {
                   // solver=new GeneticSolver
                }
                else
                    solver= new SingleTaskGeneticSolver(matrix, mutation, crossover, selection, populationSize, timeMS);
            }
            return solver;
        }
    }
}
