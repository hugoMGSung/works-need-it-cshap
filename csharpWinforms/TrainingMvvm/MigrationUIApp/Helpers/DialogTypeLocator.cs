using MvvmDialogs.DialogTypeLocators;
using System;
using System.ComponentModel;

namespace MigrationUIApp.Helpers
{
    public class DialogTypeLocator : IDialogTypeLocator
    {
        /// <summary>
        /// Locates a dialog type based on the specified view model.
        /// </summary>
        public Type Locate(INotifyPropertyChanged viewModel)
        {
            var viewModelType = viewModel.GetType();

            var dialogFullName = viewModelType.FullName;
            dialogFullName = dialogFullName.Substring(0,
                dialogFullName.Length - "Model".Length);

            return viewModelType.Assembly.GetType(dialogFullName);
        }
    }
}
