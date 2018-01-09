namespace WindowsFormsApplication1
{
    partial class APPOINTMENT
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
            this.rbupdate = new System.Windows.Forms.RadioButton();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbdocid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtappid = new System.Windows.Forms.TextBox();
            this.cbpatid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtappdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbupdate
            // 
            this.rbupdate.Location = new System.Drawing.Point(207, 63);
            this.rbupdate.Name = "rbupdate";
            this.rbupdate.Size = new System.Drawing.Size(104, 24);
            this.rbupdate.TabIndex = 36;
            this.rbupdate.TabStop = true;
            this.rbupdate.Text = "UPDATE";
            this.rbupdate.UseVisualStyleBackColor = true;
            this.rbupdate.CheckedChanged += new System.EventHandler(this.rbupdate_CheckedChanged);
            // 
            // rbadd
            // 
            this.rbadd.Location = new System.Drawing.Point(73, 63);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(82, 24);
            this.rbadd.TabIndex = 35;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "ADD";
            this.rbadd.UseVisualStyleBackColor = true;
            this.rbadd.CheckedChanged += new System.EventHandler(this.rbadd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "DOCTOR ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbdocid
            // 
            this.cbdocid.FormattingEnabled = true;
            this.cbdocid.Location = new System.Drawing.Point(172, 211);
            this.cbdocid.Name = "cbdocid";
            this.cbdocid.Size = new System.Drawing.Size(200, 21);
            this.cbdocid.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "PATIENT ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "DATE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtappid
            // 
            this.txtappid.Location = new System.Drawing.Point(172, 99);
            this.txtappid.Name = "txtappid";
            this.txtappid.Size = new System.Drawing.Size(200, 20);
            this.txtappid.TabIndex = 28;
            // 
            // cbpatid
            // 
            this.cbpatid.FormattingEnabled = true;
            this.cbpatid.Location = new System.Drawing.Point(172, 172);
            this.cbpatid.Name = "cbpatid";
            this.cbpatid.Size = new System.Drawing.Size(200, 21);
            this.cbpatid.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "APPOINTMENT ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(91, 264);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 41;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(218, 264);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 42;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(91, 264);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 40;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtappdate
            // 
            this.txtappdate.Location = new System.Drawing.Point(172, 136);
            this.txtappdate.Name = "txtappdate";
            this.txtappdate.Size = new System.Drawing.Size(200, 20);
            this.txtappdate.TabIndex = 43;
            // 
            // APPOINTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 300);
            this.Controls.Add(this.txtappdate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rbupdate);
            this.Controls.Add(this.rbadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbdocid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtappid);
            this.Controls.Add(this.cbpatid);
            this.Controls.Add(this.label1);
            this.Name = "APPOINTMENT";
            this.Text = "APPOINTMENT";
            this.Load += new System.EventHandler(this.APPOINTMENT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbupdate;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbdocid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtappid;
        private System.Windows.Forms.ComboBox cbpatid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtappdate;
    }
}