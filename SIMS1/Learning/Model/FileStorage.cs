

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace ClassDiagram.Model
{
   public class FileStorage
   {
      private string fileName;
        private ObservableCollection<Patient> patients { get; set; }
        private ObservableCollection<Doctor> doctors;
        private ObservableCollection<Appointment> appointments { get; set; }
        private ObservableCollection<Operation> operations;
        private ObservableCollection<Ordinacija> ordinations;
        private ObservableCollection<Sala> operatingRooms;


        public FileStorage()
        {
            patients = new ObservableCollection<Patient>();
            doctors = new ObservableCollection<Doctor>();
            appointments = new ObservableCollection<Appointment>();
            operations = new ObservableCollection<Operation>();
            ordinations = new ObservableCollection<Ordinacija>();
            operatingRooms = new ObservableCollection<Sala>();

            //patients = LoadFromFilePatients("patients.xml");
            doctors = LoadFromFileDoctors("doctors1.xml");
            appointments = LoadFromFileAppointments("appointments.xml");
            operations = LoadFromFileOperations("operations.xml");
            //ordinations = LoadFromFileOrdinations("ordinations.xml");
            //operatingRooms = LoadFromFileOperationRooms("operatingRooms.xml");

            //ovo cemo zamjeniti sa ucitavanjem iz fajla
            Patient p1 = new Patient { name = "Miko", lastName = "Mikic" };
            Patient p2 = new Patient { name = "Pera", lastName = "Peric" };
            Patient p3 = new Patient { name = "Ana", lastName = "Maric" };
            patients.Add(p1);
            patients.Add(p2);
            patients.Add(p3);

            /*
            Doctor d1 = new Doctor { name = "Jelena", lastName = "Stajic", doctorID = "109" };
            Doctor d2 = new Doctor { name = "Maja", lastName = "Blagic", doctorID = "110" };
            Doctor d3 = new Doctor { name = "Jovan", lastName = "Mijatovic", doctorID = "111" };
            string s = "1a";
            string ss1 = "2a";
            string op1 = "2o";
            string op2 = "3o";
            d1.appointmentsIDs.Add(s);
            d1.appointmentsIDs.Add(ss1);
            d1.operationsIDs.Add(op1);
            d1.operationsIDs.Add(op2);
            doctors.Add(d1);
            doctors.Add(d2);
            doctors.Add(d3);
            */
            Ordinacija o1 = new Ordinacija { name = 101 };
            Ordinacija o2 = new Ordinacija { name = 102 };
            Ordinacija o3 = new Ordinacija { name = 103 };
            ordinations.Add(o1);
            ordinations.Add(o2);
            ordinations.Add(o3);


            Sala s1 = new Sala { name = 111 };
            Sala s2 = new Sala { name = 112 };
            Sala s3 = new Sala { name = 113 };
            operatingRooms.Add(s1);
            operatingRooms.Add(s2);
            operatingRooms.Add(s3);
            ////////////////
            /*
            appointments.Add(new Appointment { appointmentID = "1a", dateAndTime = Convert.ToDateTime("05 / 29 / 2015 05:50"), doctor = doctors[0], patient = patients[0] ,ordination = o1});
            appointments.Add(new Appointment { appointmentID = "2a", dateAndTime = Convert.ToDateTime("05 / 29 / 2015 05:50"), doctor = doctors[1], patient = patients[1], ordination = o1 });
            appointments.Add(new Appointment { appointmentID = "3a", dateAndTime = Convert.ToDateTime("05 / 29 / 2015 05:50"), doctor = doctors[2], patient = patients[2] , ordination = o1 });

            
            operations.Add(new Operation { operationID = "1o", dateAndTime = Convert.ToDateTime("07 / 29 / 2015 05:50"), doctor = doctors[0], patient = patients[2] ,sala = s1});
            operations.Add(new Operation { operationID = "2o", dateAndTime = Convert.ToDateTime("07 / 29 / 2015 05:50"), doctor = doctors[1], patient = patients[1], sala = s1 });
            operations.Add(new Operation { operationID = "3o", dateAndTime = Convert.ToDateTime("07 / 29 / 2015 05:50"), doctor = doctors[2], patient = patients[0], sala = s1 });
            */
            ////////////////
            
           /* 
            SaveAllAppointments("appointments.xml", appointments);
            SaveAllDoctors("doctors.xml", doctors);
            SaveAllOperations("operations.xml", operations);
            SaveAllPatients("patients.xml", patients);
            SaveAllOrdinations("ordinations.xml", ordinations);
            SaveAllOperatingRooms("operatingRooms.xml", operatingRooms);
            */
        }

        public ObservableCollection<Patient> getAllPatients()
        {
            //return LoadFromFile("patients.xml");
            return patients;
        }
      public void SavePatient( Patient newPatient)
        {
            patients.Add(newPatient);
      }
        public void SaveAllPatients(string filePath, ObservableCollection<Patient> pacijenti)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Patient>));
                xml.Serialize(stream, pacijenti);
            }
        }

        public void SaveAllDoctors(string filePath, ObservableCollection<Doctor> doktori)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Doctor>));
                xml.Serialize(stream, doktori);
            }
        }

        public void SaveAllAppointments(string filePath, ObservableCollection<Appointment> pregledi)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Appointment>));
                xml.Serialize(stream, pregledi);
            }

        }
            public void SaveAllOperations(string filePath, ObservableCollection<Operation> operacije)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    var xml = new XmlSerializer(typeof(ObservableCollection<Operation>));
                    xml.Serialize(stream, operacije);
                }
            }
        public void SaveAllOperatingRooms(string filePath, ObservableCollection<Sala> sale)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Sala>));
                xml.Serialize(stream, sale);
            }

        }
        public void SaveAllOrdinations(string filePath, ObservableCollection<Ordinacija> ordinacije)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Appointment>));
                xml.Serialize(stream, ordinacije);
            }

        }

        public ObservableCollection<Doctor> getAllDoctors()
        {
            return doctors;
        }
        public void SaveDoctor(Doctor newDoctor)
        {
            doctors.Add(newDoctor);
        }


        public ObservableCollection<Appointment> getAllAppointments()
        {
            return appointments;
        }
        public void SaveAppointment(Appointment newAppointment)
        {
            appointments.Add(newAppointment);
        }


        public ObservableCollection<Operation> getAllOperations()
        {
            return operations;
        }
        public void SaveOperation(Operation newOperation)
        {
            operations.Add(newOperation);
        }


        public ObservableCollection<Ordinacija> getAllOrdinations()
        {
            return ordinations;
        }
        public void SaveOrdination(Ordinacija newOrdination)
        {
            ordinations.Add(newOrdination);
        }

        public ObservableCollection<Sala> getAllOperatingRooms()
        {
            return operatingRooms;
        }
        public void SaveOperatingRoom(Sala newOperatingRoom)
        {
            operatingRooms.Add(newOperatingRoom);
        }

        public void AddAppointment(Appointment a)
        {
            appointments.Add(a);
        }
        public void AddOperation(Operation o)
        {
            operations.Add(o);
        }
        public ObservableCollection<Patient> LoadFromFilePatients(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Patient>));
                return (ObservableCollection<Patient>)xml.Deserialize(stream);
            }
        }
        public ObservableCollection<Doctor> LoadFromFileDoctors(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Doctor>));
                return (ObservableCollection<Doctor>)xml.Deserialize(stream);
            }
        }
        public ObservableCollection<Appointment> LoadFromFileAppointments(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Appointment>));
                return (ObservableCollection<Appointment>)xml.Deserialize(stream);
            }
        }
        public ObservableCollection<Operation> LoadFromFileOperations(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Operation>));
                return (ObservableCollection<Operation>)xml.Deserialize(stream);
            }
        }
        public ObservableCollection<Ordinacija> LoadFromFileOrdinations(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Ordinacija>));
                return (ObservableCollection<Ordinacija>)xml.Deserialize(stream);
            }
        }
        public ObservableCollection<Sala> LoadFromFileOperationRooms(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ObservableCollection<Sala>));
                return (ObservableCollection<Sala>)xml.Deserialize(stream);
            }
        }
    }
}