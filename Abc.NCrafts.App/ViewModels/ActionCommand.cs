using System;
using System.Windows.Input;

namespace Abc.NCrafts.App.ViewModels
{
    public class ActionCommand : ICommand
    {
        private readonly Action _onClick;

        public ActionCommand(Action onClick)
        {
            _onClick = onClick;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _onClick();
        }

        public event EventHandler CanExecuteChanged = delegate {};
    }
}