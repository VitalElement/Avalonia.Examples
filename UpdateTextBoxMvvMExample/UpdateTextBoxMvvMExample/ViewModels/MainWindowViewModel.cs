using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace UpdateTextBoxMvvMExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _textBoxText = "Type in the box";

        public string TextBoxText
        {
            get { return _textBoxText; }
            set { this.RaiseAndSetIfChanged(ref _textBoxText, value); }
        }
    }
}
