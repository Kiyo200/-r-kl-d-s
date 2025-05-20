using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Csontvaz :  Karakter
	{
		public Csontvaz(string nev, int elet, int ero) : base(nev, elet, ero)
		{
			
		}
		public override void Tamadas()
		{
            Console.WriteLine($"{Nev} egy íjjal támadott");
        }
	}
}
