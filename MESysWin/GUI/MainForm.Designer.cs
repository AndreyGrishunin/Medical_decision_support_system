using System.Windows.Forms;

namespace MESysWin
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerForLog = new System.Windows.Forms.Timer(this.components);
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Familiarize_with_medicinal_productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symptomEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbaseEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначитьЛекарственныеПрепаратыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lingVarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoundaryTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageBase = new System.Windows.Forms.TabPage();
            this.buttonEditRule = new System.Windows.Forms.Button();
            this.groupBoxBase = new System.Windows.Forms.GroupBox();
            this.dataGridViewBase = new System.Windows.Forms.DataGridView();
            this.IdRuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemoveRule = new System.Windows.Forms.Button();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.tabPageConsultation = new System.Windows.Forms.TabPage();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxHipotez = new System.Windows.Forms.GroupBox();
            this.dataGridViewHipotez = new System.Windows.Forms.DataGridView();
            this.DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSecondHipotez = new System.Windows.Forms.GroupBox();
            this.dataGridViewSecondHipotez = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.groupBoxSympt = new System.Windows.Forms.GroupBox();
            this.richTextBoxSympt = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTreatment = new System.Windows.Forms.GroupBox();
            this.richTextBoxTreatment = new System.Windows.Forms.RichTextBox();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.pictureBoxBg = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainForm.SuspendLayout();
            this.menuStripLogin.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tabPageBase.SuspendLayout();
            this.groupBoxBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase)).BeginInit();
            this.tabPageConsultation.SuspendLayout();
            this.groupBoxQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxHipotez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHipotez)).BeginInit();
            this.groupBoxSecondHipotez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondHipotez)).BeginInit();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxSympt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBoxTreatment.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 795);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(929, 22);
            this.statusStripMainForm.TabIndex = 1;
            this.statusStripMainForm.Text = "statusStripMainForm";
            this.statusStripMainForm.Visible = false;
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabelInfo.Text = "Log";
            // 
            // timerForLog
            // 
            this.timerForLog.Tick += new System.EventHandler(this.timerForLog_Tick);
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.BackColor = System.Drawing.Color.Transparent;
            this.menuStripLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStripLogin.Location = new System.Drawing.Point(844, 0);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Size = new System.Drawing.Size(177, 804);
            this.menuStripLogin.TabIndex = 4;
            this.menuStripLogin.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(164, 23);
            this.userToolStripMenuItem.Text = "Пользователь: Гость";
            this.userToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // consulToolStripMenuItem
            // 
            this.consulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosDialogToolStripMenuItem,
            this.medBookToolStripMenuItem,
            this.Familiarize_with_medicinal_productsToolStripMenuItem});
            this.consulToolStripMenuItem.Name = "consulToolStripMenuItem";
            this.consulToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.consulToolStripMenuItem.Text = "Пациент";
            // 
            // diagnosDialogToolStripMenuItem
            // 
            this.diagnosDialogToolStripMenuItem.Name = "diagnosDialogToolStripMenuItem";
            this.diagnosDialogToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.diagnosDialogToolStripMenuItem.Text = "Консультация";
            this.diagnosDialogToolStripMenuItem.Click += new System.EventHandler(this.diagnosDialogToolStripMenuItem_Click);
            // 
            // medBookToolStripMenuItem
            // 
            this.medBookToolStripMenuItem.Name = "medBookToolStripMenuItem";
            this.medBookToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.medBookToolStripMenuItem.Text = "Карта пациента";
            this.medBookToolStripMenuItem.Click += new System.EventHandler(this.medBookToolStripMenuItem_Click);
            // 
            // Familiarize_with_medicinal_productsToolStripMenuItem
            // 
            this.Familiarize_with_medicinal_productsToolStripMenuItem.Name = "Familiarize_with_medicinal_productsToolStripMenuItem";
            this.Familiarize_with_medicinal_productsToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.Familiarize_with_medicinal_productsToolStripMenuItem.Text = "Назначенные лекарственные препараты";
            this.Familiarize_with_medicinal_productsToolStripMenuItem.Click += new System.EventHandler(this.Familiarize_with_medicinal_productsToolStripMenuItem_Click_1);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosisListToolStripMenuItem,
            this.symptomEditorToolStripMenuItem,
            this.kbaseEditorToolStripMenuItem});
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.expertToolStripMenuItem.Text = "Эксперт";
            // 
            // diagnosisListToolStripMenuItem
            // 
            this.diagnosisListToolStripMenuItem.Name = "diagnosisListToolStripMenuItem";
            this.diagnosisListToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.diagnosisListToolStripMenuItem.Text = "Список диагнозов";
            this.diagnosisListToolStripMenuItem.Click += new System.EventHandler(this.diagnosisListToolStripMenuItem_Click);
            // 
            // symptomEditorToolStripMenuItem
            // 
            this.symptomEditorToolStripMenuItem.Name = "symptomEditorToolStripMenuItem";
            this.symptomEditorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.symptomEditorToolStripMenuItem.Text = "Редактор симптоматики";
            this.symptomEditorToolStripMenuItem.Click += new System.EventHandler(this.symptomEditorToolStripMenuItem_Click);
            // 
            // kbaseEditorToolStripMenuItem
            // 
            this.kbaseEditorToolStripMenuItem.Name = "kbaseEditorToolStripMenuItem";
            this.kbaseEditorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.kbaseEditorToolStripMenuItem.Text = "Редактор базы знаний";
            this.kbaseEditorToolStripMenuItem.Click += new System.EventHandler(this.kbaseEditorToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsListToolStripMenuItem,
            this.назначитьЛекарственныеПрепаратыToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.doctorToolStripMenuItem.Text = "Врач";
            // 
            // patientsListToolStripMenuItem
            // 
            this.patientsListToolStripMenuItem.Name = "patientsListToolStripMenuItem";
            this.patientsListToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.patientsListToolStripMenuItem.Text = "Список пациентов";
            this.patientsListToolStripMenuItem.Click += new System.EventHandler(this.patientsListToolStripMenuItem_Click);
            // 
            // назначитьЛекарственныеПрепаратыToolStripMenuItem
            // 
            this.назначитьЛекарственныеПрепаратыToolStripMenuItem.Name = "назначитьЛекарственныеПрепаратыToolStripMenuItem";
            this.назначитьЛекарственныеПрепаратыToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.назначитьЛекарственныеПрепаратыToolStripMenuItem.Text = "Назначить лекарственные препараты";
            // 
            // kbToolStripMenuItem
            // 
            this.kbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lingVarToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.BoundaryTypeToolStripMenuItem,
            this.quantToolStripMenuItem});
            this.kbToolStripMenuItem.Name = "kbToolStripMenuItem";
            this.kbToolStripMenuItem.Size = new System.Drawing.Size(149, 21);
            this.kbToolStripMenuItem.Text = "Инженер по знаниям";
            // 
            // lingVarToolStripMenuItem
            // 
            this.lingVarToolStripMenuItem.Name = "lingVarToolStripMenuItem";
            this.lingVarToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.lingVarToolStripMenuItem.Text = "Симптомы в нечеткой логике";
            this.lingVarToolStripMenuItem.Click += new System.EventHandler(this.lingVarToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.typeToolStripMenuItem.Text = "Типы функций принадлежности";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // BoundaryTypeToolStripMenuItem
            // 
            this.BoundaryTypeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.BoundaryTypeToolStripMenuItem.Name = "BoundaryTypeToolStripMenuItem";
            this.BoundaryTypeToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.BoundaryTypeToolStripMenuItem.Text = "Пограничные типы функций принадлежности";
            this.BoundaryTypeToolStripMenuItem.Click += new System.EventHandler(this.BoundaryTypeToolStripMenuItem_Click);
            // 
            // quantToolStripMenuItem
            // 
            this.quantToolStripMenuItem.Name = "quantToolStripMenuItem";
            this.quantToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.quantToolStripMenuItem.Text = "Квантификаторы";
            this.quantToolStripMenuItem.Click += new System.EventHandler(this.quantToolStripMenuItem_Click);
            // 
            // admToolStripMenuItem
            // 
            this.admToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.admToolStripMenuItem.Name = "admToolStripMenuItem";
            this.admToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.admToolStripMenuItem.Text = "Администратор";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.usersToolStripMenuItem.Text = "Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingUserToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // settingUserToolStripMenuItem
            // 
            this.settingUserToolStripMenuItem.Name = "settingUserToolStripMenuItem";
            this.settingUserToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.settingUserToolStripMenuItem.Text = "Настройки пользователя";
            this.settingUserToolStripMenuItem.Click += new System.EventHandler(this.settingUserToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.settingsToolStripMenuItem.Text = "Настройки приложения";
            this.settingsToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "О программе...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.Transparent;
            this.menuStripMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.consulToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.kbToolStripMenuItem,
            this.admToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(13, 6, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(844, 29);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.LogoutToolStripMenuItem.Text = "Выйти из системы";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // tabPageBase
            // 
            this.tabPageBase.Controls.Add(this.buttonEditRule);
            this.tabPageBase.Controls.Add(this.groupBoxBase);
            this.tabPageBase.Controls.Add(this.buttonRemoveRule);
            this.tabPageBase.Controls.Add(this.buttonAddRule);
            this.tabPageBase.Location = new System.Drawing.Point(4, 4);
            this.tabPageBase.Name = "tabPageBase";
            this.tabPageBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBase.Size = new System.Drawing.Size(973, 725);
            this.tabPageBase.TabIndex = 2;
            this.tabPageBase.Text = "База знаний";
            this.tabPageBase.UseVisualStyleBackColor = true;
            // 
            // buttonEditRule
            // 
            this.buttonEditRule.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonEditRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditRule.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditRule.Location = new System.Drawing.Point(316, 619);
            this.buttonEditRule.Name = "buttonEditRule";
            this.buttonEditRule.Size = new System.Drawing.Size(150, 23);
            this.buttonEditRule.TabIndex = 3;
            this.buttonEditRule.Text = "Изменить правило";
            this.buttonEditRule.UseVisualStyleBackColor = true;
            this.buttonEditRule.Click += new System.EventHandler(this.buttonEditRule_Click);
            // 
            // groupBoxBase
            // 
            this.groupBoxBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase.Controls.Add(this.dataGridViewBase);
            this.groupBoxBase.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBase.Name = "groupBoxBase";
            this.groupBoxBase.Size = new System.Drawing.Size(836, 674);
            this.groupBoxBase.TabIndex = 1;
            this.groupBoxBase.TabStop = false;
            this.groupBoxBase.Text = "Правила";
            // 
            // dataGridViewBase
            // 
            this.dataGridViewBase.AllowUserToAddRows = false;
            this.dataGridViewBase.AllowUserToDeleteRows = false;
            this.dataGridViewBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRuleColumn,
            this.RuleColumn,
            this.IdDiagnosisColumn});
            this.dataGridViewBase.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewBase.Name = "dataGridViewBase";
            this.dataGridViewBase.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBase.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBase.RowTemplate.Height = 66;
            this.dataGridViewBase.Size = new System.Drawing.Size(828, 653);
            this.dataGridViewBase.TabIndex = 0;
            // 
            // IdRuleColumn
            // 
            this.IdRuleColumn.HeaderText = "ID";
            this.IdRuleColumn.Name = "IdRuleColumn";
            this.IdRuleColumn.ReadOnly = true;
            this.IdRuleColumn.Width = 50;
            // 
            // RuleColumn
            // 
            this.RuleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RuleColumn.HeaderText = "Правило";
            this.RuleColumn.Name = "RuleColumn";
            this.RuleColumn.ReadOnly = true;
            // 
            // IdDiagnosisColumn
            // 
            this.IdDiagnosisColumn.HeaderText = "ID диагноза";
            this.IdDiagnosisColumn.Name = "IdDiagnosisColumn";
            this.IdDiagnosisColumn.ReadOnly = true;
            // 
            // buttonRemoveRule
            // 
            this.buttonRemoveRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveRule.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveRule.Location = new System.Drawing.Point(160, 619);
            this.buttonRemoveRule.Name = "buttonRemoveRule";
            this.buttonRemoveRule.Size = new System.Drawing.Size(150, 23);
            this.buttonRemoveRule.TabIndex = 2;
            this.buttonRemoveRule.Text = "Удалить правило";
            this.buttonRemoveRule.UseVisualStyleBackColor = true;
            this.buttonRemoveRule.Click += new System.EventHandler(this.buttonRemoveRule_Click);
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddRule.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRule.Location = new System.Drawing.Point(4, 619);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(150, 23);
            this.buttonAddRule.TabIndex = 1;
            this.buttonAddRule.Text = "Добавить правило";
            this.buttonAddRule.UseVisualStyleBackColor = true;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // tabPageConsultation
            // 
            this.tabPageConsultation.Controls.Add(this.groupBoxQuestion);
            this.tabPageConsultation.Controls.Add(this.splitContainer1);
            this.tabPageConsultation.Controls.Add(this.groupBoxDescription);
            this.tabPageConsultation.Location = new System.Drawing.Point(4, 4);
            this.tabPageConsultation.Name = "tabPageConsultation";
            this.tabPageConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultation.Size = new System.Drawing.Size(973, 725);
            this.tabPageConsultation.TabIndex = 1;
            this.tabPageConsultation.Text = "Консультация";
            this.tabPageConsultation.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxQuestion.Controls.Add(this.button6);
            this.groupBoxQuestion.Controls.Add(this.button5);
            this.groupBoxQuestion.Controls.Add(this.button4);
            this.groupBoxQuestion.Controls.Add(this.button3);
            this.groupBoxQuestion.Controls.Add(this.button2);
            this.groupBoxQuestion.Controls.Add(this.richTextBoxQuestion);
            this.groupBoxQuestion.Location = new System.Drawing.Point(6, 6);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(961, 160);
            this.groupBoxQuestion.TabIndex = 0;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Ответьте, пожалуйста, на вопрос:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(855, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Да (+)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(749, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Наверное да";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(219, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(524, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Не знаю (0)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(113, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Наверное нет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(7, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Нет (-)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxQuestion.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(945, 96);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 173);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxHipotez);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxSecondHipotez);
            this.splitContainer1.Size = new System.Drawing.Size(955, 149);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxHipotez
            // 
            this.groupBoxHipotez.Controls.Add(this.dataGridViewHipotez);
            this.groupBoxHipotez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxHipotez.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHipotez.Name = "groupBoxHipotez";
            this.groupBoxHipotez.Size = new System.Drawing.Size(493, 149);
            this.groupBoxHipotez.TabIndex = 0;
            this.groupBoxHipotez.TabStop = false;
            this.groupBoxHipotez.Text = "Основная гипотеза:";
            // 
            // dataGridViewHipotez
            // 
            this.dataGridViewHipotez.AllowUserToAddRows = false;
            this.dataGridViewHipotez.AllowUserToDeleteRows = false;
            this.dataGridViewHipotez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHipotez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiagnosisColumn,
            this.PercentColumn});
            this.dataGridViewHipotez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHipotez.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewHipotez.Name = "dataGridViewHipotez";
            this.dataGridViewHipotez.ReadOnly = true;
            this.dataGridViewHipotez.Size = new System.Drawing.Size(487, 130);
            this.dataGridViewHipotez.TabIndex = 0;
            this.dataGridViewHipotez.SelectionChanged += new System.EventHandler(this.dataGridViewHipotez_SelectionChanged);
            // 
            // DiagnosisColumn
            // 
            this.DiagnosisColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiagnosisColumn.HeaderText = "Диагноз";
            this.DiagnosisColumn.Name = "DiagnosisColumn";
            this.DiagnosisColumn.ReadOnly = true;
            // 
            // PercentColumn
            // 
            this.PercentColumn.HeaderText = "Вероятность (%):";
            this.PercentColumn.Name = "PercentColumn";
            this.PercentColumn.ReadOnly = true;
            this.PercentColumn.Width = 150;
            // 
            // groupBoxSecondHipotez
            // 
            this.groupBoxSecondHipotez.Controls.Add(this.dataGridViewSecondHipotez);
            this.groupBoxSecondHipotez.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSecondHipotez.Name = "groupBoxSecondHipotez";
            this.groupBoxSecondHipotez.Size = new System.Drawing.Size(464, 149);
            this.groupBoxSecondHipotez.TabIndex = 0;
            this.groupBoxSecondHipotez.TabStop = false;
            this.groupBoxSecondHipotez.Text = "Дополнительные предположения:";
            // 
            // dataGridViewSecondHipotez
            // 
            this.dataGridViewSecondHipotez.AllowUserToAddRows = false;
            this.dataGridViewSecondHipotez.AllowUserToDeleteRows = false;
            this.dataGridViewSecondHipotez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecondHipotez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewSecondHipotez.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridViewSecondHipotez.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSecondHipotez.Name = "dataGridViewSecondHipotez";
            this.dataGridViewSecondHipotez.ReadOnly = true;
            this.dataGridViewSecondHipotez.Size = new System.Drawing.Size(453, 130);
            this.dataGridViewSecondHipotez.TabIndex = 1;
            this.dataGridViewSecondHipotez.SelectionChanged += new System.EventHandler(this.dataGridViewSecondHipotez_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Вероятность (%):";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescription.Controls.Add(this.groupBoxSympt);
            this.groupBoxDescription.Controls.Add(this.splitContainer2);
            this.groupBoxDescription.Location = new System.Drawing.Point(6, 328);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(952, 390);
            this.groupBoxDescription.TabIndex = 2;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Описание заболевания:";
            // 
            // groupBoxSympt
            // 
            this.groupBoxSympt.Controls.Add(this.richTextBoxSympt);
            this.groupBoxSympt.Location = new System.Drawing.Point(328, 0);
            this.groupBoxSympt.Name = "groupBoxSympt";
            this.groupBoxSympt.Size = new System.Drawing.Size(632, 184);
            this.groupBoxSympt.TabIndex = 0;
            this.groupBoxSympt.TabStop = false;
            this.groupBoxSympt.Text = "Характерные симптомы";
            // 
            // richTextBoxSympt
            // 
            this.richTextBoxSympt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSympt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSympt.Location = new System.Drawing.Point(0, 16);
            this.richTextBoxSympt.Name = "richTextBoxSympt";
            this.richTextBoxSympt.Size = new System.Drawing.Size(624, 168);
            this.richTextBoxSympt.TabIndex = 0;
            this.richTextBoxSympt.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxDescription);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(946, 371);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(320, 371);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBoxTreatment);
            this.splitContainer3.Size = new System.Drawing.Size(622, 371);
            this.splitContainer3.SplitterDistance = 165;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBoxTreatment
            // 
            this.groupBoxTreatment.Controls.Add(this.richTextBoxTreatment);
            this.groupBoxTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTreatment.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTreatment.Name = "groupBoxTreatment";
            this.groupBoxTreatment.Size = new System.Drawing.Size(622, 202);
            this.groupBoxTreatment.TabIndex = 0;
            this.groupBoxTreatment.TabStop = false;
            this.groupBoxTreatment.Text = "Лечение";
            // 
            // richTextBoxTreatment
            // 
            this.richTextBoxTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTreatment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxTreatment.Location = new System.Drawing.Point(0, 16);
            this.richTextBoxTreatment.Name = "richTextBoxTreatment";
            this.richTextBoxTreatment.Size = new System.Drawing.Size(624, 192);
            this.richTextBoxTreatment.TabIndex = 0;
            this.richTextBoxTreatment.Text = "";
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.pictureBoxBg);
            this.tabPageMain.Location = new System.Drawing.Point(4, 4);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(973, 725);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Welcome";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBg
            // 
            this.pictureBoxBg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg.BackgroundImage")));
            this.pictureBoxBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBg.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBg.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.pictureBoxBg.Name = "pictureBoxBg";
            this.pictureBoxBg.Size = new System.Drawing.Size(973, 717);
            this.pictureBoxBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBg.TabIndex = 0;
            this.pictureBoxBg.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageConsultation);
            this.tabControlMain.Controls.Add(this.tabPageBase);
            this.tabControlMain.ItemSize = new System.Drawing.Size(100, 18);
            this.tabControlMain.Location = new System.Drawing.Point(12, 49);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(981, 751);
            this.tabControlMain.TabIndex = 5;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.patientsToolStripMenuItem.Text = "Пациенты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1021, 804);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.menuStripLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStripMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(1037, 843);
            this.MinimumSize = new System.Drawing.Size(1037, 843);
            this.Name = "MainForm";
            this.Text = "HEALTHCARE";
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPageBase.ResumeLayout(false);
            this.groupBoxBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase)).EndInit();
            this.tabPageConsultation.ResumeLayout(false);
            this.groupBoxQuestion.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxHipotez.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHipotez)).EndInit();
            this.groupBoxSecondHipotez.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondHipotez)).EndInit();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxSympt.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBoxTreatment.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.Timer timerForLog;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosisListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symptomEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kbaseEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lingVarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoundaryTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.TabPage tabPageBase;
        private System.Windows.Forms.GroupBox groupBoxBase;
        private System.Windows.Forms.Button buttonEditRule;
        private System.Windows.Forms.Button buttonRemoveRule;
        private System.Windows.Forms.Button buttonAddRule;
        private System.Windows.Forms.DataGridView dataGridViewBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRuleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiagnosisColumn;
        private System.Windows.Forms.TabPage tabPageConsultation;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBoxSympt;
        private System.Windows.Forms.RichTextBox richTextBoxSympt;
        private System.Windows.Forms.GroupBox groupBoxTreatment;
        private System.Windows.Forms.RichTextBox richTextBoxTreatment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxHipotez;
        private System.Windows.Forms.DataGridView dataGridViewHipotez;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentColumn;
        private System.Windows.Forms.GroupBox groupBoxSecondHipotez;
        private System.Windows.Forms.DataGridView dataGridViewSecondHipotez;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.PictureBox pictureBoxBg;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private ToolStripMenuItem LogoutToolStripMenuItem;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem назначитьЛекарственныеПрепаратыToolStripMenuItem;
        private ToolStripMenuItem Familiarize_with_medicinal_productsToolStripMenuItem;
    }
}

