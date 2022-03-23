using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using lab6.Models;
using lab6.ViewModels;

namespace lab6.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
