namespace GeneticMultiTask
{
    partial class SolverView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkSingleThreadEnable = new System.Windows.Forms.CheckBox();
            this.chkMultiThreadEnable = new System.Windows.Forms.CheckBox();
            this.lblMutationType = new System.Windows.Forms.Label();
            this.lblCrossoverType = new System.Windows.Forms.Label();
            this.lblSelectionType = new System.Windows.Forms.Label();
            this.cbxMutationType = new System.Windows.Forms.ComboBox();
            this.cbxCrossoverType = new System.Windows.Forms.ComboBox();
            this.cbxSelectionType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMutationChance = new System.Windows.Forms.TextBox();
            this.tbxCrossoverChance = new System.Windows.Forms.TextBox();
            this.tbxSelectionSize = new System.Windows.Forms.TextBox();
            this.lblPopulationSize = new System.Windows.Forms.Label();
            this.tbxPopulationSize = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.btnTspLoad = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxLvlMutation = new System.Windows.Forms.TextBox();
            this.tbxLvlCrossover = new System.Windows.Forms.TextBox();
            this.tbxLvlSelector = new System.Windows.Forms.TextBox();
            this.lblLvlParMutation = new System.Windows.Forms.Label();
            this.lblLvlCorss = new System.Windows.Forms.Label();
            this.lblLvlSelector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkSingleThreadEnable
            // 
            this.chkSingleThreadEnable.AutoSize = true;
            this.chkSingleThreadEnable.Location = new System.Drawing.Point(519, 49);
            this.chkSingleThreadEnable.Name = "chkSingleThreadEnable";
            this.chkSingleThreadEnable.Size = new System.Drawing.Size(64, 17);
            this.chkSingleThreadEnable.TabIndex = 0;
            this.chkSingleThreadEnable.Text = "1 wątek";
            this.chkSingleThreadEnable.UseVisualStyleBackColor = true;
            // 
            // chkMultiThreadEnable
            // 
            this.chkMultiThreadEnable.AutoSize = true;
            this.chkMultiThreadEnable.Location = new System.Drawing.Point(519, 72);
            this.chkMultiThreadEnable.Name = "chkMultiThreadEnable";
            this.chkMultiThreadEnable.Size = new System.Drawing.Size(80, 17);
            this.chkMultiThreadEnable.TabIndex = 1;
            this.chkMultiThreadEnable.Text = "multi thread";
            this.chkMultiThreadEnable.UseVisualStyleBackColor = true;
            // 
            // lblMutationType
            // 
            this.lblMutationType.AutoSize = true;
            this.lblMutationType.Location = new System.Drawing.Point(43, 12);
            this.lblMutationType.Name = "lblMutationType";
            this.lblMutationType.Size = new System.Drawing.Size(64, 13);
            this.lblMutationType.TabIndex = 2;
            this.lblMutationType.Text = "Typ mutatcji";
            // 
            // lblCrossoverType
            // 
            this.lblCrossoverType.AutoSize = true;
            this.lblCrossoverType.Location = new System.Drawing.Point(23, 36);
            this.lblCrossoverType.Name = "lblCrossoverType";
            this.lblCrossoverType.Size = new System.Drawing.Size(86, 13);
            this.lblCrossoverType.TabIndex = 3;
            this.lblCrossoverType.Text = "Typ krzyżowania";
            // 
            // lblSelectionType
            // 
            this.lblSelectionType.AutoSize = true;
            this.lblSelectionType.Location = new System.Drawing.Point(43, 66);
            this.lblSelectionType.Name = "lblSelectionType";
            this.lblSelectionType.Size = new System.Drawing.Size(65, 13);
            this.lblSelectionType.TabIndex = 4;
            this.lblSelectionType.Text = "Typ Selekcji";
            // 
            // cbxMutationType
            // 
            this.cbxMutationType.FormattingEnabled = true;
            this.cbxMutationType.Items.AddRange(new object[] {
            "Inwersja",
            "Transport"});
            this.cbxMutationType.Location = new System.Drawing.Point(113, 3);
            this.cbxMutationType.Name = "cbxMutationType";
            this.cbxMutationType.Size = new System.Drawing.Size(121, 21);
            this.cbxMutationType.TabIndex = 6;
            // 
            // cbxCrossoverType
            // 
            this.cbxCrossoverType.FormattingEnabled = true;
            this.cbxCrossoverType.Items.AddRange(new object[] {
            "PMX",
            "OX"});
            this.cbxCrossoverType.Location = new System.Drawing.Point(113, 33);
            this.cbxCrossoverType.Name = "cbxCrossoverType";
            this.cbxCrossoverType.Size = new System.Drawing.Size(121, 21);
            this.cbxCrossoverType.TabIndex = 7;
            // 
            // cbxSelectionType
            // 
            this.cbxSelectionType.FormattingEnabled = true;
            this.cbxSelectionType.Items.AddRange(new object[] {
            "Turniejowa",
            "Ruletkowa"});
            this.cbxSelectionType.Location = new System.Drawing.Point(113, 63);
            this.cbxSelectionType.Name = "cbxSelectionType";
            this.cbxSelectionType.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectionType.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(524, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Szansa mutacji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Szansa krzyżowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wielkość selekcji";
            // 
            // tbxMutationChance
            // 
            this.tbxMutationChance.Location = new System.Drawing.Point(347, 9);
            this.tbxMutationChance.Name = "tbxMutationChance";
            this.tbxMutationChance.Size = new System.Drawing.Size(100, 20);
            this.tbxMutationChance.TabIndex = 14;
            this.tbxMutationChance.Text = "0.05";
            // 
            // tbxCrossoverChance
            // 
            this.tbxCrossoverChance.Location = new System.Drawing.Point(347, 36);
            this.tbxCrossoverChance.Name = "tbxCrossoverChance";
            this.tbxCrossoverChance.Size = new System.Drawing.Size(100, 20);
            this.tbxCrossoverChance.TabIndex = 15;
            this.tbxCrossoverChance.Text = "0.05";
            // 
            // tbxSelectionSize
            // 
            this.tbxSelectionSize.Location = new System.Drawing.Point(347, 63);
            this.tbxSelectionSize.Name = "tbxSelectionSize";
            this.tbxSelectionSize.Size = new System.Drawing.Size(100, 20);
            this.tbxSelectionSize.TabIndex = 16;
            this.tbxSelectionSize.Text = "50";
            // 
            // lblPopulationSize
            // 
            this.lblPopulationSize.AutoSize = true;
            this.lblPopulationSize.Location = new System.Drawing.Point(12, 106);
            this.lblPopulationSize.Name = "lblPopulationSize";
            this.lblPopulationSize.Size = new System.Drawing.Size(97, 13);
            this.lblPopulationSize.TabIndex = 17;
            this.lblPopulationSize.Text = "Wielkość Populacji";
            // 
            // tbxPopulationSize
            // 
            this.tbxPopulationSize.Location = new System.Drawing.Point(115, 106);
            this.tbxPopulationSize.Name = "tbxPopulationSize";
            this.tbxPopulationSize.Size = new System.Drawing.Size(84, 20);
            this.tbxPopulationSize.TabIndex = 18;
            this.tbxPopulationSize.Text = "300";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(218, 111);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 13);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Czas[sec]";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(277, 108);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(100, 20);
            this.tbxTime.TabIndex = 20;
            this.tbxTime.Text = "30";
            // 
            // btnTspLoad
            // 
            this.btnTspLoad.Location = new System.Drawing.Point(434, 106);
            this.btnTspLoad.Name = "btnTspLoad";
            this.btnTspLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTspLoad.TabIndex = 21;
            this.btnTspLoad.Text = "TSP XML";
            this.btnTspLoad.UseVisualStyleBackColor = true;
            this.btnTspLoad.Click += new System.EventHandler(this.btnTspLoad_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(456, 12);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(127, 13);
            this.lblFileName.TabIndex = 22;
            this.lblFileName.Text = "brak załadowanego pliku";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(2, 177);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(639, 403);
            this.cartesianChart1.TabIndex = 23;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // tbxLvlMutation
            // 
            this.tbxLvlMutation.Location = new System.Drawing.Point(116, 132);
            this.tbxLvlMutation.Name = "tbxLvlMutation";
            this.tbxLvlMutation.Size = new System.Drawing.Size(58, 20);
            this.tbxLvlMutation.TabIndex = 25;
            this.tbxLvlMutation.Text = "1000";
            // 
            // tbxLvlCrossover
            // 
            this.tbxLvlCrossover.Location = new System.Drawing.Point(236, 134);
            this.tbxLvlCrossover.Name = "tbxLvlCrossover";
            this.tbxLvlCrossover.Size = new System.Drawing.Size(53, 20);
            this.tbxLvlCrossover.TabIndex = 26;
            this.tbxLvlCrossover.Text = "1000";
            // 
            // tbxLvlSelector
            // 
            this.tbxLvlSelector.Location = new System.Drawing.Point(360, 132);
            this.tbxLvlSelector.Name = "tbxLvlSelector";
            this.tbxLvlSelector.Size = new System.Drawing.Size(43, 20);
            this.tbxLvlSelector.TabIndex = 27;
            this.tbxLvlSelector.Text = "1000";
            // 
            // lblLvlParMutation
            // 
            this.lblLvlParMutation.AutoSize = true;
            this.lblLvlParMutation.Location = new System.Drawing.Point(42, 137);
            this.lblLvlParMutation.Name = "lblLvlParMutation";
            this.lblLvlParMutation.Size = new System.Drawing.Size(65, 13);
            this.lblLvlParMutation.TabIndex = 28;
            this.lblLvlParMutation.Text = "Lvl Mutation";
            // 
            // lblLvlCorss
            // 
            this.lblLvlCorss.AutoSize = true;
            this.lblLvlCorss.Location = new System.Drawing.Point(180, 139);
            this.lblLvlCorss.Name = "lblLvlCorss";
            this.lblLvlCorss.Size = new System.Drawing.Size(50, 13);
            this.lblLvlCorss.TabIndex = 29;
            this.lblLvlCorss.Text = "Lvl Cross";
            this.lblLvlCorss.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLvlSelector
            // 
            this.lblLvlSelector.AutoSize = true;
            this.lblLvlSelector.Location = new System.Drawing.Point(295, 139);
            this.lblLvlSelector.Name = "lblLvlSelector";
            this.lblLvlSelector.Size = new System.Drawing.Size(59, 13);
            this.lblLvlSelector.TabIndex = 30;
            this.lblLvlSelector.Text = "lvl Selector";
            // 
            // SolverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 605);
            this.Controls.Add(this.lblLvlSelector);
            this.Controls.Add(this.lblLvlCorss);
            this.Controls.Add(this.lblLvlParMutation);
            this.Controls.Add(this.tbxLvlSelector);
            this.Controls.Add(this.tbxLvlCrossover);
            this.Controls.Add(this.tbxLvlMutation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnTspLoad);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tbxPopulationSize);
            this.Controls.Add(this.lblPopulationSize);
            this.Controls.Add(this.tbxSelectionSize);
            this.Controls.Add(this.tbxCrossoverChance);
            this.Controls.Add(this.tbxMutationChance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxSelectionType);
            this.Controls.Add(this.cbxCrossoverType);
            this.Controls.Add(this.cbxMutationType);
            this.Controls.Add(this.lblSelectionType);
            this.Controls.Add(this.lblCrossoverType);
            this.Controls.Add(this.lblMutationType);
            this.Controls.Add(this.chkMultiThreadEnable);
            this.Controls.Add(this.chkSingleThreadEnable);
            this.Name = "SolverView";
            this.Text = "SolverView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkSingleThreadEnable;
        public System.Windows.Forms.CheckBox chkMultiThreadEnable;
        public System.Windows.Forms.Label lblMutationType;
        public System.Windows.Forms.Label lblCrossoverType;
        public System.Windows.Forms.Label lblSelectionType;
        public System.Windows.Forms.ComboBox cbxMutationType;
        public System.Windows.Forms.ComboBox cbxCrossoverType;
        public System.Windows.Forms.ComboBox cbxSelectionType;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxMutationChance;
        public System.Windows.Forms.TextBox tbxCrossoverChance;
        public System.Windows.Forms.TextBox tbxSelectionSize;
        public System.Windows.Forms.Label lblPopulationSize;
        public System.Windows.Forms.TextBox tbxPopulationSize;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.TextBox tbxTime;
        public System.Windows.Forms.Button btnTspLoad;
        public System.Windows.Forms.Label lblFileName;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxLvlMutation;
        private System.Windows.Forms.TextBox tbxLvlCrossover;
        private System.Windows.Forms.TextBox tbxLvlSelector;
        private System.Windows.Forms.Label lblLvlParMutation;
        private System.Windows.Forms.Label lblLvlCorss;
        private System.Windows.Forms.Label lblLvlSelector;
    }
}