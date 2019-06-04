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
        #region Decalare DataMembers
        private enum GameStatus
        {
            Keep,
            Won,
            Lost
        }
        private bool FormIsActived;
        private MsLabel[,] labels;
        private int countBombs;
        private int scores;
        private GameStatus status;
        private Size fieldSize;
        private bool firstClick;
        private MsLabel curLabel;
        #endregion

        #region Init stuff
        public Game()
        {
            InitializeComponent();
            this.Icon = global::mine_sweeper.Properties.Resources.favicon;
            TextBox tb = new TextBox();
            tb.Font = new Font("Comic Sans MS", 16);
            tb.Text = "\r\n\r\n\r\n\r\nPowered By Newtorn";
            tb.TextAlign = HorizontalAlignment.Center;
            tb.Multiline = true;
            tb.ReadOnly = true;
            tb.Size = this.gamePanel.Size;
            tb.AutoSize = false;
            tb.Enabled = false;
            this.gamePanel.Controls.Add(tb);
            this.gamePanel.Refresh();
        }

        private void StartGame(Size filedSize, int countBombs)
        {    
            this.firstClick = true;
            this.scores = 0;
            this.fieldSize = new Size(filedSize.Width, filedSize.Height);
            this.status = GameStatus.Keep;
            Createlabels(new Size(45, 45), fieldSize.Width, fieldSize.Height);
            this.countBombs = countBombs;
            this.bombLabel.Text = this.countBombs.ToString();
            this.scoreLabel.Text = this.scores.ToString();
        }

        private void Createlabels(System.Drawing.Size size, int width, int height)
        {
            this.gamePanel.Controls.Clear();
            labels = new MsLabel[height, width];
            int counter = 0;
            for (int i = 0; i < labels.GetLength(0); ++i)
            {
                for (int j = 0; j < labels.GetLength(1); ++j)
                {
                    labels[i, j] = new MsLabel(i, j);
                    labels[i, j].Location = new Point(j * size.Width, i * size.Height);
                    labels[i, j].Name = "msLabel" + counter.ToString();
                    labels[i, j].Size = size;
                    labels[i, j].TabIndex = labels[i, j].Value;
                    labels[i, j].MouseClick += new MouseEventHandler(MouseClick);
                    this.gamePanel.Controls.Add(labels[i, j]);
                    counter++;
                }
            }
            this.gamePanel.Width = labels[labels.GetLength(0) - 1, labels.GetLength(1) - 1].Location.X +
                labels[labels.GetLength(0) - 1, labels.GetLength(1) - 1].Size.Width;
            this.gamePanel.Height = labels[labels.GetLength(0) - 1, labels.GetLength(1) - 1].Location.Y +
                labels[labels.GetLength(0) - 1, labels.GetLength(1) - 1].Size.Height;
            Resize_gamePanel();
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
            DialogResult dr = MessageBox.Show("Do you exit surely?", "Warm Tip",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private enum labelstatus {
            DEFAULT,
            INACTIVE,
            OVER
        }

        private Bitmap ctrlbtn_close;
        private Bitmap ctrlbtn_minimise;
        private Bitmap ctrlbtn_zoom;

        private void SetLabelStatus(labelstatus status)
        {
            switch (status)
            {
                case labelstatus.DEFAULT:
                    ctrlbtn_close = global::mine_sweeper.Properties.Resources.ctrlbtn_default_close;
                    ctrlbtn_minimise = global::mine_sweeper.Properties.Resources.ctrlbtn_default_minimise;
                    ctrlbtn_zoom = global::mine_sweeper.Properties.Resources.ctrlbtn_default_zoom;
                    break;
                case labelstatus.INACTIVE:
                    ctrlbtn_close = global::mine_sweeper.Properties.Resources.ctrlbtn_inactive_close;
                    ctrlbtn_minimise = global::mine_sweeper.Properties.Resources.ctrlbtn_inactive_minimise;
                    ctrlbtn_zoom = global::mine_sweeper.Properties.Resources.ctrlbtn_inactive_zoom;
                    break;
                case labelstatus.OVER:
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
            SetLabelStatus(labelstatus.DEFAULT);    
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
            FormIsActived = false;
            this.titleBar.Focus(); // avoid the button in contralBar gets focus;
            SetLabelStatus(labelstatus.INACTIVE);
        }

        private void controlButton_MouseEnter(object sender, EventArgs e)
        {
            SetLabelStatus(labelstatus.OVER);
        }

        private void controlButton_MouseLeave(object sender, EventArgs e)
        {
            SetLabelStatus(FormIsActived ? labelstatus.DEFAULT : labelstatus.INACTIVE);
        }

        #endregion

        #endregion

        #region Display stuff
        private void Resize_gamePanel()
        {
            this.backPanel.Height = this.gamePanel.Height;
            this.backPanel.Width = this.gamePanel.Width + this.operateStrip.Width + this.displayStrip.Width;
            this.titleBar.Width = this.backPanel.Width;
            this.titleBarOver.Width = this.backPanel.Width;

            int ptop = (this.operateStrip.Height - this.lowButton.Height -
                this.middleButton.Height - this.highButton.Height) / 2;
            this.operateStrip.Padding = new Padding(0, ptop, 0, 0);

            ptop = (this.displayStrip.Height - this.stripSeparator.Height - this.scoreTitle.Height -
                this.scoreLabel.Height - this.bombTitle.Height - this.bombLabel.Height) / 2;
            this.displayStrip.Padding = new Padding(0, ptop, 0, 0);

            this.Width = this.backPanel.Width;
            this.Height = this.backPanel.Height + this.titleBar.Height * 2;
        }

        private void ResizeGamePanel(object sender, EventArgs e)
        {
            Resize_gamePanel();
            this.bombLabel.Text = (this.countBombs - 1).ToString();
            this.scoreLabel.Text = scores.ToString();
        }

        private void PainGamePanel(object sender, PaintEventArgs e)
        {
            Common.SetWindowCenterScreen(this);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void lowButton_Click(object sender, EventArgs e)
        {
            StartGame(new Size(9, 9), 10);
        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            StartGame(new Size(16, 16), 40);
        }

        private void highButton_Click(object sender, EventArgs e)
        {
            StartGame(new Size(30, 16), 99);
        }
        private void Game_Resize(object sender, EventArgs e)
        {
            Common.SetWindowRegion(this);
        }  
        #endregion

        #region GameLogic
        public void MouseClick(object sender, MouseEventArgs mouse)
        {
            MsLabel selectedLabel = (MsLabel)sender;
            if (mouse.Button.ToString().Equals("Right") && selectedLabel.Text.Equals(""))
            {
                selectedLabel.Flag = !selectedLabel.Flag;
                selectedLabel.SelectLab("flag");
            }
            else if (!selectedLabel.Flag)
            {
                if (firstClick)
                {
                    this.firstClick = false;
                    this.curLabel = selectedLabel;
                    SetBombs();
                    this.timer.Start();
                }
                if (selectedLabel.Bomb)
                {
                    for (int i = 0; i < labels.GetLength(0); ++i)
                    {
                        for (int j = 0; j < labels.GetLength(1); ++j)
                        {
                            labels[i, j].RevealAll();
                            labels[i, j].MouseClick -= MouseClick;
                        }
                    }
                    selectedLabel.SelectLab("bomb");
                    status = GameStatus.Lost;
                }
                else
                {
                    selectedLabel.SelectLab("value");
                    this.scores += (int)(selectedLabel.Value * 1.6);
                }
            }
        }
        
        private void SetBombs()
        {
            int setBombs = 0;
            while (setBombs != countBombs)
            {
                bool retry = true;
                Random random = new Random((int)((DateTime.Now.Ticks + Environment.TickCount) % Environment.TickCount));
                do
                {
                    int x = random.Next(0, labels.GetLength(0) - 1);
                    int y = random.Next(0, labels.GetLength(1) - 1);
                    if (!(x == curLabel.X && y == curLabel.Y) && !labels[x, y].Bomb)
                    {
                        retry = false;
                        for (int i = -1; i <= 1; ++i)
                        {
                            for (int j = -1; j <= 1; ++j)
                            {
                                int cx = curLabel.X + i;
                                int cy = curLabel.Y + j;
                                if (x == cx && y == cy)
                                {
                                    retry = true;
                                }
                            }
                        }
                        if (!retry)
                            labels[x, y].Bomb = true;
                    }
                } while (retry);
                setBombs++;
            }
            curLabel.Value = 0;
            CheckBombs();
        }

        private void CheckBombs()
        {
            foreach (MsLabel label in labels)
            {
                if (label.Bomb) continue;
                for (int i = -1; i <= 1; ++i)
                {
                    for (int j = -1; j <= 1; ++j)
                    {
                        int x = label.X + i;
                        int y = label.Y + j;
                        if (x < 0 || x > labels.GetLength(0) - 1 ||
                            y < 0 || y > labels.GetLength(1) - 1) continue;
                        if (labels[x, y].Bomb) label.Value++;
                    }
                }
            }
        }
      

        private void GameUpdate(object sender, EventArgs e)
        {
            if (this.firstClick) return;
            CheckNext();
            if (this.status == GameStatus.Keep)
            {
                CheckWin();
                UpdateScores();
            }
            else if (this.status == GameStatus.Lost)
            {
                this.timer.Stop();
            }
        }

        private void CheckNext()
        {
            foreach (MsLabel label in labels)
            {
                if (label.Text == "" || label.Value != 0) continue;
                for (int i = -1; i <= 1; ++i)
                {
                    for (int j = -1; j <= 1; ++j)
                    {
                        int x = label.X + i;
                        int y = label.Y + j;
                        if (x < 0 || x > labels.GetLength(0) - 1 ||
                            y < 0 || y > labels.GetLength(1) - 1 ||
                            labels[x, y].Flag || labels[x, y].Bomb) continue;
                        labels[x, y].Text = labels[x, y].Value.ToString();
                    }
                }
            }
        }

        private void CheckWin()
        {
            bool rest = false;
            foreach (MsLabel label in labels)
            {
                if (!label.Flag)
                {
                    if (label.Bomb) return;
                    else if (label.Text.Equals("")) rest = true;
                }
            }
            if (rest) return;
            foreach (MsLabel label in labels) label.MouseClick -= MouseClick;
            this.status = GameStatus.Won;
            this.timer.Stop();
            MessageBox.Show("U win with " + this.scores.ToString() + " scores");
        }

        private void UpdateScores()
        {
            int oldScores = this.scores;
            this.scores = 0;
            foreach (MsLabel label in labels)
            {
                if(!label.Text.Equals(""))
                {
                    this.scores += Convert.ToInt32(label.Text);
                }
            }
            if (this.scores != oldScores)
            {
                this.bombLabel.Text = this.countBombs.ToString();
                this.scoreLabel.Text = this.scores.ToString();
            }
        }

        #endregion

    }
}