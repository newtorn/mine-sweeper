using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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
        private Color oldColor;
        private Color[] vcolors;
        #endregion

        #region Init stuff
        public MsLabel(int x, int y) : base()
        {
            InitializeComponent();
            this.Text = "";
            this.ForeColor = Color.Red;
            this.BackColor = Color.FromArgb(8, 46, 84);
            vcolors = new Color[] {
                Color.Transparent,
                Color.FromArgb(65, 105, 225),
                Color.FromArgb(0, 160, 0),
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(65, 165, 225),
                Color.FromArgb(0, 160, 0),
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(65, 105, 225),
                Color.FromArgb(0, 160, 0),
                Color.FromArgb(255, 0, 0),
            };
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
        public void UpdateColor()
        {
            this.BackColor = Color.FromArgb(0, 255, 255, 255);
            if (this.value >= 0 && this.value < 10)
                this.ForeColor = this.vcolors[this.value];
        }

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


        private void MsLabel_MouseLeave(object sender, EventArgs e)
        {
            if (this.Text.Equals(""))
            {
                this.BackColor = oldColor;
            }
        }

        private void MsLabel_MouseEnter(object sender, EventArgs e)
        {
            if (this.Text.Equals(""))
            {
                this.oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(220, 220, 220);
            }
        }
        #endregion
    }
}
