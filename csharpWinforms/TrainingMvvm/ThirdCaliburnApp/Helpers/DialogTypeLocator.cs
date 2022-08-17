using MvvmDialogs.DialogTypeLocators;
using System;
using System.ComponentModel;

namespace ThirdCaliburnApp.Helpers
{
    public class DialogTypeLocator : IDialogTypeLocator
    {
        /// <summary>
        /// 특정 뷰모델에다 Dalog 타입을 위치시키는 메서드
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public Type Locate(INotifyPropertyChanged viewModel)
        {
            Type viewModelType = viewModel.GetType();

            string dialogFullName = viewModelType.FullName;
            dialogFullName = dialogFullName.Substring(0, dialogFullName.Length - "Model".Length);

            return viewModelType.Assembly.GetType(dialogFullName);
        }
    }
}
