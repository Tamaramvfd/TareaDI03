namespace WatchControl
{
    partial class WatchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbHourMin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lbSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbHourMin
            // 
            this.lbHourMin.AutoSize = true;
            this.lbHourMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHourMin.ForeColor = System.Drawing.Color.Gold;
            this.lbHourMin.Location = new System.Drawing.Point(128, 139);
            this.lbHourMin.Name = "lbHourMin";
            this.lbHourMin.Size = new System.Drawing.Size(129, 46);
            this.lbHourMin.TabIndex = 0;
            this.lbHourMin.Text = "00:00";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(82, 98);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(56, 23);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(37, 33);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(65, 24);
            this.cbFormat.TabIndex = 2;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.Location = new System.Drawing.Point(169, 185);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(49, 32);
            this.lbSecond.TabIndex = 3;
            this.lbSecond.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // WatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbHourMin);
            this.Name = "WatchControl";
            this.Size = new System.Drawing.Size(405, 266);
            this.Load += new System.EventHandler(this.WatchControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHourMin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
