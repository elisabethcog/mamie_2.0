using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mamie_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dictionaire Dico=new dictionaire("Mots_Français.txt");
            Console.WriteLine(Dico.toString());
        }
    }
}
