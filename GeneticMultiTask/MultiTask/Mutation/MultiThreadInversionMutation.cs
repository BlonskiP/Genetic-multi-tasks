
using Shared.AbstractClasses;
using Shared.Entities;
using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTask.Mutation
{
    public class MultiThreadInversionMutation : MutationType
    {
        public MultiThreadInversionMutation(float mutationChance)
        {
            this.mutationChance = mutationChance;
            this.MutationName = "MultiThreadInversionMutation";
   
        }
        public override Candidate Mutate(Candidate candidate)
        {
            double chance = RandomHelper.NextDouble();
            if (chance < mutationChance)
            {
                int endIndex;
                int startIndex = RandomHelper.Next(0, candidate.chromoson.Count());
                do
                {
                    endIndex = RandomHelper.Next(0, candidate.chromoson.Count());
                } while (startIndex == endIndex);
                if (startIndex > endIndex)
                {
                    int temp = startIndex;
                    startIndex = endIndex;
                    endIndex = temp;
                }
                candidate.chromoson.Reverse(startIndex, endIndex - startIndex);
            }
            candidate.CountFitness();
     //       IntegrityHelper.checkGens(candidate);
            return candidate;
        }

        public override List<Candidate> MutateList(List<Candidate> population)
        {
            Parallel.ForEach(population.Distinct(), MultiTaskOptions.parallelOpt, candidate =>
            {
                Mutate(candidate);
                IntegrityHelper.checkGens(candidate);
            });
            return population;
        }
    }
}

