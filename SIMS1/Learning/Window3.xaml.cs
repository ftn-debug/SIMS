using ClassDiagram.Model;
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


namespace Learning
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        FileStorage storage;
        ObservableCollection<Appointment> sviPregledi;
        ObservableCollection<Patient> patients;
        Appointment selektovaniPregled ;
        ObservableCollection<Appointment> doktoroviPregledi;
        Doctor prijavljeniDoktor;

        bool pacijent = false;
        bool datum = false;
        bool ordinacija = false;


        public Window3(FileStorage skladiste,Doctor doktor, Appointment selektovaniP,ObservableCollection<Appointment> pregledi)
        {
            InitializeComponent();
            storage = skladiste;
            patients = storage.getAllPatients();
            prijavljeniDoktor = doktor;
            selektovaniPregled = selektovaniP;
            doktoroviPregledi = pregledi;
            sviPregledi = storage.getAllAppointments();
            
            
            ObservableCollection<Ordinacija> ordinations = storage.getAllOrdinations();
          
            pacijenti.ItemsSource = patients;
            ordinacije.ItemsSource = ordinations;
            sifraPregleda.Text = selektovaniPregled.appointmentID;
            datePic.SelectedDate = selektovaniPregled.dateAndTime;
            
        }

        private void datePic_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cboIthem = vremePic.SelectedItem as ComboBoxItem;
            if (cboIthem != null)
            {
                //Da li ovo treba i za combo box uraditi? Jer sta ako prvo izaberemo datum pa vreme?Da li ce dt biti dobro?
                String t = cboIthem.Content.ToString();
                String d = datePic.Text;
                if (datePic.SelectedDate != null) { datum = true; }
                DateTime dt = DateTime.Parse(d + " " + t);
                // MessageBox.Show(dt.ToString());
                selektovaniPregled.dateAndTime = dt;
            }
        }
        //ne znam kako da obrnem
        private void vremePic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ordinacije_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            Ordinacija ordination = (Ordinacija)combo.SelectedItem;
            if (ordination == null)
            {
                ordinacija = false;
            }
            else
            {
                ordinacija = true;
                selektovaniPregled.ordination = ordination;
            }
        }

        private void pacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            Patient patient = (Patient)combo.SelectedItem;
            if (patient == null)
            {
                pacijent = false;
            }
            else
            {
                pacijent = true;
                selektovaniPregled.patient = patient;
            }
        }

        private void potvrdi_Click(object sender, RoutedEventArgs e)
        {

            for (int i =0; i <sviPregledi.Count;i++)
            {
                if(sviPregledi[i].appointmentID == selektovaniPregled.appointmentID)
                {
                    sviPregledi[i] = selektovaniPregled;
                    
                }
            }

            for (int i = 0; i < doktoroviPregledi.Count; i++)
            {
                if (doktoroviPregledi[i].appointmentID == selektovaniPregled.appointmentID)
                {
                    doktoroviPregledi[i] = selektovaniPregled;
                    
                }
            }
            Close();
        }

        private void odustani_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
