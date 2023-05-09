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

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("There is only one page right now you can not go back");
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.Student1Checkbox.IsChecked = this.Student2Checkbox.IsChecked = this.Student3Checkbox.IsChecked = this.Student4Checkbox.IsChecked 
                = this.Student5Checkbox.IsChecked = this.Student6Checkbox.IsChecked = this.Student7Checkbox.IsChecked =
                this.Student8Checkbox.IsChecked = this.Student9Checkbox.IsChecked= this.Student10Checkbox.IsChecked = this.Student11Checkbox.IsChecked
                =this.Student12Checkbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.Absent_List.Text += ((CheckBox)sender).Content;

            

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This sheet will be saved into our database after I have learned SQL");
        }
    }
}
