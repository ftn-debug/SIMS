/***********************************************************************
 * Module:  Pacijent.cs
 * Author:  Lenovo
 * Purpose: Definition of the Class Model.Pacijent
 ***********************************************************************/

using System;
using System.Xml.Serialization;

namespace ClassDiagram.Model
{
    [XmlInclude(typeof(Appointment))]
    [Serializable]
    public class Patient : Guest
   {

      private bool LogIn()
      {
         throw new NotImplementedException();
      }
      
      public bool EditAppointment(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public string placeOfBirth;
      public bool insurance;
      
      public MedicalRecord medicalRecord;
      public System.Collections.ArrayList appointment;

        public string PlaceOfBirth { get; set; }
        public bool Insurance { get; set; }
        public MedicalRecord MedicalRecord { get; set; }

        public System.Collections.ArrayList Appointment
      {
         get
         {
            if (appointment == null)
               appointment = new System.Collections.ArrayList();
            return appointment;
         }
         set
         {
            RemoveAllAppointment();
            if (value != null)
            {
               foreach (Appointment oAppointment in value)
                  AddAppointment(oAppointment);
            }
         }
      }
      
      
      public void AddAppointment(Appointment newAppointment)
      {
         if (newAppointment == null)
            return;
         if (this.appointment == null)
            this.appointment = new System.Collections.ArrayList();
         if (!this.appointment.Contains(newAppointment))
            this.appointment.Add(newAppointment);
      }
      
      public void RemoveAppointment(Appointment oldAppointment)
      {
         if (oldAppointment == null)
            return;
         if (this.appointment != null)
            if (this.appointment.Contains(oldAppointment))
               this.appointment.Remove(oldAppointment);
      }
      
      public void RemoveAllAppointment()
      {
         if (appointment != null)
            appointment.Clear();
      }
   
   }
}