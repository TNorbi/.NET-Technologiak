using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserApp.Model;
using UserApp.ViewModel;

namespace UserApp.View
{
    /// <summary>
    /// Interaction logic for CollectionView.xaml
    /// </summary>
    public partial class CollectionView : UserControl
    {
        CollectionViewModel viewModel = new CollectionViewModel();
        private string selectedUserName;
        public string SelectedUserName
        {
            get { return selectedUserName; }
            set { selectedUserName = value; }
        }

        public CollectionView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Users.Add(new Model.User() { Name = txtUserName.Text,Age = int.Parse(txtAge.Text),Gender = txtGender.Text});
            txtUserName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtGender.Text = string.Empty;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User selectedUser = (User)listView.SelectedItem;
            MainViewModel mainViewModel = new MainViewModel();
            mainViewModel.User.Name = selectedUser.Name;
            mainViewModel.User.Age = selectedUser.Age;
            mainViewModel.User.Gender = selectedUser.Gender;
            MainWindow mainWindow = new MainWindow();
            mainWindow.mainStackPanel.DataContext = mainViewModel.User;
        }
    }
}
