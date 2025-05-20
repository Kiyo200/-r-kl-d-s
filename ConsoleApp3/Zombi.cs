using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Zombi : Karakter
	{
		public Zombi(string nev, int elet, int ero) : base(nev, elet, ero)
		{

		}

		public override void Tamadas()
		{
            Console.WriteLine($"{Nev} hörög");
        }
	}
}
