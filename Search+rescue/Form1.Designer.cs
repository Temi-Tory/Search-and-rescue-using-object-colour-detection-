namespace Search_rescue
{
    partial class Form1
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
            this.Strt_btn = new System.Windows.Forms.Button();
            this.Abrt_btn = new System.Windows.Forms.Button();
            this.Adv_btn = new System.Windows.Forms.Button();
            this.tbx = new System.Windows.Forms.TextBox();
            this.s_port = new System.IO.Ports.SerialPort(this.components);
            this.Wlcm_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Strt_btn
            // 
            this.Strt_btn.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strt_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.Strt_btn.Location = new System.Drawing.Point(61, 380);
            this.Strt_btn.Name = "Strt_btn";
            this.Strt_btn.Size = new System.Drawing.Size(236, 58);
            this.Strt_btn.TabIndex = 0;
            this.Strt_btn.Text = "Start";
            this.Strt_btn.UseVisualStyleBackColor = true;
            // 
            // Abrt_btn
            // 
            this.Abrt_btn.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abrt_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Abrt_btn.Location = new System.Drawing.Point(355, 380);
            this.Abrt_btn.Name = "Abrt_btn";
            this.Abrt_btn.Size = new System.Drawing.Size(142, 58);
            this.Abrt_btn.TabIndex = 1;
            this.Abrt_btn.Text = "Abort";
            this.Abrt_btn.UseVisualStyleBackColor = true;
            this.Abrt_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Adv_btn
            // 
            this.Adv_btn.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adv_btn.Location = new System.Drawing.Point(713, 403);
            this.Adv_btn.Name = "Adv_btn";
            this.Adv_btn.Size = new System.Drawing.Size(75, 35);
            this.Adv_btn.TabIndex = 2;
            this.Adv_btn.Text = "Advanced Options";
            this.Adv_btn.UseVisualStyleBackColor = true;
            this.Adv_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(12, 54);
            this.tbx.Multiline = true;
            this.tbx.Name = "tbx";
            this.tbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx.Size = new System.Drawing.Size(713, 290);
            this.tbx.TabIndex = 3;
            // 
            // s_port
            // 
            this.s_port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.s_port_DataReceived);
            // 
            // Wlcm_lbl
            // 
            this.Wlcm_lbl.AutoSize = true;
            this.Wlcm_lbl.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlcm_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Wlcm_lbl.Location = new System.Drawing.Point(28, 9);
            this.Wlcm_lbl.Name = "Wlcm_lbl";
            this.Wlcm_lbl.Size = new System.Drawing.Size(318, 42);
            this.Wlcm_lbl.TabIndex = 4;
            this.Wlcm_lbl.Text = "Search And Rescue Robot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wlcm_lbl);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.Adv_btn);
            this.Controls.Add(this.Abrt_btn);
            this.Controls.Add(this.Strt_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Strt_btn;
        private System.Windows.Forms.Button Abrt_btn;
        private System.Windows.Forms.Button Adv_btn;
        private System.Windows.Forms.TextBox tbx;
        private System.IO.Ports.SerialPort s_port;
        private System.Windows.Forms.Label Wlcm_lbl;
    }
}

