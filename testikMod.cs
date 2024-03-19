using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testiki_wpf
{
    public class testikMod
    {
        public string title { get; set; }
        public string desc { get; set; }
        public string answ1 { get; set; }
        public string answ2 { get; set; }
        public string answ3 { get; set; }
        public truEnum correct_answ { get; set; }


        public testikMod(string Title, string Desc, string Answ1, string Answ2, string Answ3, truEnum Correct_answ)
        {
            title = Title;
            desc = Desc;
            answ1 = Answ1;
            answ2 = Answ2;
            answ3 = Answ3;
            correct_answ = Correct_answ;

        }
      
    }
}
