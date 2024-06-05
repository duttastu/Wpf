using System.Collections.ObjectModel;

using System.Runtime.CompilerServices;
using WpfApp20.Model;
using WpfApp20.MVVM;

namespace WpfApp20.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        public RelayCommand AddCommand => new RelayCommand(execute => AddItem()); 
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(),canExecute =>SelectedItem !=null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public int MyProperty { get; set; }
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Property1",
                SerialNumber = "0001",
                Quantity = 5
            });
            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 6
            }); 
        }
        private Item selectedItem;

        

        public Item SelectedItem
        {
            get { return selectedItem; }
            set {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Item",
                SerialNumber = "XXXX",
                Quantity = 0
            });
        }
        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }
        private void Save()
        {

        }
        private bool CanSave()
        {
            return true;
        }
       
    }
}
