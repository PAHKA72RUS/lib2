using System;
using System.Collections.Generic;

namespace zadanie2
{
    class Program
    {
        static void Zadnie1(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'f') count++;

                if (count == 2 && str[i] == 'f')
                {
                    int index = str.IndexOf(str[i + 1]);
                    Console.WriteLine(index - 1);
                    break;
                }
            }
            if (count == 1) Console.WriteLine(1);
            if (count == 0) Console.WriteLine(2);
        }

        static void Zadanie2(string str)
        {
            Dictionary<string, string> dichar = new Dictionary<string, string>()
            {
                {"а","a"},
                {"б","b"},
                {"в","v"},
                {"г","g"},
                {"д","d"},
                {"е","e"},
                {"ё","yo"},
                {"ж","zh"},
                {"з","z"},
                {"и","i"},
                {"й","y"},
                {"к","k"},
                {"л","l"},
                {"м","m"},
                {"н","n"},
                {"о","o"},
                {"п","p"},
                {"р","r"},
                {"с","s"},
                {"т","t"},
                {"у","u"},
                {"ф","f"},
                {"х","h"},
                {"ц","ts"},
                {"ч","ch"},
                {"ш","sh"},
                {"щ","sch"},
                {"ъ","'"},
                {"ы","i"},
                {"ь",""},
                {"э","e"},
                {"ю","yu"},
                {"я","ya"}
            };

            string resultat = "";

            foreach (var ch in str)
            {
                string qq = "";

                if (dichar.TryGetValue(ch.ToString(), out qq))
                {
                    resultat += qq;
                }
                else resultat += ch;
            }
            Console.WriteLine(resultat);
        }

        static void Zadanie3(string str)
        {
            string caps = "";

            for (int i = 0; i < str.Length; i++)
            {
                int index = str.IndexOf(str[i]);

                if (str[i] == 'h' && i != 0 && i != str.Length - 1) caps += 'H';
                else caps += str[i];
            }

            Console.WriteLine(caps);
        }

        static void Main(string[] args)
        {
            //1
            Zadnie1("ousbcxnbdsf");

            //2
            Zadanie2("дела идут пока отлично, поскольку к ним не приступал");

            //3
            Zadanie3("holocenholopoh");
        }
    }
}