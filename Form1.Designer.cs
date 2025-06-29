namespace PaintDrawX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDrawOuterRing;
        private System.Windows.Forms.ToolStripMenuItem menuDrawCenterDot;
        private System.Windows.Forms.ToolStripMenuItem menuDrawText;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDrawOuterRing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawCenterDot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrawOuterRing,
            this.menuDrawCenterDot,
            this.menuDrawText});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDrawOuterRing
            // 
            this.menuDrawOuterRing.Name = "menuDrawOuterRing";
            this.menuDrawOuterRing.Size = new System.Drawing.Size(133, 24);
            this.menuDrawOuterRing.Text = "Draw Outer Ring";
            this.menuDrawOuterRing.Click += new System.EventHandler(this.menuDrawOuterRing_Click);
            // 
            // menuDrawCenterDot
            // 
            this.menuDrawCenterDot.Name = "menuDrawCenterDot";
            this.menuDrawCenterDot.Size = new System.Drawing.Size(134, 24);
            this.menuDrawCenterDot.Text = "Draw Center Dot";
            this.menuDrawCenterDot.Click += new System.EventHandler(this.menuDrawCenterDot_Click);
            // 
            // menuDrawText
            // 
            this.menuDrawText.Name = "menuDrawText";
            this.menuDrawText.Size = new System.Drawing.Size(89, 24);
            this.menuDrawText.Text = "Draw Text";
            this.menuDrawText.Click += new System.EventHandler(this.menuDrawText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 325);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PaintDrawX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

