using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace testiki_wpf
{
    /// <summary>
    /// Логика взаимодействия для prohod_testa.xaml
    /// </summary>
    public partial class prohod_testa : Page

    {
        private int num_of_que = 0;
        private int right_answers = 0;

        public List<testikMod> tests = serdeser.Deserialize<List<testikMod>>();
        public List<string> variable_positive = new List<string>();
        public List<string> variable_not = new List<string>();

        public prohod_testa()
        {
            InitializeComponent();

            variable_positive.Add("всё верно!");
            variable_positive.Add("правильно!");
            variable_positive.Add("ответ правильный!");
            variable_positive.Add("верно, молодец!");
            variable_positive.Add("балдееееж, это верно!");
            variable_positive.Add("дикий кайф, ответ правильный!");
            variable_positive.Add("имба, верно!");

            variable_not.Add("неверно!");
            variable_not.Add("неправильно ((");
            variable_not.Add("неправда((");
            variable_not.Add("треш, неправильно(");
            variable_not.Add("не повезло-не повезло, неправильно");
            variable_not.Add("ответ неверный!");
            variable_not.Add("не чувствуешь, ответ не такой");

            _1answ.IsEnabled = true;
            _2answ.IsEnabled = true;
            _3answ.IsEnabled = true ;
            display_voprosiki();
        }

        private void _1answ_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(truEnum.answ1);

        }

        private void display_voprosiki()
        {
          
            if (num_of_que < tests.Count)
            {
                _title.Text = tests[num_of_que].title;
                _desc.Text = tests[num_of_que].desc;
                _1answ.Content = tests[num_of_que].answ1;
                _2answ.Content = tests[num_of_que].answ2;
                _3answ.Content = tests[num_of_que].answ3;
            }
        }
       
        private void CheckAnswer(truEnum selectedAnswer)
        {
           
            if (selectedAnswer == tests[num_of_que].correct_answ)
            {
                Random rd = new Random();
                int r1 = rd.Next(0, variable_positive.Count);
                string msg = variable_positive[r1];
                _message.Text = msg;
                right_answers++;
            }
            else
            {
                Random rand = new Random();
                int r2 = rand.Next(0, variable_not.Count);
                string msg = variable_not[r2];
                _message.Text = msg;
            }

            num_of_que++;

            if (num_of_que < tests.Count)
            {
                display_voprosiki();
            }
            else
            {
                _message.Text = "";
                Thread.Sleep(100);
                _1answ.IsEnabled = false;
                _2answ.IsEnabled = false;
                _3answ.IsEnabled = false;
                _message.Text = $"тест пройден, ваши правильные ответы: {right_answers} из {tests.Count} !!!";
            }
        }

        private void _2answ_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(truEnum.answ2);
        }

        private void _3answ_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(truEnum.answ3);
        }
    }
}
