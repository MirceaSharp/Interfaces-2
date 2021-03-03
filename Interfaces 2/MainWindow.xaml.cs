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

namespace Interfaces_2
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

        private void btnMonthly_Click(object sender, RoutedEventArgs e)
        {
            BankAccount bankAccount = new BankAccount(2.3, 1000);
            MessageBox.Show(bankAccount.ToString());
        }

        private void btnSurface_Click(object sender, RoutedEventArgs e)
        {
            Shape Square = new Shape(50, 48);
            MessageBox.Show(Square.ToString());
        }
    }
}
