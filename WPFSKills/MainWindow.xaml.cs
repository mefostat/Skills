using System;
using System.Collections.Generic;
using System.Configuration;
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
using WPFSKills.Models;

namespace WPFSKills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MobileContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new MobileContext();


        }

        private void TestConnectdb_Click(object sender, RoutedEventArgs e)
        {
            MainСlass main = new MainСlass();

            main.Connect();
            if(main.ErrorMessage != string.Empty)
                MessageBox.Show(main.ErrorMessage + "   " + ConfigurationManager.ConnectionStrings["ConnectionDefault"].ConnectionString);
            
        }
    }
}
