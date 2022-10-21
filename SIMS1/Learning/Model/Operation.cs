using System;
using System.Xml.Serialization;

namespace ClassDiagram.Model
{
    
    [Serializable]

    public class Operation
   {
      public DateTime dateAndTime { get; set; }
        public String operationID { get; set; }

        public Sala sala { get; set; }

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
                     oldDoctor.RemoveOperations(this);
                  }
                  if (value != null)
                  {
                     this.doctor = value;
                     this.doctor.AddOperations(this);
                  }
               }
            }
         }
        */




    }
}