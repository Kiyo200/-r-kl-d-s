using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Karakter
	{
		public string Nev { get; set; }
		public int Elet { get; set; }

		public int Ero { get; set; }

		public Karakter(string nev, int elet, int ero)
		{
			Nev = nev;
			Elet = elet;
			Ero = ero;
		}
		public virtual void Tamadas()
		{
            Console.WriteLine($"{Nev} tamad!");
        }

	}
}
