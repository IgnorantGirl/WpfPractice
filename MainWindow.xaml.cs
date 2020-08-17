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
using WpfPractice.ViewModel.Login;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NameViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = base.DataContext as NameViewModel;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //update
            _viewModel.UserName = "testUpdate";
            _viewModel.CompanyName = "Advent";
        }
    }
}
