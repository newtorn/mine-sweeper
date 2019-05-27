using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mine_sweeper
{
    public partial class MsLabel : Label
    {
        #region Decalre DataMembers
        private int x, y;
        private int value;
        private bool bomb;
        private bool flag;
        private Timer timer;
        #endregion

        #region Init stuff
        public MsLabel(int x, int y) : base()
        {
            InitializeComponent();
            this.Text = "";
            this.ForeColor = System.Drawing.Color.White;

            this.value = 0;
            this.timer = new Timer();
            this.timer.Interval = 2000;
            this.timer.Tick += new EventHandler(BackGroundUpdate);

            this.x = x;
            this.y = y;

            this.bomb = this.flag = false;
        }

        public MsLabel (IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Properties
        public int Value
        {
            set { this.value = value; }
            get { return this.value; }
        }

        public bool Bomb
        {
            set { this.bomb = value; }
            get { return this.bomb; }
        }

        public bool Flag
        {
            set { this.flag = value; }
            get { return this.flag; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        #endregion

        #region Methods
        public void SelectLab(string wic)
        {
            this.Text = "";
            this.Image = null;
            switch (wic)
            {
                case "flag":
                    if (this.flag)
                    {
                        this.Image = global::mine_sweeper.Properties.Resources.flag;
                    }
                    break;
                case "bomb":
                    if (this.bomb)
                    {
                        this.Image = global::mine_sweeper.Properties.Resources.explosion;
                        this.timer.Start();
                    }
                    break;
                case "value":
                    this.Text = this.value.ToString();
                    break;
            }
        }

        public void RevealAll()
        {
            if (this.bomb)
            {
                this.Image = global::mine_sweeper.Properties.Resources.bomb;
            }
            else if (!this.flag)
            {
                this.Text = this.value.ToString();
            }
        }

        private void BackGroundUpdate(object sender, EventArgs e)
        {
            this.Image = null;
            this.Text = "lost";
            this.ForeColor = System.Drawing.Color.Red;
            this.timer.Stop();
        }
        #endregion
    }
}
