namespace MESysWin.GUI
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.groupBoxDiagnosis = new System.Windows.Forms.GroupBox();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concomitantdiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benefitcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceaddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentialaddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeofworkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentnumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentissuedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationstakenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingphysicianColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todaydayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDiagnosis
            // 
            this.groupBoxDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDiagnosis.Controls.Add(this.dataGridViewPatient);
            this.groupBoxDiagnosis.Controls.Add(this.buttonCorrect);
            this.groupBoxDiagnosis.Controls.Add(this.buttonRemove);
            this.groupBoxDiagnosis.Controls.Add(this.buttonAdd);
            this.groupBoxDiagnosis.Location = new System.Drawing.Point(4, 2);
            this.groupBoxDiagnosis.Name = "groupBoxDiagnosis";
            this.groupBoxDiagnosis.Size = new System.Drawing.Size(828, 384);
            this.groupBoxDiagnosis.TabIndex = 6;
            this.groupBoxDiagnosis.TabStop = false;
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AllowUserToAddRows = false;
            this.dataGridViewPatient.AllowUserToDeleteRows = false;
            this.dataGridViewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.genderColumn,
            this.dateColumn,
            this.symptomsColumn,
            this.diagnosisColumn,
            this.concomitantdiagnosisColumn,
            this.dateofbirthColumn,
            this.mhiColumn,
            this.mioColumn,
            this.benefitcodeColumn,
            this.residenceaddressColumn,
            this.residentialaddressColumn,
            this.phoneColumn,
            this.placeofworkColumn,
            this.professionColumn,
            this.postColumn,
            this.dependentColumn,
            this.documentnameColumn,
            this.documentnumberColumn,
            this.documentdateColumn,
            this.documentissuedColumn,
            this.medicationstakenColumn,
            this.attendingphysicianColumn,
            this.todaydayColumn});
            this.dataGridViewPatient.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatient.RowTemplate.Height = 60;
            this.dataGridViewPatient.Size = new System.Drawing.Size(815, 335);
            this.dataGridViewPatient.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "ФИО";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 250;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Пол";
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateColumn.HeaderText = "Возраст";
            this.dateColumn.MinimumWidth = 100;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // symptomsColumn
            // 
            this.symptomsColumn.HeaderText = "Симптомы";
            this.symptomsColumn.Name = "symptomsColumn";
            this.symptomsColumn.ReadOnly = true;
            // 
            // diagnosisColumn
            // 
            this.diagnosisColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diagnosisColumn.HeaderText = "Диагноз";
            this.diagnosisColumn.MinimumWidth = 100;
            this.diagnosisColumn.Name = "diagnosisColumn";
            this.diagnosisColumn.ReadOnly = true;
            // 
            // concomitantdiagnosisColumn
            // 
            this.concomitantdiagnosisColumn.HeaderText = "Сопутствующий диагноз";
            this.concomitantdiagnosisColumn.Name = "concomitantdiagnosisColumn";
            this.concomitantdiagnosisColumn.ReadOnly = true;
            // 
            // dateofbirthColumn
            // 
            this.dateofbirthColumn.HeaderText = "Дата рождения";
            this.dateofbirthColumn.Name = "dateofbirthColumn";
            this.dateofbirthColumn.ReadOnly = true;
            // 
            // mhiColumn
            // 
            this.mhiColumn.HeaderText = "Страховая медицинская организация";
            this.mhiColumn.Name = "mhiColumn";
            this.mhiColumn.ReadOnly = true;
            // 
            // mioColumn
            // 
            this.mioColumn.HeaderText = "№ ОМС";
            this.mioColumn.Name = "mioColumn";
            this.mioColumn.ReadOnly = true;
            // 
            // benefitcodeColumn
            // 
            this.benefitcodeColumn.HeaderText = "Код льготы";
            this.benefitcodeColumn.Name = "benefitcodeColumn";
            this.benefitcodeColumn.ReadOnly = true;
            // 
            // residenceaddressColumn
            // 
            this.residenceaddressColumn.HeaderText = "Адрес прописки";
            this.residenceaddressColumn.Name = "residenceaddressColumn";
            this.residenceaddressColumn.ReadOnly = true;
            // 
            // residentialaddressColumn
            // 
            this.residentialaddressColumn.HeaderText = "Адрес проживания";
            this.residentialaddressColumn.Name = "residentialaddressColumn";
            this.residentialaddressColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Телефон";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // placeofworkColumn
            // 
            this.placeofworkColumn.HeaderText = "Место работы";
            this.placeofworkColumn.Name = "placeofworkColumn";
            this.placeofworkColumn.ReadOnly = true;
            // 
            // professionColumn
            // 
            this.professionColumn.HeaderText = "Профессия";
            this.professionColumn.Name = "professionColumn";
            this.professionColumn.ReadOnly = true;
            // 
            // postColumn
            // 
            this.postColumn.HeaderText = "Должность";
            this.postColumn.Name = "postColumn";
            this.postColumn.ReadOnly = true;
            // 
            // dependentColumn
            // 
            this.dependentColumn.HeaderText = "Иждивенец";
            this.dependentColumn.Name = "dependentColumn";
            this.dependentColumn.ReadOnly = true;
            // 
            // documentnameColumn
            // 
            this.documentnameColumn.HeaderText = "Наименование документа";
            this.documentnameColumn.Name = "documentnameColumn";
            this.documentnameColumn.ReadOnly = true;
            // 
            // documentnumberColumn
            // 
            this.documentnumberColumn.HeaderText = "Серия/Номер";
            this.documentnumberColumn.Name = "documentnumberColumn";
            this.documentnumberColumn.ReadOnly = true;
            // 
            // documentdateColumn
            // 
            this.documentdateColumn.HeaderText = "Дата выдачи";
            this.documentdateColumn.Name = "documentdateColumn";
            this.documentdateColumn.ReadOnly = true;
            // 
            // documentissuedColumn
            // 
            this.documentissuedColumn.HeaderText = "Кем выдан";
            this.documentissuedColumn.Name = "documentissuedColumn";
            this.documentissuedColumn.ReadOnly = true;
            // 
            // medicationstakenColumn
            // 
            this.medicationstakenColumn.HeaderText = "Принимаемые препараты";
            this.medicationstakenColumn.Name = "medicationstakenColumn";
            this.medicationstakenColumn.ReadOnly = true;
            // 
            // attendingphysicianColumn
            // 
            this.attendingphysicianColumn.HeaderText = "Лечащий врач";
            this.attendingphysicianColumn.Name = "attendingphysicianColumn";
            this.attendingphysicianColumn.ReadOnly = true;
            // 
            // todaydayColumn
            // 
            this.todaydayColumn.HeaderText = "Дата заполнения";
            this.todaydayColumn.Name = "todaydayColumn";
            this.todaydayColumn.ReadOnly = true;
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCorrect.Location = new System.Drawing.Point(68, 350);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(757, 25);
            this.buttonCorrect.TabIndex = 3;
            this.buttonCorrect.Text = "Редактировать";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(37, 350);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(25, 25);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(25, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 388);
            this.Controls.Add(this.groupBoxDiagnosis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пациентов";
            this.groupBoxDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDiagnosis;
        public System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concomitantdiagnosisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn benefitcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceaddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentialaddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeofworkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentnumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentissuedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationstakenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendingphysicianColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todaydayColumn;
    }
}