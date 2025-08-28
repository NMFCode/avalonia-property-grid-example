using Avalonia.Controls;
using System.Diagnostics;

namespace AvaloniaApplication1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Properties.CommandExecuted += Properties_CommandExecuted;
        }

        private void Properties_CommandExecuted(object? sender, Avalonia.PropertyGrid.Controls.RoutedCommandExecutedEventArgs e)
        {
            Debug.WriteLine($"Changed {e.Property.Name} to {e.NewValue}");
        }
    }
}