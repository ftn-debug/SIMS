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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window 
    {

        public FileStorage storage;
        ObservableCollection<Appointment> sviPregledi;
        ObservableCollection<Patient> patients;
        ObservableCollection<Doctor> doctors;
        Doctor prijavljeniDoktor;
        Doctor izabraniDoktor;

        Appointment noviPregled = new Appointment();
        //ako stavimo new nece raditi
        //ovo je pointer na preglede
        ObservableCollection<Appointment> doktoroviPregledi; //oni ispisani u dataGridu
        // Operation operation = new Operation();

        bool lekar = false;
        bool pacijent = false;
        bool datum = false;
        bool ordinacija = false;

        
        //msm da mi ovo ne treba
        public ObservableCollection<ClassDiagram.Model.Patient> Patients
        {
            get;
            set;
        }
     

        public Window2(FileStorage skladiste, ObservableCollection<Appointment> pregledi,Doctor doktor )
        {
            InitializeComponent();
            storage = skladiste;
             patients = storage.getAllPatients();
             doctors = storage.getAllDoctors();
            prijavljeniDoktor = doktor;
            ObservableCollection<Ordinacija> ordinations = storage.getAllOrdinations();

            doktoroviPregledi = pregledi;
            sviPregledi = storage.getAllAppointments();

            pacijenti.ItemsSource = patients;
            ordinacije.ItemsSource = ordinations;
            //sad tom selektovanom doktoru u comboboxu dodajem pregled u listu 
            doktori.ItemsSource = doctors;            
            
        }
      

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cboIthem = vremePic.SelectedItem as ComboBoxItem;
            if (cboIthem != null)
            {
                //Da li ovo treba i za combo box uraditi? Jer sta ako prvo izaberemo datum pa vreme?Da li ce dt biti dobro?
                String t = cboIthem.Content.ToString();
                String d = datePic.Text;
                if(datePic.SelectedDate !=null) { datum = true; }
                DateTime dt = DateTime.Parse(d + " " + t);
                // MessageBox.Show(dt.ToString());
                noviPregled.dateAndTime = dt;
            }

        }

        //potvrdi
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lekar == true &&  datum == true && pacijent == true && ordinacija == true)
            {
                noviPregled.appointmentID = sifraPregleda.Text;

                if(izabraniDoktor == prijavljeniDoktor)
                {
                    sviPregledi.Add(noviPregled);
                    //da bi prikaz bio dobar jer msm da se nece ponovo popuniti kolekcija sama od sebe sa novim
                    doktoroviPregledi.Add(noviPregled);

                    foreach (Doctor d in doctors)
                    {
                        if (d == izabraniDoktor)
                            d.appointmentsIDs.Add(noviPregled.appointmentID);
                    }
                    

                }
                else
                {
                    sviPregledi.Add(noviPregled);

                    foreach (Doctor d in doctors)
                    {
                        if (d == izabraniDoktor)
                            d.appointmentsIDs.Add(noviPregled.appointmentID);
                    }

                }




                // Appointments.Add(appointment);
                Close();
               
            }
            else MessageBox.Show("Niste popunili sva polja!");
        }
        //odustani
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
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
                noviPregled.patient = patient;
            }
        }

        private void doktori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            izabraniDoktor = (Doctor)combo.SelectedItem;
            if (izabraniDoktor == null)
            {
                lekar = false;
            }
            else
            {
                lekar = true;
                noviPregled.doctor = izabraniDoktor;
                //moram ovom dokrotu izabranom dodati u listu ovaj appointment

            }
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
                noviPregled.ordination = ordination;
            }
        }

        private void vremePic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}
