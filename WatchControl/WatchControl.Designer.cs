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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchControl));
            this.lbHourMin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHourMin
            // 
            this.lbHourMin.AutoSize = true;
            this.lbHourMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHourMin.ForeColor = System.Drawing.Color.Tomato;
            this.lbHourMin.Location = new System.Drawing.Point(47, 100);
            this.lbHourMin.Name = "lbHourMin";
            this.lbHourMin.Size = new System.Drawing.Size(139, 50);
            this.lbHourMin.TabIndex = 0;
            this.lbHourMin.Text = "00:00";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(34, 68);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(56, 23);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.Location = new System.Drawing.Point(125, 151);
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
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(14, 16);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(45, 21);
            this.radioButton12.TabIndex = 4;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(65, 16);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(45, 21);
            this.radioButton24.TabIndex = 5;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "24";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btAlarm
            // 
            this.btAlarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlarm.BackgroundImage")));
            this.btAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAlarm.Location = new System.Drawing.Point(251, 10);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(33, 32);
            this.btAlarm.TabIndex = 6;
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // WatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btAlarm);
            this.Controls.Add(this.radioButton24);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbHourMin);
            this.Name = "WatchControl";
            this.Size = new System.Drawing.Size(296, 207);
            this.Load += new System.EventHandler(this.WatchControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHourMin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btAlarm;
    }
}
