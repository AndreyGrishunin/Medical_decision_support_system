﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MESysWin.src;
using MESysWin.GUI;

namespace MESysWin
{
    public partial class MainForm : Form
    {
        public List<src.Rule> Rules { get; set; }

        public MainForm()
        {
            InitializeComponent();

            DatabaseManager.Instance.DatabaseConnect();

            CheckUserDialog();

            Rules = new List<src.Rule>();
            UpdateRules();

            InitConsultation();

            Log.Print("Open MainForm", "mainForm", Log.type.INFO);
        }

        public void InitConsultation()
        {
            richTextBoxQuestion.Text = LogicOutput.Instance.GetQuestion();

            ShowButtons();
        }

        public void UpdateQuestion()
        {
            richTextBoxQuestion.Text += "\r\n\r\n";
            richTextBoxQuestion.Text += LogicOutput.Instance.GetQuestion();

            richTextBoxQuestion.SelectionStart = richTextBoxQuestion.Text.Length;
            richTextBoxQuestion.ScrollToCaret();

            ShowButtons();
        }

        public void ShowButtons()
        {
            switch(LogicOutput.Instance.State)
            {
                case LogicOutput.Specified.NEW:
                    button2.Text = "Нет (-)";
                    button3.Text = "Скорее нет";
                    button4.Text = "Не знаю (0)";
                    button5.Text = "Скорее да";
                    button6.Text = "Да (+)";

                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    break;
                case LogicOutput.Specified.SPEC_FUZZY:
                    int count = LogicOutput.Instance.CurrentComplaint.Fuzzy.Count;

                    if (count > 5) count = 5;
                    switch (count)
                    {
                        case 1:
                            button2.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[0].Name;

                            button2.Visible = true;
                            button3.Visible = false;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            break;
                        case 2:
                            button2.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[0].Name;
                            button3.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[1].Name;

                            button2.Visible = true;
                            button3.Visible = true;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            break;
                        case 3:
                            button2.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[0].Name;
                            button3.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[1].Name;
                            button4.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[2].Name;

                            button2.Visible = true;
                            button3.Visible = true;
                            button4.Visible = true;
                            button5.Visible = false;
                            button6.Visible = false;
                            break;
                        case 4:
                            button2.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[0].Name;
                            button3.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[1].Name;
                            button4.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[2].Name;
                            button5.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[3].Name;

                            button2.Visible = true;
                            button3.Visible = true;
                            button4.Visible = true;
                            button5.Visible = true;
                            button6.Visible = false;
                            break;
                        case 5:
                            button2.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[0].Name;
                            button3.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[1].Name;
                            button4.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[2].Name;
                            button5.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[3].Name;
                            button6.Text = LogicOutput.Instance.CurrentComplaint.Fuzzy[4].Name;

                            button2.Visible = true;
                            button3.Visible = true;
                            button4.Visible = true;
                            button5.Visible = true;
                            button6.Visible = true;
                            break;
                        default:
                            button2.Visible = false;
                            button3.Visible = false;
                            button4.Visible = false;
                            button5.Visible = false;
                            button6.Visible = false;
                            break;
                    }
                    break;
                case LogicOutput.Specified.FUZZYFICATED:
                    button2.Text = "Нет (-)";
                    button3.Text = "Скорее нет";
                    button4.Text = "Не знаю (0)";
                    button5.Text = "Скорее да";
                    button6.Text = "Да (+)";

                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = true;
                    break;
                case LogicOutput.Specified.END:
                    button2.Text = "Нет (-)";
                    button3.Text = "Скорее нет";
                    button4.Text = "Не знаю (0)";
                    button5.Text = "Скорее да";
                    button6.Text = "Да (+)";

                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = true;
                    break;
                case LogicOutput.Specified.CONSILIUM:
                default:
                    button2.Text = "Нет (-)";
                    button3.Text = "Скорее нет";
                    button4.Text = "Не знаю (0)";
                    button5.Text = "Скорее да";
                    button6.Text = "Да (+)";

                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    break;
            }
        }

