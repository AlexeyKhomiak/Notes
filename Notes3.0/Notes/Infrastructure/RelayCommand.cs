using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notes.Infrastructure
{
    class RelayCommand : ICommand
    {
        readonly Action<object> _act;
        readonly Predicate<object> _pred;
        public RelayCommand(Action<object> act, Predicate<object> pred = null)
        {
            _act = act;
            _pred = pred;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _pred == null ? true : _pred(parameter);
        }

        public void Execute(object parameter)
        {
            _act(parameter);
        }
    }
}
