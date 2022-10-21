using System;
using System.Windows.Input;

namespace TestingMVVM.ViewModel
{
    internal class RelayCommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute) : this(execute, null) { }
        public RelayCommand(Action<object> execute_NavigateToMainPageCommand, Func<object, bool> canExecute_NavigateCommand)
        {
            this._execute = execute_NavigateToMainPageCommand;
            this._canExecute = canExecute_NavigateCommand;
        }




        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}