        public void UpdateRules()
        {
            Rules.Clear();
            dataGridViewBase.Rows.Clear();

            Rules = DatabaseManager.Instance.GetRuleList();

            foreach (var rule in Rules)
            {
                string[] row = new string[] { rule.ID.ToString(), rule.Preview, rule.Conclusion.ID.ToString() };
                dataGridViewBase.Rows.Add(row);
            }
        }

        public void CheckUserDialog()
        {
            userToolStripMenuItem.Text = Settings.Instance.currenUser.Login;

            if (userToolStripMenuItem.Text == "Vasin_Vasiliy")
                {
                userToolStripMenuItem.Text = "Васин Василий Васильевич";
                }

            switch (Settings.Instance.currenUser.GroupId)
            {
                //case 1:
                //    break;
                case 2:
                    // Если врач (мед.персонал)
                    expertToolStripMenuItem.Visible = false;
                    consulToolStripMenuItem.Visible = false;
                    kbToolStripMenuItem.Visible = false;
                    admToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Enabled = false;
                    settingUserToolStripMenuItem.Enabled = true;
                    doctorToolStripMenuItem.Visible = true;
                    serviceToolStripMenuItem.Visible = true;
                    buttonAddRule.Enabled = false;
                    buttonRemoveRule.Enabled = false;
                    buttonEditRule.Enabled = false;
                    LogoutToolStripMenuItem.Visible = true;
                    break;
                case 3:
                    // Если эксперт или инженер по знаниям
                    expertToolStripMenuItem.Visible = true;
                    consulToolStripMenuItem.Visible = false;
                    kbToolStripMenuItem.Visible = false;
                    admToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Enabled = false;
                    settingUserToolStripMenuItem.Enabled = true;
                    doctorToolStripMenuItem.Visible = false;
                    serviceToolStripMenuItem.Visible = true;
                    buttonAddRule.Enabled = true;
                    buttonRemoveRule.Enabled = true;
                    buttonEditRule.Enabled = true;
                    tabControlMain.Enabled = true;
                    LogoutToolStripMenuItem.Visible = true;
                    break;
                case 4:
                    expertToolStripMenuItem.Visible = false;
                    kbToolStripMenuItem.Visible = true;
                    consulToolStripMenuItem.Visible = false;
                    admToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Enabled = false;
                    settingUserToolStripMenuItem.Enabled = true;
                    doctorToolStripMenuItem.Visible = false;
                    serviceToolStripMenuItem.Visible = true;
                    lingVarToolStripMenuItem.Visible = false;
                    buttonAddRule.Enabled = true;
                    buttonRemoveRule.Enabled = true;
                    buttonEditRule.Enabled = true;
                    LogoutToolStripMenuItem.Visible = true;
                    break;

                case 5:
                    expertToolStripMenuItem.Visible = false;
                    consulToolStripMenuItem.Visible = true;
                    kbToolStripMenuItem.Visible = false;
                    admToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Visible = true;
                    medBookToolStripMenuItem.Enabled = true;
                    doctorToolStripMenuItem.Visible = false;
                    settingUserToolStripMenuItem.Enabled = true;
                    serviceToolStripMenuItem.Visible = true;
                    
                    buttonAddRule.Enabled = false;
                    buttonRemoveRule.Enabled = false;
                    buttonEditRule.Enabled = false;
                    LogoutToolStripMenuItem.Visible = true;
                    tabControlMain.Enabled = true;
                    break;

                case 6:
                    expertToolStripMenuItem.Visible = false;
                    kbToolStripMenuItem.Visible = false;
                    consulToolStripMenuItem.Visible = false;
                    admToolStripMenuItem.Visible = true;
                    medBookToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Enabled = false;
                    settingUserToolStripMenuItem.Enabled = true;
                    doctorToolStripMenuItem.Visible = false;
                    serviceToolStripMenuItem.Visible = true;
                    buttonAddRule.Enabled = false;
                    buttonRemoveRule.Enabled = false;
                    buttonEditRule.Enabled = false;
                    LogoutToolStripMenuItem.Visible = true;
                    break;
                    break;

                default:
                    // Если гость (по умолчанию)
                    expertToolStripMenuItem.Visible = false;
                    consulToolStripMenuItem.Visible = false;
                    kbToolStripMenuItem.Visible = false;
                    admToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Visible = false;
                    medBookToolStripMenuItem.Enabled = false;
                    doctorToolStripMenuItem.Visible = false;
                    settingUserToolStripMenuItem.Enabled = false;
                    serviceToolStripMenuItem.Visible = false;
                    buttonAddRule.Enabled = false;
                    buttonRemoveRule.Enabled = false;
                    buttonEditRule.Enabled = false;
                    LogoutToolStripMenuItem.Visible = false;
                    tabControlMain.Enabled = false;
                    break;
            }
        }

