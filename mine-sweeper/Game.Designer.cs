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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.titleBar = new System.Windows.Forms.Panel();
            this.controlBar = new System.Windows.Forms.Panel();
            this.zoomButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleBarOver = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.displayStrip = new System.Windows.Forms.ToolStrip();
            this.scoreTitle = new System.Windows.Forms.ToolStripLabel();
            this.scoreLabel = new System.Windows.Forms.ToolStripLabel();
            this.stripSeparator = new System.Windows.Forms.ToolStripLabel();
            this.bombTitle = new System.Windows.Forms.ToolStripLabel();
            this.bombLabel = new System.Windows.Forms.ToolStripLabel();
            this.operateStrip = new System.Windows.Forms.ToolStrip();
            this.lowButton = new System.Windows.Forms.ToolStripButton();
            this.middleButton = new System.Windows.Forms.ToolStripButton();
            this.highButton = new System.Windows.Forms.ToolStripButton();
            this.titleBar.SuspendLayout();
            this.controlBar.SuspendLayout();
            this.backPanel.SuspendLayout();
            this.displayStrip.SuspendLayout();
            this.operateStrip.SuspendLayout();
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
            this.titleBar.Size = new System.Drawing.Size(680, 30);
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
            this.controlBar.Size = new System.Drawing.Size(82, 30);
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
            this.zoomButton.Location = new System.Drawing.Point(58, 8);
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
            this.minimiseButton.Location = new System.Drawing.Point(34, 8);
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
            this.closeButton.Location = new System.Drawing.Point(10, 8);
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
            this.titleBarOver.BackColor = System.Drawing.Color.Transparent;
            this.titleBarOver.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.titleBarOver.ForeColor = System.Drawing.Color.DarkRed;
            this.titleBarOver.Location = new System.Drawing.Point(0, 0);
            this.titleBarOver.Margin = new System.Windows.Forms.Padding(0);
            this.titleBarOver.Name = "titleBarOver";
            this.titleBarOver.Size = new System.Drawing.Size(680, 30);
            this.titleBarOver.TabIndex = 0;
            this.titleBarOver.Text = "MineSweeper";
            this.titleBarOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleBarOver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarOver_MouseDown);
            this.titleBarOver.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBarOver_MouseMove);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.Controls.Add(this.gamePanel);
            this.backPanel.Controls.Add(this.displayStrip);
            this.backPanel.Controls.Add(this.operateStrip);
            this.backPanel.Location = new System.Drawing.Point(0, 30);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(680, 300);
            this.backPanel.TabIndex = 1;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.Location = new System.Drawing.Point(140, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(400, 270);
            this.gamePanel.TabIndex = 3;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PainGamePanel);
            this.gamePanel.Resize += new System.EventHandler(this.ResizeGamePanel);
            // 
            // displayStrip
            // 
            this.displayStrip.AutoSize = false;
            this.displayStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.displayStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.displayStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.displayStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreTitle,
            this.scoreLabel,
            this.stripSeparator,
            this.bombTitle,
            this.bombLabel});
            this.displayStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.displayStrip.Location = new System.Drawing.Point(540, 0);
            this.displayStrip.Name = "displayStrip";
            this.displayStrip.Padding = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.displayStrip.Size = new System.Drawing.Size(140, 300);
            this.displayStrip.TabIndex = 2;
            this.displayStrip.Text = "ToolStrip";
            // 
            // scoreTitle
            // 
            this.scoreTitle.AutoSize = false;
            this.scoreTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Margin = new System.Windows.Forms.Padding(0);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(115, 25);
            this.scoreTitle.Text = "Scores";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = false;
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(115, 20);
            this.scoreLabel.Text = "0";
            // 
            // stripSeparator
            // 
            this.stripSeparator.AutoSize = false;
            this.stripSeparator.BackColor = System.Drawing.Color.Transparent;
            this.stripSeparator.ForeColor = System.Drawing.Color.Transparent;
            this.stripSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.stripSeparator.Name = "stripSeparator";
            this.stripSeparator.Padding = new System.Windows.Forms.Padding(0, 58, 0, 0);
            this.stripSeparator.Size = new System.Drawing.Size(115, 60);
            // 
            // bombTitle
            // 
            this.bombTitle.AutoSize = false;
            this.bombTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombTitle.Margin = new System.Windows.Forms.Padding(0);
            this.bombTitle.Name = "bombTitle";
            this.bombTitle.Size = new System.Drawing.Size(115, 25);
            this.bombTitle.Text = "Bombs";
            // 
            // bombLabel
            // 
            this.bombLabel.AutoSize = false;
            this.bombLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.bombLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bombLabel.Name = "bombLabel";
            this.bombLabel.Size = new System.Drawing.Size(115, 20);
            this.bombLabel.Text = "0";
            // 
            // operateStrip
            // 
            this.operateStrip.AutoSize = false;
            this.operateStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.operateStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.operateStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.operateStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.operateStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowButton,
            this.middleButton,
            this.highButton});
            this.operateStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.operateStrip.Location = new System.Drawing.Point(0, 0);
            this.operateStrip.Name = "operateStrip";
            this.operateStrip.Padding = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.operateStrip.Size = new System.Drawing.Size(140, 300);
            this.operateStrip.TabIndex = 1;
            this.operateStrip.Text = "ToolStrip";
            // 
            // lowButton
            // 
            this.lowButton.AutoSize = false;
            this.lowButton.BackColor = System.Drawing.Color.Transparent;
            this.lowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lowButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lowButton.Margin = new System.Windows.Forms.Padding(0);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(100, 40);
            this.lowButton.Text = "LowLevel";
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // middleButton
            // 
            this.middleButton.AutoSize = false;
            this.middleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.middleButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.middleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.middleButton.Margin = new System.Windows.Forms.Padding(0);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(100, 40);
            this.middleButton.Text = "MiddleLevel";
            this.middleButton.Click += new System.EventHandler(this.middleButton_Click);
            // 
            // highButton
            // 
            this.highButton.AutoSize = false;
            this.highButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.highButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.highButton.Margin = new System.Windows.Forms.Padding(0);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(100, 40);
            this.highButton.Text = "HighLevel";
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(680, 330);
            this.ControlBox = false;
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Game_Activated);
            this.Deactivate += new System.EventHandler(this.Game_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Resize += new System.EventHandler(this.Game_Resize);
            this.titleBar.ResumeLayout(false);
            this.controlBar.ResumeLayout(false);
            this.backPanel.ResumeLayout(false);
            this.displayStrip.ResumeLayout(false);
            this.displayStrip.PerformLayout();
            this.operateStrip.ResumeLayout(false);
            this.operateStrip.PerformLayout();
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
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.ToolStrip displayStrip;
        private System.Windows.Forms.ToolStripLabel scoreTitle;
        private System.Windows.Forms.ToolStripLabel scoreLabel;
        private System.Windows.Forms.ToolStripLabel stripSeparator;
        private System.Windows.Forms.ToolStripLabel bombTitle;
        private System.Windows.Forms.ToolStripLabel bombLabel;
        private System.Windows.Forms.ToolStrip operateStrip;
        private System.Windows.Forms.ToolStripButton lowButton;
        private System.Windows.Forms.ToolStripButton middleButton;
        private System.Windows.Forms.ToolStripButton highButton;
    }

}