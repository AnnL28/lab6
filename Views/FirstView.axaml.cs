using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using lab6.ViewModels;

namespace lab6.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
