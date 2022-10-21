
using System;
using System.Collections.Generic;

namespace ClassDiagram.Model
{
    [Serializable]
    public class Doctor
   {
      private string phoneNumber { get; set; }

       
        public List<Appointment> ShowAllAppointments()
      {
         throw new NotImplementedException();
      }
      
      public List<Operation> ShowAllOperations()
      {
         throw new NotImplementedException();
      }
      
      public Appointment MakeAppointment()
      {
         throw new NotImplementedException();
      }
      
      public void CancelAppointment()
      {
         throw new NotImplementedException();
      }
      
      public void EditAppointment()
      {
         throw new NotImplementedException();
      }
      
      public List<Operation> ScheduleOperation()
      {
         throw new NotImplementedException();
      }
      
      public void CancelOperation()
      {
         throw new NotImplementedException();
      }
      
      public void EditOperation()
      {
         throw new NotImplementedException();
      }
      
      public string name { get; set; }

        public string lastName { get; set; }

        public string doctorID { get; set; }
        public Specialization specialization { get; set; }

        public List<string> appointmentsIDs = new List<string>();
        public List<string> operationsIDs = new List<string>();


        public System.Collections.ArrayList appointments;
      
      public System.Collections.ArrayList Appointments
      {
         get
         {
            if (appointments == null)
               appointments = new System.Collections.ArrayList();
            return appointments;
         }
         set
         {
            RemoveAllAppointments();
            if (value != null)
            {
               foreach (Appointment oAppointment in value)
                  AddAppointments(oAppointment);
            }
         }
      }
      
      
      public void AddAppointments(Appointment newAppointment)
      {
         if (newAppointment == null)
            return;
         if (this.appointments == null)
            this.appointments = new System.Collections.ArrayList();
         if (!this.appointments.Contains(newAppointment))
         {
            this.appointments.Add(newAppointment);
            newAppointment.doctor = this;
         }
      }
      
      public void RemoveAppointments(Appointment oldAppointment)
      {
         if (oldAppointment == null)
            return;
         if (this.appointments != null)
            if (this.appointments.Contains(oldAppointment))
            {
               this.appointments.Remove(oldAppointment);
               oldAppointment.doctor = null;
            }
      }
      
      public void RemoveAllAppointments()
      {
         if (appointments != null)
         {
            System.Collections.ArrayList tmpAppointments = new System.Collections.ArrayList();
            foreach (Appointment oldAppointment in appointments)
               tmpAppointments.Add(oldAppointment);
            appointments.Clear();
            foreach (Appointment oldAppointment in tmpAppointments)
               oldAppointment.doctor = null;
            tmpAppointments.Clear();
         }
      }
      public System.Collections.ArrayList operations;
      
      public System.Collections.ArrayList Operations
      {
         get
         {
            if (operations == null)
               operations = new System.Collections.ArrayList();
            return operations;
         }
         set
         {
            RemoveAllOperations();
            if (value != null)
            {
               foreach (Operation oOperation in value)
                  AddOperations(oOperation);
            }
         }
      }
      
      
      public void AddOperations(Operation newOperation)
      {
         if (newOperation == null)
            return;
         if (this.operations == null)
            this.operations = new System.Collections.ArrayList();
         if (!this.operations.Contains(newOperation))
         {
            this.operations.Add(newOperation);
            newOperation.doctor = this;
         }
      }
      
      public void RemoveOperations(Operation oldOperation)
      {
         if (oldOperation == null)
            return;
         if (this.operations != null)
            if (this.operations.Contains(oldOperation))
            {
               this.operations.Remove(oldOperation);
               oldOperation.doctor = null;
            }
      }
      
      public void RemoveAllOperations()
      {
         if (operations != null)
         {
            System.Collections.ArrayList tmpOperations = new System.Collections.ArrayList();
            foreach (Operation oldOperation in operations)
               tmpOperations.Add(oldOperation);
            operations.Clear();
            foreach (Operation oldOperation in tmpOperations)
               oldOperation.doctor = null;
            tmpOperations.Clear();
         }
      }
   
   }
}