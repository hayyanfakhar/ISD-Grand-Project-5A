namespace WindowsFormsApplication1
{
    partial class MENU
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
            this.btnpat = new System.Windows.Forms.Button();
            this.btnapp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnvpat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnvapp = new System.Windows.Forms.Button();
            this.btnpmed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnmed = new System.Windows.Forms.Button();
            this.btnvmed = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpat
            // 
            this.btnpat.Location = new System.Drawing.Point(25, 12);
            this.btnpat.Name = "btnpat";
            this.btnpat.Size = new System.Drawing.Size(97, 23);
            this.btnpat.TabIndex = 0;
            this.btnpat.Text = "PATIENT";
            this.btnpat.UseVisualStyleBackColor = true;
            this.btnpat.Click += new System.EventHandler(this.btnpat_Click);
            // 
            // btnapp
            // 
            this.btnapp.Location = new System.Drawing.Point(25, 57);
            this.btnapp.Name = "btnapp";
            this.btnapp.Size = new System.Drawing.Size(97, 23);
            this.btnapp.TabIndex = 1;
            this.btnapp.Text = "APPOINTMENT";
            this.btnapp.UseVisualStyleBackColor = true;
            this.btnapp.Click += new System.EventHandler(this.btnapp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnvpat);
            this.panel1.Controls.Add(this.btnpat);
            this.panel1.Controls.Add(this.btnapp);
            this.panel1.Location = new System.Drawing.Point(47, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 195);
            this.panel1.TabIndex = 2;
            // 
            // btnvpat
            // 
            this.btnvpat.Location = new System.Drawing.Point(25, 104);
            this.btnvpat.Name = "btnvpat";
            this.btnvpat.Size = new System.Drawing.Size(97, 23);
            this.btnvpat.TabIndex = 2;
            this.btnvpat.Text = "VIEW PATIENT";
            this.btnvpat.UseVisualStyleBackColor = true;
            this.btnvpat.Click += new System.EventHandler(this.btnvpat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnvapp);
            this.panel2.Controls.Add(this.btnpmed);
            this.panel2.Location = new System.Drawing.Point(261, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 195);
            this.panel2.TabIndex = 3;
            // 
            // btnvapp
            // 
            this.btnvapp.Location = new System.Drawing.Point(39, 12);
            this.btnvapp.Name = "btnvapp";
            this.btnvapp.Size = new System.Drawing.Size(97, 39);
            this.btnvapp.TabIndex = 3;
            this.btnvapp.Text = "VIEW APPOINTMENT";
            this.btnvapp.UseVisualStyleBackColor = true;
            this.btnvapp.Click += new System.EventHandler(this.btnvapp_Click);
            // 
            // btnpmed
            // 
            this.btnpmed.Location = new System.Drawing.Point(39, 74);
            this.btnpmed.Name = "btnpmed";
            this.btnpmed.Size = new System.Drawing.Size(97, 38);
            this.btnpmed.TabIndex = 0;
            this.btnpmed.Text = "PRESCRIBE MEDICINE";
            this.btnpmed.UseVisualStyleBackColor = true;
            this.btnpmed.Click += new System.EventHandler(this.btnpmed_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "RECEPTIONIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(229, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "DOCTOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(472, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "PHARMACIST";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnmed);
            this.panel3.Controls.Add(this.btnvmed);
            this.panel3.Location = new System.Drawing.Point(472, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 195);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnmed
            // 
            this.btnmed.Location = new System.Drawing.Point(25, 12);
            this.btnmed.Name = "btnmed";
            this.btnmed.Size = new System.Drawing.Size(97, 23);
            this.btnmed.TabIndex = 0;
            this.btnmed.Text = "MEDICINE";
            this.btnmed.UseVisualStyleBackColor = true;
            this.btnmed.Click += new System.EventHandler(this.btnmed_Click);
            // 
            // btnvmed
            // 
            this.btnvmed.Location = new System.Drawing.Point(25, 57);
            this.btnvmed.Name = "btnvmed";
            this.btnvmed.Size = new System.Drawing.Size(97, 23);
            this.btnvmed.TabIndex = 1;
            this.btnvmed.Text = "VIEW MEDICINE";
            this.btnvmed.UseVisualStyleBackColor = true;
            this.btnvmed.Click += new System.EventHandler(this.btnvmed_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(497, 14);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 8;
            this.btnLog.Text = "Logout";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 313);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpat;
        private System.Windows.Forms.Button btnapp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnpmed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvpat;
        private System.Windows.Forms.Button btnvapp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnmed;
        private System.Windows.Forms.Button btnvmed;
        private System.Windows.Forms.Button btnLog;
    }
}