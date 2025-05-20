using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Farkas : Karakter
	{
		public bool Szeleditett {  get; set; }

		public Farkas(string nev, int elet, bool szeleditett, int ero) :base(nev, elet, ero)
		{
			Szeleditett = szeleditett;
		}

		public override void Tamadas()
		{
			if (Szeleditett)
			{
                Console.WriteLine($"{Nev} segít a játékosnak");
            }
			else
			{
                Console.WriteLine($"{Nev} harap");
            }
		}
	}
}
