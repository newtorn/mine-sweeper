﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace mine_sweeper
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            this.timer.Start();
        }

        private void redraw(object sender, PaintEventArgs e)
        {

        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void update(object sender, EventArgs e)
        {

        }

        private void resize(object sender, EventArgs e)
        {
            Common.SetWindowRegion(this);
        }
    }
}
