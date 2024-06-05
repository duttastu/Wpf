using DataBinding.Data;
using System.Windows;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person
        {
            Name = "Happy",
            Age = 29
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string data = person.Name + " is " + person.Age;
            MessageBox.Show(data);
        }
    }
}
