namespace TareaDI03Componente
{
    partial class WatchComponent
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
            this.second = new System.Windows.Forms.Label();
            this.horaMinut = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lbFormat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.g = new System.Diagnostics.PerformanceCounter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.SuspendLayout();
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.second.ForeColor = System.Drawing.Color.BlueViolet;
            this.second.Location = new System.Drawing.Point(134, 129);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(45, 33);
            this.second.TabIndex = 1;
            this.second.Text = "00";
            // 
            // horaMinut
            // 
            this.horaMinut.AutoSize = true;
            this.horaMinut.Font = new System.Drawing.Font("Comic Sans MS", 30F);
            this.horaMinut.ForeColor = System.Drawing.Color.Gold;
            this.horaMinut.Location = new System.Drawing.Point(73, 58);
            this.horaMinut.Name = "horaMinut";
            this.horaMinut.Size = new System.Drawing.Size(169, 71);
            this.horaMinut.TabIndex = 2;
            this.horaMinut.Text = "00:00";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fecha.Location = new System.Drawing.Point(64, 40);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(178, 28);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Tues, 19/01/2021";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbFormat);
            this.panel1.Controls.Add(this.lbFormat);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.horaMinut);
            this.panel1.Controls.Add(this.second);
            this.panel1.Location = new System.Drawing.Point(29, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 179);
            this.panel1.TabIndex = 2;
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(3, 3);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(53, 24);
            this.cbFormat.TabIndex = 8;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.Location = new System.Drawing.Point(230, 101);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(28, 17);
            this.lbFormat.TabIndex = 7;
            this.lbFormat.Text = "AM";
            this.lbFormat.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // WatchComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "WatchComponent";
            this.Size = new System.Drawing.Size(397, 255);
            this.Load += new System.EventHandler(this.WatchComponent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label horaMinut;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Diagnostics.PerformanceCounter g;
    }
}
