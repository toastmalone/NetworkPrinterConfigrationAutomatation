using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetworkPrinterConfigurationAutomation.Delegates
{
    public sealed class AsyncDelegateCommand<T> : ICommand
    {
        private readonly Func<T, Task> _task;
        private readonly Predicate<T> _canExecute;

        public bool IsExecuting { get; private set; }

        public AsyncDelegateCommand(Func<T, Task> task, Predicate<T> canExecute)
        {
            _task = task ?? throw new ArgumentNullException(nameof(task));
            _canExecute = canExecute;
        }

        public AsyncDelegateCommand(Func<T, Task> task) : this(task, null)
        {
            _task = task;
        }

        public Task ExecuteAsync(object parameter)
        {
            return _task((T)parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
            // TODO: Investigate better implementation of Task progress (JS 6/21/19)
            // Tasks naturally contain a method to check their progress
            // shouldn't we utilize that somehow?
            //if (IsExecuting == true) { return false; }
            // else { return _canExecute == null ? true : _canExecute((T)parameter); }
        }

        async void ICommand.Execute(object parameter)
        {
            try
            {
                IsExecuting = true;
                await this.ExecuteAsync(parameter).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // By running this we force all commmands to re-check their enabled status
                // We do this because there can be situations where after running an async command
                // we don't return to the UI thread to update
                CommandManager.InvalidateRequerySuggested();
                IsExecuting = false;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
