using System;
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
        private bool FormIsActived;

        public Game()
        {
            InitializeComponent();
            this.Icon = global::mine_sweeper.Properties.Resources.favicon;
            this.timer.Start();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void GameUpdate(object sender, EventArgs e)
        {

        }

        private void Game_Resize(object sender, EventArgs e)
        {
            Common.SetWindowRegion(this);
        }

        #region None boder window move 
        private Point mousePoint = new Point();
        private void titleBarOver_MouseDown(object sender, MouseEventArgs e)
        {
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void titleBarOver_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - mousePoint.Y;
                this.Left = Control.MousePosition.X - mousePoint.X;
            }
        }
        #endregion

        #region Window control button
        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you exit surely?", "Warm Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region The status image of the controlBar button change
        private enum ButtonStatus {
            DEFAULT,
            INACTIVE,
            OVER
        }

        private Bitmap ctrlbtn_close;
        private Bitmap ctrlbtn_minimise;
        private Bitmap ctrlbtn_zoom;

        private void SetButtonStatus(ButtonStatus status)
        {
            switch (status)
            {
                case ButtonStatus.DEFAULT:
                    ctrlbtn_close = global::mine_sweeper.Properties.Resources.ctrlbtn_default_close;
                    ctrlbtn_minimise = global::mine_sweeper.Properties.Resources.ctrlbtn_default_minimise;
                    ctrlbtn_zoom = global::mine_sweeper.Properties.Resources.ctrlbtn_default_zoom;
                    break;
                case ButtonStatus.INACTIVE:
                    ctrlbtn_close = global::mine_sweeper.Properties.Resources.ctrlbtn_inactive_close;
                    ctrlbtn_minimise = global::mine_sweeper.Properties.Resources.ctrlbtn_inactive_minimise;
                    ctrlbtn_zoom = global::mine_sweeper.Properties.Resources.ctrlbtn_inactive_zoom;
                    break;
                case ButtonStatus.OVER:
                    ctrlbtn_close = global::mine_sweeper.Properties.Resources.ctrlbtn_over_close;
                    ctrlbtn_minimise = global::mine_sweeper.Properties.Resources.ctrlbtn_over_minimise;
                    ctrlbtn_zoom = global::mine_sweeper.Properties.Resources.ctrlbtn_over_zoom;
                    break;
            }
            this.closeButton.Image = ctrlbtn_close;
            this.minimiseButton.Image = ctrlbtn_minimise;
            this.zoomButton.Image = ctrlbtn_zoom;
        }

        private void Game_Activated(object sender, EventArgs e)
        {
            FormIsActived = true;
            SetButtonStatus(ButtonStatus.DEFAULT);    
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
            FormIsActived = false;
            this.titleBar.Focus(); // avoid the button in contralBar gets focus;
            SetButtonStatus(ButtonStatus.INACTIVE);
        }

        private void controlButton_MouseEnter(object sender, EventArgs e)
        {
            SetButtonStatus(ButtonStatus.OVER);
        }

        private void controlButton_MouseLeave(object sender, EventArgs e)
        {
            SetButtonStatus(FormIsActived ? ButtonStatus.DEFAULT : ButtonStatus.INACTIVE);
        }

        #endregion

    }
}