using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Jatekos : Karakter
	{
		public int Tapasztalat {  get; set; }

		public Jatekos(string nev, int elet, int tapasztalat, int ero)
			:base(nev, elet, ero)
		{
			Tapasztalat = tapasztalat;
		}

		public override void Tamadas()
		{
            Console.WriteLine($"{Nev} kardal támad" + 
				$"Tapasztalata: {Tapasztalat}");
        }
	}
}
