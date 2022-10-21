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
    /// Interaction logic for IzaberiDoktora.xaml
    /// </summary>
    public partial class IzaberiDoktora : Window
    {
        public FileStorage storage = new FileStorage();
        ObservableCollection<Doctor> doctors = new ObservableCollection<Doctor>();
        public IzaberiDoktora()
        {
            InitializeComponent();
            doctors = storage.getAllDoctors();
            sviDoktori.ItemsSource = doctors;
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctor = (Doctor)sviDoktori.SelectedItem;
            if (doctor == null)
            {
                MessageBox.Show("Niste izabrali nijednog doktora!");
            }
            else
            {
                var s = new Window1(doctor, storage);
                s.Show();
            }
        }
    }
}
