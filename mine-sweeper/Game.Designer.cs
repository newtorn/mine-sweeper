namespace mine_sweeper
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.titleBar = new System.Windows.Forms.Panel();
            this.controlBar = new System.Windows.Forms.Panel();
            this.zoomButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleBarOver = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            this.controlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.GameUpdate);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.titleBar.Controls.Add(this.controlBar);
            this.titleBar.Controls.Add(this.titleBarOver);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(620, 24);
            this.titleBar.TabIndex = 0;
            // 
            // controlBar
            // 
            this.controlBar.BackColor = System.Drawing.Color.Transparent;
            this.controlBar.Controls.Add(this.zoomButton);
            this.controlBar.Controls.Add(this.minimiseButton);
            this.controlBar.Controls.Add(this.closeButton);
            this.controlBar.Location = new System.Drawing.Point(0, 0);
            this.controlBar.Margin = new System.Windows.Forms.Padding(0);
            this.controlBar.Name = "controlBar";
            this.controlBar.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.controlBar.Size = new System.Drawing.Size(82, 24);
            this.controlBar.TabIndex = 4;
            // 
            // zoomButton
            // 
            this.zoomButton.BackColor = System.Drawing.Color.Transparent;
            this.zoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zoomButton.FlatAppearance.BorderSize = 0;
            this.zoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.zoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.zoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomButton.Location = new System.Drawing.Point(58, 5);
            this.zoomButton.Margin = new System.Windows.Forms.Padding(0);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(14, 14);
            this.zoomButton.TabIndex = 3;
            this.zoomButton.UseVisualStyleBackColor = false;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            this.zoomButton.MouseEnter += new System.EventHandler(this.controlButton_MouseEnter);
            this.zoomButton.MouseLeave += new System.EventHandler(this.controlButton_MouseLeave);
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.Transparent;
            this.minimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimiseButton.FlatAppearance.BorderSize = 0;
            this.minimiseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimiseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.Location = new System.Drawing.Point(34, 5);
            this.minimiseButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(14, 14);
            this.minimiseButton.TabIndex = 2;
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            this.minimiseButton.MouseEnter += new System.EventHandler(this.controlButton_MouseEnter);
            this.minimiseButton.MouseLeave += new System.EventHandler(this.controlButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(10, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(14, 14);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.controlButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.controlButton_MouseLeave);
            // 
            // titleBarOver
            // 
            this.titleBarOver.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.titleBarOver.ForeColor = System.Drawing.Color.DarkRed;
            this.titleBarOver.Location = new System.Drawing.Point(0, 0);
            this.titleBarOver.Margin = new System.Windows.Forms.Padding(0);
            this.titleBarOver.Name = "titleBarOver";
            this.titleBarOver.Size = new System.Drawing.Size(620, 24);
            this.titleBarOver.TabIndex = 0;
            this.titleBarOver.Text = "MineSweeper";
            this.titleBarOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleBarOver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarOver_MouseDown);
            this.titleBarOver.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBarOver_MouseMove);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(620, 374);
            this.ControlBox = false;
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Game_Activated);
            this.Deactivate += new System.EventHandler(this.Game_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.Resize += new System.EventHandler(this.Game_Resize);
            this.titleBar.ResumeLayout(false);
            this.controlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel controlBar;
        private System.Windows.Forms.Button zoomButton;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleBarOver;
    }

}