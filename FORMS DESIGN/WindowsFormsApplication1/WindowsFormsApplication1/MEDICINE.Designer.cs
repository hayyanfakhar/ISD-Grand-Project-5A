namespace WindowsFormsApplication1
{
    partial class MEDICINE
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
            this.txtmedid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rbupdate = new System.Windows.Forms.RadioButton();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedname = new System.Windows.Forms.TextBox();
            this.txtmedcost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmedid
            // 
            this.txtmedid.Location = new System.Drawing.Point(167, 133);
            this.txtmedid.Name = "txtmedid";
            this.txtmedid.Size = new System.Drawing.Size(200, 20);
            this.txtmedid.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "MEDICINE ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(88, 269);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 66;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(215, 269);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 67;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(88, 269);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 65;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rbupdate
            // 
            this.rbupdate.Location = new System.Drawing.Point(202, 86);
            this.rbupdate.Name = "rbupdate";
            this.rbupdate.Size = new System.Drawing.Size(104, 24);
            this.rbupdate.TabIndex = 64;
            this.rbupdate.TabStop = true;
            this.rbupdate.Text = "UPDATE";
            this.rbupdate.UseVisualStyleBackColor = true;
            this.rbupdate.CheckedChanged += new System.EventHandler(this.rbupdate_CheckedChanged);
            // 
            // rbadd
            // 
            this.rbadd.Location = new System.Drawing.Point(68, 86);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(82, 24);
            this.rbadd.TabIndex = 63;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "ADD";
            this.rbadd.UseVisualStyleBackColor = true;
            this.rbadd.CheckedChanged += new System.EventHandler(this.rbadd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "COST:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "MEDICINE NAME:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmedname
            // 
            this.txtmedname.Location = new System.Drawing.Point(167, 170);
            this.txtmedname.Name = "txtmedname";
            this.txtmedname.Size = new System.Drawing.Size(200, 20);
            this.txtmedname.TabIndex = 70;
            // 
            // txtmedcost
            // 
            this.txtmedcost.Location = new System.Drawing.Point(167, 207);
            this.txtmedcost.Name = "txtmedcost";
            this.txtmedcost.Size = new System.Drawing.Size(200, 20);
            this.txtmedcost.TabIndex = 71;
            // 
            // MEDICINE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.Controls.Add(this.txtmedcost);
            this.Controls.Add(this.txtmedname);
            this.Controls.Add(this.txtmedid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rbupdate);
            this.Controls.Add(this.rbadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "MEDICINE";
            this.Text = "MEDICINE";
            this.Load += new System.EventHandler(this.MEDICINE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmedid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.RadioButton rbupdate;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedname;
        private System.Windows.Forms.TextBox txtmedcost;
    }
}