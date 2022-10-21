using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClassDiagram.Model;

namespace Learning
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    public partial class Window1 : Window
    {
       public FileStorage storage;
        ObservableCollection<Appointment> appointments ;
        ObservableCollection<Operation> operations;
        ObservableCollection<Patient> patients ;
        ObservableCollection<Doctor> doctors ;
        Doctor doctor;

        ObservableCollection<Appointment> pregledi = new ObservableCollection<Appointment>();
        ObservableCollection<Operation> operacije = new ObservableCollection<Operation>();

        public Window1(Doctor doktor, FileStorage stor)
        {
            
            InitializeComponent();
            //this.DataContext = pregledi;
            storage = stor;
            patients = storage.getAllPatients();
            doctors = storage.getAllDoctors();
            appointments = storage.getAllAppointments();
            operations = storage.getAllOperations();
            doctor = doktor;



            //pregledi i peracije izabranog doktora: pregledi,operacije
            /*
            foreach(Appointment a in appointments)
            {
                foreach(string s in doktor.appointmentsIDs)
                if(a.appointmentID == s)
                    {
                        pregledi.Add(a);
                    }
            }

            foreach (Operation o in operations)
            {
                foreach (string s in doktor.operationsIDs)
                    if (o.operationID == s)
                    {
                        operacije.Add(o);
                    }
            }
            */
            prikazUpdate();
            
            preglediPrikaz.ItemsSource = pregledi;
            operacijePrikaz.ItemsSource = operacije;
        }

        public void prikazUpdate()
        {
            foreach (Appointment a in appointments)
            {
                foreach (string s in doctor.appointmentsIDs)
                    if (a.appointmentID == s)
                    {
                        pregledi.Add(a);
                    }
            }

            foreach (Operation o in operations)
            {
                foreach (string s in doctor.operationsIDs)
                    if (o.operationID == s)
                    {
                        operacije.Add(o);
                    }
            }
        }

       
        //dodaj
        private void dodajP_Click_1(object sender, RoutedEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                var s = new Window2(storage,pregledi,doctor);
                s.Show();
                preglediPrikaz.Items.Refresh();
            }
            else
            {
                var s = new Window4(storage,operacije,doctor);
                s.Show();
                operacijePrikaz.Items.Refresh();
            }
        }

        //otkazi
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (tab.SelectedIndex == 0)
            {
                Appointment selectedA = (Appointment)preglediPrikaz.SelectedItems[0];
          
                if (selectedA == null)
                {
                    MessageBox.Show("Niste izabrali nijedan pregled!");
                }
                else
                {
                    foreach (Appointment a in appointments.ToArray())
                    {
                        if (a.appointmentID == selectedA.appointmentID)
                        {
                            pregledi.Remove(selectedA);
                            doctor.appointmentsIDs.Remove(selectedA.appointmentID);
                            //da li ovo moze ovako ili i za preglede moram prolaziti kroz sve 
                            appointments.Remove(a);
                            MessageBox.Show("Pregled je uspešno otkazan2!");
                            prikazUpdate();
                            preglediPrikaz.Items.Refresh();
                        }
                    }  
                }
                preglediPrikaz.Items.Refresh();
            }
            else
            {
                Operation selectedO = (Operation)operacijePrikaz.SelectedItems[0];

                if (selectedO == null)
                {
                    MessageBox.Show("Niste izabrali nijedanu operaciju!");
                }
                else
                {
                    foreach (Operation a in operations.ToArray())
                    {
                        if (a.operationID == selectedO.operationID)
                        {
                            operacije.Remove(selectedO);
                            doctor.operationsIDs.Remove(selectedO.operationID);
                            operations.Remove(a);
                            MessageBox.Show("Operacija je uspešno otkazana!");
                            prikazUpdate();
                            operacijePrikaz.Items.Refresh();
                        }
                    }
                }

                operacijePrikaz.Items.Refresh();
            }

        }


        public void RefreshData()
        {
            preglediPrikaz.Items.Refresh();
            operacijePrikaz.Items.Refresh();
        }
        //izmeni
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                Appointment selectedA = (Appointment)preglediPrikaz.SelectedItems[0];
                var s = new Window3(storage,doctor, selectedA,pregledi);
                s.Show();
                preglediPrikaz.Items.Refresh();
            }
            else
            {
                Operation selectedOperation = (Operation)operacijePrikaz.SelectedItems[0];
                var s = new Window5(storage,doctor,selectedOperation,operacije);
                s.Show();
                operacijePrikaz.Items.Refresh();
            }
            
        }

       

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            storage.SaveAllAppointments("appointments.xml", appointments);
            storage.SaveAllOperations("operations.xml", operations);
            storage.SaveAllDoctors("doctors1.xml", doctors);
        }
    }
}
