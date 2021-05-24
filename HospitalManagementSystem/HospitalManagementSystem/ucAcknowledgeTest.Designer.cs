﻿
namespace HospitalManagementSystem
{
    partial class ucAcknowledgeTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cbSample = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcknowledge = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLaboratory = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Acknowledged Samples:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDueDate);
            this.panel1.Controls.Add(this.cbLaboratory);
            this.panel1.Controls.Add(this.cbSample);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnGenerateID);
            this.panel1.Controls.Add(this.txtPatientID);
            this.panel1.Controls.Add(this.txtTestID);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 151);
            this.panel1.TabIndex = 9;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(285, 102);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(171, 23);
            this.dtpDueDate.TabIndex = 19;
            // 
            // cbSample
            // 
            this.cbSample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSample.FormattingEnabled = true;
            this.cbSample.Items.AddRange(new object[] {
            "Department of Neurology",
            "Department of Cardiology"});
            this.cbSample.Location = new System.Drawing.Point(15, 102);
            this.cbSample.Name = "cbSample";
            this.cbSample.Size = new System.Drawing.Size(199, 23);
            this.cbSample.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sample:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(281, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Due Date:";
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateID.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerateID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateID.Location = new System.Drawing.Point(680, 39);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(65, 23);
            this.btnGenerateID.TabIndex = 16;
            this.btnGenerateID.Text = "Generate";
            this.btnGenerateID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateID.UseVisualStyleBackColor = false;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPatientID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPatientID.Location = new System.Drawing.Point(286, 39);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(170, 23);
            this.txtPatientID.TabIndex = 1;
            // 
            // txtTestID
            // 
            this.txtTestID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTestID.Location = new System.Drawing.Point(533, 39);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.Size = new System.Drawing.Size(147, 23);
            this.txtTestID.TabIndex = 1;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPatientName.Location = new System.Drawing.Point(16, 39);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(198, 23);
            this.txtPatientName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(281, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(528, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient Name:";
            // 
            // btnAcknowledge
            // 
            this.btnAcknowledge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcknowledge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcknowledge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcknowledge.Location = new System.Drawing.Point(719, 214);
            this.btnAcknowledge.Name = "btnAcknowledge";
            this.btnAcknowledge.Size = new System.Drawing.Size(90, 25);
            this.btnAcknowledge.TabIndex = 19;
            this.btnAcknowledge.Text = "Acknowledge";
            this.btnAcknowledge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcknowledge.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientName,
            this.patientId,
            this.testId,
            this.sample,
            this.dueDate,
            this.result});
            this.dataGridView1.Location = new System.Drawing.Point(15, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(794, 278);
            this.dataGridView1.TabIndex = 20;
            // 
            // patientName
            // 
            this.patientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            // 
            // patientId
            // 
            this.patientId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientId.HeaderText = "Patient ID";
            this.patientId.Name = "patientId";
            // 
            // testId
            // 
            this.testId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testId.HeaderText = "Test ID";
            this.testId.Name = "testId";
            // 
            // sample
            // 
            this.sample.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sample.HeaderText = "Sample";
            this.sample.Name = "sample";
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.result.HeaderText = "Add Result";
            this.result.Name = "result";
            this.result.Width = 70;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(360, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lab Tests";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(528, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Laboratory:";
            // 
            // cbLaboratory
            // 
            this.cbLaboratory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLaboratory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLaboratory.FormattingEnabled = true;
            this.cbLaboratory.Items.AddRange(new object[] {
            "Department of Neurology",
            "Department of Cardiology"});
            this.cbLaboratory.Location = new System.Drawing.Point(532, 102);
            this.cbLaboratory.Name = "cbLaboratory";
            this.cbLaboratory.Size = new System.Drawing.Size(213, 23);
            this.cbLaboratory.TabIndex = 18;
            // 
            // ucAcknowledgeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAcknowledge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "ucAcknowledgeTest";
            this.Size = new System.Drawing.Size(824, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.ComboBox cbSample;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAcknowledge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn testId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sample;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewButtonColumn result;
        private System.Windows.Forms.ComboBox cbLaboratory;
        private System.Windows.Forms.Label label5;
    }
}
