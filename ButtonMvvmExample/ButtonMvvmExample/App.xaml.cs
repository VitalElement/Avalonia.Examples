using Avalonia;
using Avalonia.Markup.Xaml;

namespace ButtonMvvmExample
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}