using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using static System.Net.Mime.MediaTypeNames;

namespace testiki_wpf
{
    /// <summary>
    /// Логика взаимодействия для testEditorPage.xaml
    /// </summary>
    public partial class testEditorPage : Page
    {

        public List<testikMod> testiks = serdeser.Deserialize<List<testikMod>>() ?? new List<testikMod>();
        public testEditorPage()

        {
            InitializeComponent();
            tablichka.ItemsSource = testiks;
            
        }

        private void add_que_Click(object sender, RoutedEventArgs e)
        {
            testiks.Add(new testikMod("название", "описание", "ответ1", "ответ2", "ответ3", truEnum.answ1));
            serdeser.Serialize(testiks.Count+1);
            tablichka.ItemsSource = null;
            tablichka.ItemsSource = testiks;

        }

        private void tablichka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            serdeser.Serialize(testiks);

        }
    }
}
