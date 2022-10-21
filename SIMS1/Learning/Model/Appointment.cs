
using System;
using System.Xml.Serialization;



namespace ClassDiagram.Model

{
    

    [Serializable]
    public class Appointment
   {
        public DateTime dateAndTime { get; set; }
        public String appointmentID { get; set; }

        public Ordinacija ordination { get; set; }

        public string docID { get; set; }
        public string patID { get; set; }

        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        /*
        public Doctor Doctor
        {
           get
           {
              return doctor;
           }
           set
           {
              if (this.doctor == null || !this.doctor.Equals(value))
              {
                 if (this.doctor != null)
                 {
                    Doctor oldDoctor = this.doctor;
                    this.doctor = null;
                    oldDoctor.RemoveAppointments(this);
                 }
                 if (value != null)
                 {
                    this.doctor = value;
                    this.doctor.AddAppointments(this);
                 }
              }
           }
        }
     */
    }
}