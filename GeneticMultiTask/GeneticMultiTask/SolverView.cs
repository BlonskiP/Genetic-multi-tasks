﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticMultiTask
{
    public partial class SolverView : Form
    {
        SolverViewController controller;
        public SolverView()
        {
            controller = new SolverViewController();
            InitializeComponent();      
        }
    }
}