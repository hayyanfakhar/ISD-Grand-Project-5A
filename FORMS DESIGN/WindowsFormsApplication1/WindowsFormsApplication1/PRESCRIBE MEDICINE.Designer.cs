namespace WindowsFormsApplication1
{
    partial class PRESCRIBE_MEDICINE
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rbupdate = new System.Windows.Forms.RadioButton();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmedid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbvisitid = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clinicSystemDataSet = new WindowsFormsApplication1.ClinicSystemDataSet();
            this.visitMedicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visit_MedicineTableAdapter = new WindowsFormsApplication1.ClinicSystemDataSetTableAdapters.Visit_MedicineTableAdapter();
            this.clinicSystemDataSet1 = new WindowsFormsApplication1.ClinicSystemDataSet1();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new WindowsFormsApplication1.ClinicSystemDataSet1TableAdapters.VisitTableAdapter();
            this.clinicSystemDataSet2 = new WindowsFormsApplication1.ClinicSystemDataSet2();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableAdapter = new WindowsFormsApplication1.ClinicSystemDataSet2TableAdapters.MedicineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clinicSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitMedicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(96, 243);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 54;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(225, 243);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 55;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(98, 243);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 53;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rbupdate
            // 
            this.rbupdate.Location = new System.Drawing.Point(212, 60);
            this.rbupdate.Name = "rbupdate";
            this.rbupdate.Size = new System.Drawing.Size(104, 24);
            this.rbupdate.TabIndex = 52;
            this.rbupdate.TabStop = true;
            this.rbupdate.Text = "UPDATE";
            this.rbupdate.UseVisualStyleBackColor = true;
            this.rbupdate.CheckedChanged += new System.EventHandler(this.rbupdate_CheckedChanged);
            // 
            // rbadd
            // 
            this.rbadd.Location = new System.Drawing.Point(78, 60);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(82, 24);
            this.rbadd.TabIndex = 51;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "ADD";
            this.rbadd.UseVisualStyleBackColor = true;
            this.rbadd.CheckedChanged += new System.EventHandler(this.rbadd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "MEDICINE ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbmedid
            // 
            this.cbmedid.DataSource = this.medicineBindingSource;
            this.cbmedid.DisplayMember = "Med_ID";
            this.cbmedid.FormattingEnabled = true;
            this.cbmedid.Location = new System.Drawing.Point(177, 182);
            this.cbmedid.Name = "cbmedid";
            this.cbmedid.Size = new System.Drawing.Size(200, 21);
            this.cbmedid.TabIndex = 49;
            this.cbmedid.ValueMember = "Med_ID";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "VISIT ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbvisitid
            // 
            this.cbvisitid.DataSource = this.visitBindingSource;
            this.cbvisitid.DisplayMember = "Visit_ID";
            this.cbvisitid.FormattingEnabled = true;
            this.cbvisitid.Location = new System.Drawing.Point(177, 144);
            this.cbvisitid.Name = "cbvisitid";
            this.cbvisitid.Size = new System.Drawing.Size(200, 21);
            this.cbvisitid.TabIndex = 47;
            this.cbvisitid.ValueMember = "Visit_ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(177, 107);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(200, 20);
            this.txtid.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clinicSystemDataSet
            // 
            this.clinicSystemDataSet.DataSetName = "ClinicSystemDataSet";
            this.clinicSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitMedicineBindingSource
            // 
            this.visitMedicineBindingSource.DataMember = "Visit_Medicine";
            this.visitMedicineBindingSource.DataSource = this.clinicSystemDataSet;
            // 
            // visit_MedicineTableAdapter
            // 
            this.visit_MedicineTableAdapter.ClearBeforeFill = true;
            // 
            // clinicSystemDataSet1
            // 
            this.clinicSystemDataSet1.DataSetName = "ClinicSystemDataSet1";
            this.clinicSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataMember = "Visit";
            this.visitBindingSource.DataSource = this.clinicSystemDataSet1;
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
            // 
            // clinicSystemDataSet2
            // 
            this.clinicSystemDataSet2.DataSetName = "ClinicSystemDataSet2";
            this.clinicSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.clinicSystemDataSet2;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // PRESCRIBE_MEDICINE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 326);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rbupdate);
            this.Controls.Add(this.rbadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmedid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbvisitid);
            this.Name = "PRESCRIBE_MEDICINE";
            this.Text = "PRESCRIBE_MEDICINE";
            this.Load += new System.EventHandler(this.PRESCRIBE_MEDICINE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitMedicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.RadioButton rbupdate;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmedid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbvisitid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private ClinicSystemDataSet clinicSystemDataSet;
        private System.Windows.Forms.BindingSource visitMedicineBindingSource;
        private ClinicSystemDataSetTableAdapters.Visit_MedicineTableAdapter visit_MedicineTableAdapter;
        private ClinicSystemDataSet1 clinicSystemDataSet1;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private ClinicSystemDataSet1TableAdapters.VisitTableAdapter visitTableAdapter;
        private ClinicSystemDataSet2 clinicSystemDataSet2;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private ClinicSystemDataSet2TableAdapters.MedicineTableAdapter medicineTableAdapter;
    }
}