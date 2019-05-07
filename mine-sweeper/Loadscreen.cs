using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mine_sweeper
{
    public partial class Loadscreen : Form
    {
        private Game newGame;

        public Loadscreen()
        {
            InitializeComponent();
            newGame = new Game();
            this.load.Image = global::mine_sweeper.Properties.Resources.load;
            timer.Start();
        }

        private void startGame(object sender, EventArgs e)
        {
            this.Visible = false;
            this.timer.Stop();
            this.timer.Dispose();
            this.newGame.Show();
        }
    }
}
