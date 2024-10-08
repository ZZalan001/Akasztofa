using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akasztofa.Controllers
{
    public class SzoController
    {
        public List<string> SzoListFromFile()
        {
            List<string> list = new List<string>();
            try
            {
                string[] sorok = File.ReadAllLines("szavak.txt");
                list = new List<string>(sorok);
            }
            catch (Exception ex)
            {
                list = new List<string>();
                list.Add(ex.Message);
            }
            return list;
        }
    }
}
