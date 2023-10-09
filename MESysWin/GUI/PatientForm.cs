using MESysWin.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.GUI
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();

            var listPatgn = DatabaseManager.Instance.GetPatient();

            foreach (var pat in listPatgn)
            {
                string[] row = new string[] { pat.ID.ToString(), pat.Name, pat.Gender, pat.Age, pat.Symptoms, pat.Diagnosis, pat.Concomitant_diagnosis, pat.Date_of_birth, pat.MHI, pat.MHO, pat.Benefit_code, pat.Residence_address, pat.Residential_address, pat.Phone, pat.Place_of_work, pat.Profession, pat.Post, pat.Dependent, pat.Document_name, pat.Document_number, pat.Document_date, pat.Document_issued, pat.Medications_taken, pat.Attending_physician, pat.Today_day };
                dataGridViewPatient.Rows.Add(row);
            }
    }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatient.SelectedCells.Count > 0)
            {
                var i = dataGridViewPatient.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewPatient.Rows[i].Cells[0].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о диагнозе из базы знаний, из базы данных и из приложения?\n",
                        String.Format("Удаление {0}", Convert.ToString(dataGridViewPatient.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DatabaseManager.Instance.DeleteFromTable(id_in_db, "patient", "patient_id"))
                    {
                        dataGridViewPatient.Rows.RemoveAt(i);
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете удалить выбранную запись, по той причине, что она используется в правиле Базы Знаний." +
                            " Её удаление приведет к неправильной работе приложения." +
                            " Чтобы удалить эту переменную, удалите или измените сначала правило из базы знаний в котором она используется.",
                            "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var patientEdit = new PatientEdit(new Patient(String.Empty));
            patientEdit.Owner = this;
            patientEdit.ShowDialog();
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatient.SelectedCells.Count > 0)
            {
                var i = dataGridViewPatient.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewPatient.Rows[i].Cells[0].Value);
                var prototype = new Patient(Convert.ToString(dataGridViewPatient.Rows[i].Cells[0].Value));
                prototype.ID = Convert.ToInt64(dataGridViewPatient.Rows[i].Cells[0].Value);
                prototype.Name = Convert.ToString(dataGridViewPatient.Rows[i].Cells[1].Value);
                prototype.Gender = Convert.ToString(dataGridViewPatient.Rows[i].Cells[2].Value);
                prototype.Age = Convert.ToString(dataGridViewPatient.Rows[i].Cells[3].Value);
                prototype.Symptoms = Convert.ToString(dataGridViewPatient.Rows[i].Cells[4].Value);
                prototype.Diagnosis = Convert.ToString(dataGridViewPatient.Rows[i].Cells[5].Value);
                prototype.Concomitant_diagnosis = Convert.ToString(dataGridViewPatient.Rows[i].Cells[6].Value);
                prototype.Date_of_birth = Convert.ToString(dataGridViewPatient.Rows[i].Cells[7].Value);
                prototype.MHI = Convert.ToString(dataGridViewPatient.Rows[i].Cells[8].Value);
                prototype.MHO = Convert.ToString(dataGridViewPatient.Rows[i].Cells[9].Value);
                prototype.Benefit_code = Convert.ToString(dataGridViewPatient.Rows[i].Cells[10].Value);
                prototype.Residence_address = Convert.ToString(dataGridViewPatient.Rows[i].Cells[11].Value);
                prototype.Residential_address = Convert.ToString(dataGridViewPatient.Rows[i].Cells[12].Value);
                prototype.Phone = Convert.ToString(dataGridViewPatient.Rows[i].Cells[13].Value);
                prototype.Place_of_work = Convert.ToString(dataGridViewPatient.Rows[i].Cells[14].Value);
                prototype.Profession = Convert.ToString(dataGridViewPatient.Rows[i].Cells[15].Value);
                prototype.Post = Convert.ToString(dataGridViewPatient.Rows[i].Cells[16].Value);
                prototype.Dependent = Convert.ToString(dataGridViewPatient.Rows[i].Cells[17].Value);
                prototype.Document_name = Convert.ToString(dataGridViewPatient.Rows[i].Cells[18].Value);
                prototype.Document_number = Convert.ToString(dataGridViewPatient.Rows[i].Cells[19].Value);
                prototype.Document_date = Convert.ToString(dataGridViewPatient.Rows[i].Cells[20].Value);
                prototype.Document_issued = Convert.ToString(dataGridViewPatient.Rows[i].Cells[21].Value);
                prototype.Medications_taken = Convert.ToString(dataGridViewPatient.Rows[i].Cells[22].Value);
                prototype.Attending_physician = Convert.ToString(dataGridViewPatient.Rows[i].Cells[23].Value);
                prototype.Today_day = Convert.ToString(dataGridViewPatient.Rows[i].Cells[24].Value);

                var patientEdit = new PatientEdit(prototype);
                patientEdit.Owner = this;
                patientEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
