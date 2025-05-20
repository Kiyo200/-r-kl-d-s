using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			List<Karakter> karakterek = new List<Karakter>();
			karakterek.Add(new Jatekos("Steve", 20, 5, 2));
			karakterek.Add(new Zombi("Zombi", 10, 1));
			karakterek.Add(new Farkas("Farkas", 8, true, 1));
			karakterek.Add(new Farkas("Vadon Farkas", 8, false, 1));

			foreach (var Karakter in karakterek)
			{
                Console.WriteLine($"{Karakter.Nev}, élete:{Karakter.Elet}, Támadása: {Karakter.Ero}");
				Karakter.Tamadas();
            }

			static void Harcol(List<Karakter> karakterek)
			{
                Console.WriteLine("1. Steve");
				Console.WriteLine("2. Zombi");
				Console.WriteLine("3. Farkas");
                Console.WriteLine("4. Csontváz");
                Console.WriteLine("válassz ki két karaktert akik harcolni fognak(a szát írja be) ");
				int harcos1 = Convert.ToInt32(Console.ReadLine());
				 harcos1 = harcos1 - 1;
				Console.WriteLine("most áaszd ki a másikat is");
				int harcos2 = Convert.ToInt32(Console.ReadLine());
				harcos2 = harcos2 - 1;

				if (harcos1 == harcos2)
				{
					Console.WriteLine($"{karakterek[harcos1]} nyert mert egyedül van a harctéren ");
                }
                else
                {
					if (karakterek[harcos1].Ero > karakterek[harcos2].Ero && karakterek[harcos1].Elet > karakterek[harcos2].Elet)
					{
						Console.WriteLine($"{karakterek[harcos1]} nyert");
					}
					else
					{
						Console.WriteLine($"{karakterek[harcos2]} nyert");
					}
                }

				


            }
			Harcol(karakterek);

		}
	}
}
