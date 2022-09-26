using System.Windows;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saludarButton(object sender, RoutedEventArgs e)
        {
            nombreTextBlock.Text = "Hola " + nombreTextBox.Text;
        }
    }
}
