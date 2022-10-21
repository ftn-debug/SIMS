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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public FileStorage storage;
        Operation novaOperacija = new Operation();
        ObservableCollection<Operation> sveOperacije;
        ObservableCollection<Operation> doktoreveOperacije;
        ObservableCollection<Patient> patients;
        Doctor prijavljeniDoktor;
        bool pacijent = false;
        bool datum = false;
        bool sala = false;

        public Window4(FileStorage skladiste, ObservableCollection<Operation> operacije,Doctor doktor)
        {
            InitializeComponent();
            storage = skladiste;
            patients = storage.getAllPatients();
            prijavljeniDoktor = doktor;
            ObservableCollection<Sala> operatingRooms = storage.getAllOperatingRooms();
            doktoreveOperacije = operacije;
            sveOperacije = storage.getAllOperations();
            
            pacijenti.ItemsSource = patients;
            sale.ItemsSource = operatingRooms;
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
                novaOperacija.patient = patient;
            }
        }


        private void sale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            Sala opRoom = (Sala)combo.SelectedItem;
            if (opRoom == null)
            {
                sala = false;
            }
            else
            {
                sala = true;
                novaOperacija.sala = opRoom;
            }
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
                novaOperacija.dateAndTime = dt;
            }
        }

        private void potvrdi_Click(object sender, RoutedEventArgs e)
        {
            if ( datum == true && pacijent == true && sala == true)
            {
                novaOperacija.operationID = sifraOperacije.Text;
                novaOperacija.doctor = prijavljeniDoktor;
                sveOperacije.Add(novaOperacija);

                prijavljeniDoktor.operationsIDs.Add(novaOperacija.operationID);
                doktoreveOperacije.Add(novaOperacija);
                Close();

            }
            else MessageBox.Show("Niste popunili sva polja!");
        }

        private void odustani_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void vremePic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
