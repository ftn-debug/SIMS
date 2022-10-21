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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        FileStorage storage;
        ObservableCollection<Operation> sveOperacije;
        ObservableCollection<Patient> patients;
        Operation selektovanaOperacija;
        ObservableCollection<Operation> doktoroveOperacije;
        Doctor prijavljeniDoktor;

        bool pacijent = false;
        bool datum = false;
        bool sala = false;

        public Window5(FileStorage skladiste, Doctor doktor, Operation selektovanaO,ObservableCollection<Operation> operacije)
        {
            InitializeComponent();
            storage = skladiste;
            patients = storage.getAllPatients();
            prijavljeniDoktor = doktor;
            selektovanaOperacija = selektovanaO;
            doktoroveOperacije = operacije;
            sveOperacije = storage.getAllOperations();

            ObservableCollection<Sala> operatingRooms = storage.getAllOperatingRooms();

            pacijenti.ItemsSource = patients;
            sale.ItemsSource = operatingRooms;
            sifraOperacije.Text = selektovanaOperacija.operationID;
            datePic.SelectedDate = selektovanaOperacija.dateAndTime;

        }

        private void vremePic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
                selektovanaOperacija.dateAndTime = dt;
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
                selektovanaOperacija.patient = patient;
            }
        }
 
        private void sale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            Sala operatingRoom = (Sala)combo.SelectedItem;
            if (operatingRoom == null)
            {
                sala = false;
            }
            else
            {
                sala = true;
                selektovanaOperacija.sala = operatingRoom;
            }
        }

        private void potvrdi_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < sveOperacije.Count; i++)
            {
                if (sveOperacije[i].operationID == selektovanaOperacija.operationID)
                {
                    sveOperacije[i] = selektovanaOperacija;
                   

                }
            }

            for (int i = 0; i < doktoroveOperacije.Count; i++)
            {
                if (doktoroveOperacije[i].operationID == selektovanaOperacija.operationID)
                {
                    doktoroveOperacije[i] = selektovanaOperacija;
                    
                }
            }
            Close();

        }
    }
}
