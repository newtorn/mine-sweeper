﻿namespace mine_sweeper
{
    partial class MsLabel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MsLabel
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.3F, System.Drawing.FontStyle.Bold);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MouseEnter += new System.EventHandler(this.MsLabel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MsLabel_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
