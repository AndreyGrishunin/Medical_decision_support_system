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
    public partial class PatientEdit : Form
    {
        private string day_today;
        public PatientEdit(Patient patient)
        {
            InitializeComponent();
            prototypePatient = patient;
            Nametext.Text = prototypePatient.Name;
            Gendertext.Text = prototypePatient.Gender;
            Agetext.Text = prototypePatient.Age;
            PatientSymptomstext.Text = prototypePatient.Symptoms;
            PatientDiagnosistext.Text = prototypePatient.Diagnosis;
            ConcomitantDiagnosistext.Text = prototypePatient.Concomitant_diagnosis;
            DateOfBirthtext.Text = prototypePatient.Date_of_birth;
            MedicalInsuranceOrganizationtext.Text = prototypePatient.MHI;
            MHItext.Text = prototypePatient.MHO;
            BenefitCodetext.Text = prototypePatient.Benefit_code;
            ResidenceAddresstext.Text = prototypePatient.Residence_address;
            ResidentialAddresstext.Text = prototypePatient.Residential_address;
            Phonetext.Text = prototypePatient.Phone;
            PlaceOfWorktext.Text = prototypePatient.Place_of_work;
            Professiontext.Text = prototypePatient.Profession;
            Posttext.Text = prototypePatient.Post;
            Dependenttext.Text = prototypePatient.Dependent;
            DocumentNametext.Text = prototypePatient.Document_name;
            DocumentNumbertext.Text = prototypePatient.Document_number;
            DocumentDatetext.Text = prototypePatient.Document_date;
            DocumentIssuedtext.Text = prototypePatient.Document_issued;
            MedicationsTakentext.Text = prototypePatient.Medications_taken;
            AttendingPhysiciantext.Text = prototypePatient.Attending_physician;
            TodayDatetext.Text = DateTime.Today.ToString("dd.MM.yyyy");

        }
        private Patient prototypePatient;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            prototypePatient.Name = Nametext.Text;
            prototypePatient.Gender = Gendertext.Text;
            prototypePatient.Age = Agetext.Text;
            prototypePatient.Symptoms = PatientSymptomstext.Text;
            prototypePatient.Diagnosis = PatientDiagnosistext.Text;
            prototypePatient.Concomitant_diagnosis = ConcomitantDiagnosistext.Text;
            prototypePatient.Date_of_birth = DateOfBirthtext.Text;
            prototypePatient.MHO = MHItext.Text;
            prototypePatient.MHI = MedicalInsuranceOrganizationtext.Text;
            prototypePatient.Benefit_code = BenefitCodetext.Text;
            prototypePatient.Residence_address = ResidenceAddresstext.Text;
            prototypePatient.Residential_address = ResidentialAddresstext.Text;
            prototypePatient.Phone = Phonetext.Text;
            prototypePatient.Place_of_work = PlaceOfWorktext.Text;
            prototypePatient.Profession = Professiontext.Text;
            prototypePatient.Post = Posttext.Text;
            prototypePatient.Dependent = Dependenttext.Text;
            prototypePatient.Document_name = DocumentNametext.Text;
            prototypePatient.Document_number = DocumentNumbertext.Text;
            prototypePatient.Document_date = DocumentDatetext.Text;
            prototypePatient.Document_issued = DocumentIssuedtext.Text;
            prototypePatient.Medications_taken = MedicationsTakentext.Text;
            prototypePatient.Attending_physician = AttendingPhysiciantext.Text;

            var patienForm = this.Owner as PatientForm;

            if (prototypePatient.ID == -1)
            {
                prototypePatient.ID = DatabaseManager.Instance.InsertPatient(prototypePatient);

                if (patienForm != null)
                {
                    string[] row = new string[] { prototypePatient.ID.ToString(), prototypePatient.Name, prototypePatient.Gender, prototypePatient.Age, prototypePatient.Symptoms, prototypePatient.Diagnosis, prototypePatient.Concomitant_diagnosis, prototypePatient.Date_of_birth, prototypePatient.MHI, prototypePatient.MHO, prototypePatient.Benefit_code, prototypePatient.Residence_address, prototypePatient.Residential_address, prototypePatient.Phone, prototypePatient.Place_of_work, prototypePatient.Profession, prototypePatient.Post, prototypePatient.Dependent, prototypePatient.Document_name, prototypePatient.Document_number, prototypePatient.Document_date, prototypePatient.Document_issued, prototypePatient.Medications_taken, prototypePatient.Attending_physician, DateTime.Today.ToString("dd.MM.yyyy") };
                    patienForm.dataGridViewPatient.Rows.Add(row);

                    this.Close();
                }
            }
            else
            {
                DatabaseManager.Instance.UpdatePatient(prototypePatient);

                if (patienForm != null)
                {
                    string[] row = new string[] { prototypePatient.ID.ToString(), prototypePatient.Name, prototypePatient.Gender, prototypePatient.Age, prototypePatient.Symptoms, prototypePatient.Diagnosis, prototypePatient.Concomitant_diagnosis, prototypePatient.Date_of_birth, prototypePatient.MHI, prototypePatient.MHO, prototypePatient.Benefit_code, prototypePatient.Residence_address, prototypePatient.Residential_address, prototypePatient.Phone, prototypePatient.Place_of_work, prototypePatient.Profession, prototypePatient.Post, prototypePatient.Dependent, prototypePatient.Document_name, prototypePatient.Document_number, prototypePatient.Document_date, prototypePatient.Document_issued, prototypePatient.Medications_taken, prototypePatient.Attending_physician, DateTime.Today.ToString("dd.MM.yyyy") };

                    var i = patienForm.dataGridViewPatient.SelectedCells[0].RowIndex;
                    patienForm.dataGridViewPatient.Rows[i].SetValues(row);

                    this.Close();
                }
            }
        }
    }
}