        private void timerForLog_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelInfo.Text = Log.lastLine;
        }

        private void lingVarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> KnowBase -> Symptoms", "mainForm", Log.type.INFO);
            var symptomsForm = new LingVar();
            symptomsForm.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> KnowBase -> MF_types", "mainForm", Log.type.INFO);
            var typeForm = new TypeMFform();
            typeForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> File -> Exit", "mainForm", Log.type.INFO);
            this.Close();
        }

        private void BoundaryTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> KnowBase -> Boundary type", "mainForm", Log.type.INFO);
            var typeForm = new BoundaryTypeForm();
            typeForm.Show();
        }

        private void quantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> KnowBase -> Quant", "mainForm", Log.type.INFO);
            var quantForm = new QuantForm();
            quantForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> Administrator -> users", "mainForm", Log.type.INFO);
            var UsersForm = new GUI.UserControl();
            UsersForm.ShowDialog();
            CheckUserDialog();
        }

        private void symptomEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Log.Print("Click Menu -> Expert -> Symptoms", "mainForm", Log.type.INFO);
            var symptomsForm = new LingVar();
            symptomsForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBoxForm();
            about.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.ShowDialog();
            CheckUserDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Instance.Logout();
            CheckUserDialog();
        }

        private void settingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAdd = new UserEdit(Settings.Instance.currenUser);
            formAdd.Owner = this;
            formAdd.comboBoxGroup.Enabled = false;
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("OK");
            }
            CheckUserDialog();
        }

        private void diagnosisListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diaForm = new DiagnosisForm();
            diaForm.Show();
        }

        private void patientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var patientForm = new GUI.PatientForm();
            patientForm.Show();
        }


        private void medBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Instance.currenUser.Login = "Васин Василий Васильевич";
            var clientCardForm = new ClientCardForm(Settings.Instance.currenUser);
            clientCardForm.Show();
        }

        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            var ruleEditor = new KnowledgeBased(new src.Rule());

            if (ruleEditor.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("База знаний обновилась!", "Сообщение об изменении", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRules();
            }
        }

        private void kbaseEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void buttonRemoveRule_Click(object sender, EventArgs e)
        {
            if (dataGridViewBase.SelectedCells.Count > 0)
            {
                DatabaseManager.Instance.DeleteFromTable(Convert.ToInt64(dataGridViewBase.Rows[dataGridViewBase.SelectedCells[0].RowIndex].Cells[0].Value), "knowledge_base", "id_rule");
                MessageBox.Show("База знаний обновилась!", "Сообщение об изменении", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRules();
            } else
            {
                MessageBox.Show("Ничего не выделено для удаления. Выделите один антецедент в правиле, чтобы его удалить.", "Удаление не произошло", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEditRule_Click(object sender, EventArgs e)
        {
            if (dataGridViewBase.SelectedCells.Count > 0)
            {
                int i = dataGridViewBase.SelectedCells[0].RowIndex;
                var currRule = new src.Rule();
                currRule.ID = Convert.ToInt64(dataGridViewBase.Rows[i].Cells[0].Value);
                currRule.Preview = dataGridViewBase.Rows[i].Cells[1].Value.ToString();
                currRule.Conclusion = DatabaseManager.Instance.GetDiagnosis(Convert.ToInt64(dataGridViewBase.Rows[i].Cells[2].Value));

                var ruleEditor = new KnowledgeBased(currRule);

                if (ruleEditor.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("База знаний обновилась!", "Сообщение об изменении", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateRules();
                }
            } else
            {
                MessageBox.Show("Ничего не выделено для редактирования. Выделите одно правило, чтобы его отредактировать.", "Редактирование невозможно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Переключение внизу (Index - выбор позиции из Welcome, Консультация, БД 
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (tabControlMain.SelectedIndex == 1)
            {
                throw new Exception(Microsoft.SqlServer.Server.SystemDataAccessKind.None.ToString());
            }
            */
        }

        private void diagnosDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;

            LogicOutput.Instance.Initialization();
            InitConsultation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Text += button2.Text;
            LogicOutput.Instance.SetAnswer(0);
            UpdateQuestion();
            UpdateHipotez();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Text += button6.Text;
            LogicOutput.Instance.SetAnswer(4);
            UpdateQuestion();
            UpdateHipotez();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Text += button3.Text;
            LogicOutput.Instance.SetAnswer(1);
            UpdateQuestion();
            UpdateHipotez();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Text += button4.Text;
            LogicOutput.Instance.SetAnswer(2);
            UpdateQuestion();
            UpdateHipotez();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Text += button5.Text;
            LogicOutput.Instance.SetAnswer(3);
            UpdateQuestion();
            UpdateHipotez();
        }

        private void UpdateHipotez()
        {

            dataGridViewSecondHipotez.Rows.Clear();
            dataGridViewHipotez.Rows.Clear();
            foreach (var hip in LogicOutput.Instance.Hipotezes)
            {
                if (hip.Coincidence > 0)
                {
                    string[] row = new string[] { hip.HipoteticDiagnosis.Name, String.Format("{0:0.00}", (hip.Coincidence * 100)) };
                    if (hip.Coincidence > 0.5f)
                    {
                        dataGridViewHipotez.Rows.Add(row);
                        DatabaseManager.Instance.UpdateDiagnosis(row[0]); // передача названия диагноза в метод UpdateDiagnosis
 
                    }
                    else
                    {
                        dataGridViewSecondHipotez.Rows.Add(row);
                    }
                }
            }
            //dataGridViewHipotez.Sort(dataGridViewHipotez.Columns[1], ListSortDirection.Descending);

            //dataGridViewSecondHipotez.Rows.Clear();
            //foreach (var hip2 in LogicOutput.Instance.NeuroNetHipotez)
            //{
            //    if (hip2.Coincidence > 0)
            //    {
            //        string[] row = new string[] { hip2.HipoteticDiagnosis.Name, String.Format("{0:0.00}", (hip2.Coincidence * 100)) };
            //        dataGridViewSecondHipotez.Rows.Add(row);
            //    }
            //}
        }

        private void dataGridViewHipotez_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHipotez.SelectedCells.Count > 0) {
                dataGridViewSecondHipotez.ClearSelection();
                var diagns = DatabaseManager.Instance.GetDiagnosis();
                foreach (var d in diagns)
                {
                    int i = dataGridViewHipotez.SelectedCells[0].RowIndex;
                    if (d.Name.Equals(dataGridViewHipotez.Rows[i].Cells[0].Value.ToString()))
                    {
                        richTextBoxDescription.Text = d.Description;
                        richTextBoxSympt.Text = d.Symptoms;
                        richTextBoxTreatment.Text = d.Treatment;
                    }
                }
            }
        }

        private void dataGridViewSecondHipotez_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSecondHipotez.SelectedCells.Count > 0)
            {
                dataGridViewHipotez.ClearSelection();
                var diagns = DatabaseManager.Instance.GetDiagnosis();
                foreach (var d in diagns)
                {
                    int i = dataGridViewSecondHipotez.SelectedCells[0].RowIndex;
                    if (d.Name.Equals(dataGridViewSecondHipotez.Rows[i].Cells[0].Value.ToString()))
                    {
                        richTextBoxDescription.Text = d.Description;
                        richTextBoxSympt.Text = d.Symptoms;
                        richTextBoxTreatment.Text = d.Treatment;
                    }
                }
            }
        }

        private void Familiarize_with_medicinal_productsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var Prescribed_medications = new Prescribed_medications();
            Prescribed_medications.ShowDialog();
        }

        //private void назначитьЛекарственныеПрепаратыToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    var lekarstvinie_sredstvo = new Lekarstvinie_sredstvo();
        //    lekarstvinie_sredstvo.ShowDialog();
        //}
    }
}
