using System.Windows;
using WpfApp20.ViewModel;

namespace WpfApp20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm= new MainWindowViewModel();
            DataContext = vm;
        }
    }
}