using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Automat
    {

        public void Run()
        {
            Program();        }

        public void Program()
        {
            StreamReader sr = new StreamReader("input.txt");
            var text = sr.ReadToEnd().Split("\r\n");
            var list = new List<OOP>();
            var Countlist = new List<OOP>();

            foreach (var data in text)
            {
               var splitted = data.Split(";");

                list.Add(new OOP { Id = Convert.ToInt32(splitted[0]), Number = (splitted[1]), Name = splitted[2], Price = Convert.ToInt32(splitted[3]), mnozstvi = Convert.ToInt32(splitted[4]), status = false });
            }


            foreach (var finalText in list)
            {
                var checkMnoztvi = list.FirstOrDefault(a => a.mnozstvi > 4);
                using var sw = new StreamWriter("./output.txt");
                if (finalText.mnozstvi > 4 )
                {
                    Countlist.Add(finalText);
                    Console.WriteLine($"Cas {DateTime.Now} a celkem polozek {Countlist.Count} kteri maji vetsi nez ctyri");
    
                    sw.Write($"Cas {DateTime.Now} a celkem polozek {Countlist.Count} kteri maji vetsi nez ctyri");
                }


            }

        }

    }
}
