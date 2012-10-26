using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WTMovie.ViewModel
{

    public class SimpleCommand : ICommand
    {
        #region private fields

        private readonly Action m_Execute;
        private readonly Func<object, bool> m_CanExecute;

        #endregion

        public SimpleCommand(Action execute)
            : this(execute, null)
        {
        }

        public SimpleCommand(Action execute, Func<object, bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            m_Execute = execute;
            m_CanExecute = canExecute;
        }


        /*   public event EventHandler CanExecuteChanged
           {
               add { CommandManager.RequerySuggested += value; }
               remove { CommandManager.RequerySuggested -= value; }
           }*/

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }


        public bool CanExecute(object parameter)
        {
            return m_CanExecute == null ? true : m_CanExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            m_Execute();
        }
    }
}
