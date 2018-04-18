using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace ButtonExample
{
    public class MainWindow : Window
    {
        private Button _button1;

        public MainWindow()
        {
            InitializeComponent();

            _button1 = this.FindControl<Button>("Button1");

            _button1.Click += async (sender, e) =>
            {
                var ofd = new OpenFileDialog();

                var result = await ofd.ShowAsync(this);
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}