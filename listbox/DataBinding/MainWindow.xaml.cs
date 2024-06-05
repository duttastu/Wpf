using DataBinding.Data;
using System.Collections.Generic;
using System.Windows;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name="abc",Age=21},
            new Person{Name="bcd",Age=20},
            new Person{Name="efg",Age=24},
            new Person{Name="ghu",Age=27},
            new Person{Name="stu",Age=22},

        };
        public MainWindow()
        {
            InitializeComponent();
            /*ListBoxNames.ItemsSource = new List<string>(){
            "HAppy",
            "saloni",
            "riya",
            "shruti"*/

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selecteditems = ListBoxPeople.SelectedItems;
            foreach (var item in selecteditems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}
