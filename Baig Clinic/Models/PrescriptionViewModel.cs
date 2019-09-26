using System.Collections.Generic;

namespace Baig_Clinic.Models
{
    public class PrescriptionViewModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string BloodPressure { get; set; }
        public string Temperature { get; set; }
        public string Diagnose { get; set; }
        public string Address { get; set; }
        public string Comments { get; set; }
        public PrescriptionDetailModel prescriptions { get; set; }
        public PrescriptionViewModel()
        {
            prescriptions = new PrescriptionDetailModel();
        }
    }

    public class PrescriptionDetailModel
    {
        public List<PrescriptionModel> prescriptionDetailList { get; set; }

        public PrescriptionDetailModel()
        {
            prescriptionDetailList = new List<PrescriptionModel>();
        }
    }
    public class PrescriptionModel
    {
        public int SerialNumber { get; set; }
        public int MorningDose { get; set; }
        public int EveningDose { get; set; }
        public int NightDose { get; set; }
        public int NoOfDays { get; set; }
        public string MedicineName { get; set; }
        public string Strength { get; set; }
        public bool OnceAWeek { get; set; }
        public bool OnceInTwoWeek { get; set; }
        public bool OnceAMonth { get; set; }
        public PrescriptionModel()
        {
            MorningDose = 0;
            EveningDose = 0;
            NightDose = 0;
            NoOfDays = 0;
            MedicineName = "";
            Strength = "";
            OnceAMonth = false;
            OnceAWeek = false;
            OnceInTwoWeek = false;
        }
    }
}