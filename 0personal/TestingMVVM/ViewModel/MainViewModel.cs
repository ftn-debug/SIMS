using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace TestingMVVM.ViewModel
{
    class MainViewModel
    {

        private NavigationService navService;

        public NavigationService NavService
        {
            get { return navService; }
            set
            {
                navService = value;
            }
        }

        #region Navigation
        private RelayCommand navigateToMainPageCommand;


        private RelayCommand navigateToStudentPageCommand;

        #endregion

        #region RelayCommand
        public RelayCommand NavigateToMainPageCommand
        {
            get { return navigateToMainPageCommand; }
            set
            {
                navigateToMainPageCommand = value;
            }
        }
        public RelayCommand NavigateToStudentPageCommand
        {
            get { return navigateToStudentPageCommand; }
            set
            {
                navigateToStudentPageCommand = value;
            }
        }
        #endregion


        private void Execute_NavigateToMainPageCommand(object obj)
        {
            this.NavService.Navigate(
                new Uri("Views/Pocetna.xaml", UriKind.Relative));
        }

        private bool CanExecute_NavigateCommand(object obj)
        {
            return true;
        }

        private void Execute_NavigateToStudentPageCommand(object obj)
        {
            this.NavService.Navigate(
                new Uri("Views/Students.xaml", UriKind.Relative));
        }


        #region Konstruktori
        public MainViewModel(NavigationService navService)
        {
            this.NavigateToMainPageCommand = new RelayCommand(Execute_NavigateToMainPageCommand, CanExecute_NavigateCommand);
            this.NavigateToStudentPageCommand = new RelayCommand(Execute_NavigateToStudentPageCommand, CanExecute_NavigateCommand);

        }
        #endregion




    }
}
