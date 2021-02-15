namespace FormWatchControl
{
    partial class WatchForm
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
            this.watchControl1 = new WatchControl.WatchControl();
            this.SuspendLayout();
            // 
            // watchControl1
            // 
            this.watchControl1.Alarm = new System.DateTime(((long)(0)));
            this.watchControl1.Format = true;
            this.watchControl1.Location = new System.Drawing.Point(14, 12);
            this.watchControl1.Name = "watchControl1";
            this.watchControl1.Size = new System.Drawing.Size(296, 207);
            this.watchControl1.TabIndex = 0;
            // 
            // WatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 226);
            this.Controls.Add(this.watchControl1);
            this.Name = "WatchForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WatchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WatchControl.WatchControl watchControl1;
    }
}

