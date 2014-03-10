namespace Rss_UI
{
    partial class Main
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
            this.btn_Pull = new System.Windows.Forms.Button();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Pull
            // 
            this.btn_Pull.Location = new System.Drawing.Point(381, 12);
            this.btn_Pull.Name = "btn_Pull";
            this.btn_Pull.Size = new System.Drawing.Size(97, 23);
            this.btn_Pull.TabIndex = 0;
            this.btn_Pull.Text = "Pull Feed";
            this.btn_Pull.UseVisualStyleBackColor = true;
            this.btn_Pull.Click += new System.EventHandler(this.Btn_Pull_Click);
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(12, 41);
            this.txtFeed.Multiline = true;
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.ReadOnly = true;
            this.txtFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeed.Size = new System.Drawing.Size(466, 265);
            this.txtFeed.TabIndex = 1;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(363, 20);
            this.txtURL.TabIndex = 2;
            // 
            // statBar
            // 
            this.statBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statBar.Location = new System.Drawing.Point(0, 316);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(490, 22);
            this.statBar.TabIndex = 3;
            this.statBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 338);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtFeed);
            this.Controls.Add(this.btn_Pull);
            this.Name = "Main";
            this.Text = "RSS Reader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statBar.ResumeLayout(false);
            this.statBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pull;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

