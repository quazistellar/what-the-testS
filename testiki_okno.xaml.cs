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
using System.Windows.Shapes;

namespace testiki_wpf
{
    /// <summary>
    /// Логика взаимодействия для testiki_okno.xaml
    /// </summary>
    public partial class testiki_okno : Window
    {
  
        public testiki_okno(string rez)
        {
            InitializeComponent();

            if (rez == "nebula")
            {
                creatorTest.IsEnabled = true;
            }
            else
            {
                creatorTest.IsEnabled = false;
            }
     
        }

        private void exit_2_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();

        }

        private void proiti_test_Click(object sender, RoutedEventArgs e)
        {
           List<testikMod> tests = serdeser.Deserialize<List<testikMod>>();

            if (tests == null) { 
            
            pages.Content = new no_test();

            } 
            else
            {
                pages.Content = new prohod_testa();
            }
        }

        private void creatorTest_Click(object sender, RoutedEventArgs e)
        {
            pages.Content = new testEditorPage();
        }
    }
}
