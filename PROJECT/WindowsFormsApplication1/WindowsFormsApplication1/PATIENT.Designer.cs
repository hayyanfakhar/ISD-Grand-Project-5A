﻿namespace WindowsFormsApplication1
{
    partial class PATIENT
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.rbupdate = new System.Windows.Forms.RadioButton();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpatadd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpatname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpatid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtpatnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(79, 345);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 38;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // rbupdate
            // 
            this.rbupdate.Location = new System.Drawing.Point(213, 63);
            this.rbupdate.Name = "rbupdate";
            this.rbupdate.Size = new System.Drawing.Size(104, 24);
            this.rbupdate.TabIndex = 41;
            this.rbupdate.TabStop = true;
            this.rbupdate.Text = "UPDATE";
            this.rbupdate.UseVisualStyleBackColor = true;
            this.rbupdate.CheckedChanged += new System.EventHandler(this.rbupdate_CheckedChanged);
            // 
            // rbadd
            // 
            this.rbadd.Location = new System.Drawing.Point(79, 63);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(82, 24);
            this.rbadd.TabIndex = 40;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "ADD";
            this.rbadd.UseVisualStyleBackColor = true;
            this.rbadd.CheckedChanged += new System.EventHandler(this.rbadd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "DATE OF BIRTH:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "GENDER:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpatadd
            // 
            this.txtpatadd.Location = new System.Drawing.Point(173, 194);
            this.txtpatadd.Name = "txtpatadd";
            this.txtpatadd.Size = new System.Drawing.Size(196, 20);
            this.txtpatadd.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "PATIENT ADDRESS:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpatname
            // 
            this.txtpatname.Location = new System.Drawing.Point(173, 159);
            this.txtpatname.Name = "txtpatname";
            this.txtpatname.Size = new System.Drawing.Size(196, 20);
            this.txtpatname.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "PATIENT NAME:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpatid
            // 
            this.txtpatid.Location = new System.Drawing.Point(173, 120);
            this.txtpatid.Name = "txtpatid";
            this.txtpatid.Size = new System.Drawing.Size(196, 20);
            this.txtpatid.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "PATIENT ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(206, 345);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 39;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(79, 345);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpatnumber
            // 
            this.txtpatnumber.Location = new System.Drawing.Point(173, 302);
            this.txtpatnumber.Name = "txtpatnumber";
            this.txtpatnumber.Size = new System.Drawing.Size(196, 20);
            this.txtpatnumber.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "PHONE NUMBER:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(173, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // PATIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 377);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtpatnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.rbupdate);
            this.Controls.Add(this.rbadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpatadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpatname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpatid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Name = "PATIENT";
            this.Text = "PATIENT";
            this.Load += new System.EventHandler(this.PATIENT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.RadioButton rbupdate;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpatadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpatname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpatid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtpatnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

