using System;
using System.Windows.Input;

namespace Abc.NCrafts.App
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecuteEvaluator;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecuteEvaluator = null)
        {
            _execute = execute;
            _canExecuteEvaluator = canExecuteEvaluator;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object parameter)
        {
            if (_canExecuteEvaluator == null)
            {
                return true;
            }
            var result = _canExecuteEvaluator.Invoke(parameter);
            return result;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}