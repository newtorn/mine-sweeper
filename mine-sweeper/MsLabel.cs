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
        private int x, y;
        private int value;
        private bool bomb;
        private bool flag;
        private Timer timer;

        public MsLabel(int x, int y) : base()
        {
            InitializeComponent();
            this.Text = "Hello wolrd";
            this.ForeColor = System.Drawing.Color.White;

            this.value = 0;
            this.timer = new Timer();
            this.timer.Interval = 2000;
            this.timer.Tick += new EventHandler(BackGroundUpdate);

            this.x = x;
            this.y = y;
        }

        public MsLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


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
        public void SeletLab()
        {
            if (flag)
            {
                this.Image = global::mine_sweeper.Properties.Resources.flag;
            }
            else if (bomb)
            {
                this.Image = global::mine_sweeper.Properties.Resources.explosion;
                timer.Start();
            }
            else
            {
                this.Text = this.value.ToString();
                this.Image = null;
            }
        }

        public void RevealAll()
        {
            if (bomb)
            {
                this.Image = global::mine_sweeper.Properties.Resources.bomb;
            }
            else if (!flag)
            {
                this.Text = this.value.ToString();
            }
        }

        private void BackGroundUpdate(object sender, EventArgs e)
        {
            this.Image = null;
            this.Text = "lost";
            this.ForeColor = System.Drawing.Color.Red;
            timer.Stop();
        }
        #endregion

    }
}
