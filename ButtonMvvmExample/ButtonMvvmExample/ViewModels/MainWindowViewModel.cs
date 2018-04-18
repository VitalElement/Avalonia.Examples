using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using ReactiveUI;

namespace ButtonMvvmExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ClickCommand = ReactiveCommand.Create(async () =>
            {
                var ofd = new OpenFileDialog();

                await ofd.ShowAsync();
            });
        }

        public async void OnButtonClick()
        {
            var ofd = new OpenFileDialog();

            await ofd.ShowAsync();
        }

        public ReactiveCommand ClickCommand { get; }
    }
}
