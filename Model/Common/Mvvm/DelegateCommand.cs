using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Model.Common.Mvvm
{
    public class DelegateCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public event EventHandler CanExecuteChanged;


        public DelegateCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if(execute == null)
            {
                throw new ArgumentNullException();
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return (_canExecute == null || _canExecute(parameter));
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
