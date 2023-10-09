using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class Patient
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string MHI { get; set; }

        public string MHO { get; set; }

        public string Benefit_code { get; set; }

        public string Date_of_birth { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public string Residence_address { get; set; }

        public string Residential_address { get; set; }

        public string Phone { get; set; }

        public string Place_of_work { get; set; }

        public string Profession { get; set; }

        public string Post { get; set; }

        public string Dependent { get; set; }

        public string Document_name { get; set; }

        public string Document_number { get; set; }

        public string Document_date { get; set; }

        public string Document_issued { get; set; }

        public string Diagnosis { get; set; }

        public string Concomitant_diagnosis { get; set; }

        public string Symptoms { get; set; }

        public string Medications_taken { get; set; }

        public string Attending_physician { get; set; }

        public string Today_day { get; set; }

        public Patient(string name)
        {
            ID = -1;
            Name = name;
            MHI = MHO = Benefit_code = Date_of_birth =  Age = Gender = Residence_address = Residential_address = Phone = Place_of_work = Profession = Post = Dependent = Document_name = Document_number = Document_date = Document_issued = Diagnosis = Concomitant_diagnosis = Symptoms = Medications_taken = Attending_physician = Today_day = String.Empty;
        }

        public Patient()
        {
            ID = -1;
            Name = MHI = MHO = Benefit_code = Date_of_birth = Age = Gender = Residence_address = Residential_address = Phone = Place_of_work = Profession = Post = Dependent = Document_name = Document_number = Document_date = Document_issued = Diagnosis = Concomitant_diagnosis = Symptoms = Medications_taken = Attending_physician = Today_day = String.Empty;
        }
    }
}