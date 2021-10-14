using System;
using System.Windows.Input;


namespace MVVM_WPF_SimpleProject.ViewModel.Commands
{
    public abstract class CommandBase : ICommand
    {

        public abstract void Execute(object parameter);
        public virtual bool CanExecute(object parameter) => true;


        public event EventHandler CanExecuteChanged;
        protected void OnCanExecuteChanged()
            => CanExecuteChanged?.Invoke(this, new EventArgs());
    }
}
