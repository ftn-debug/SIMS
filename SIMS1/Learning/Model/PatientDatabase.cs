/***********************************************************************
 * Module:  BazaPacijenata.cs
 * Author:  Lenovo
 * Purpose: Definition of the Class Model.BazaPacijenata
 ***********************************************************************/

using System;

namespace ClassDiagram.Model
{
   public class PatientDatabase
   {
      public Boolean AddPatient()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Delete()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Edit()
      {
         throw new NotImplementedException();
      }
      
      public Boolean ScheduleER()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Show()
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.ArrayList patient;
      
      public System.Collections.ArrayList Patient
      {
         get
         {
            if (patient == null)
               patient = new System.Collections.ArrayList();
            return patient;
         }
         set
         {
            RemoveAllPatient();
            if (value != null)
            {
               foreach (Patient oPatient in value)
                  AddPatient(oPatient);
            }
         }
      }
      
      
      public void AddPatient(Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new System.Collections.ArrayList();
         if (!this.patient.Contains(newPatient))
            this.patient.Add(newPatient);
      }
      
      public void RemovePatient(Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
               this.patient.Remove(oldPatient);
      }
      
      public void RemoveAllPatient()
      {
         if (patient != null)
            patient.Clear();
      }
   
   }
}