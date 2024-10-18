using System.Runtime.InteropServices.JavaScript;

namespace PaytaxtSalati
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Step: Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
			int Secimler;
			do
			{
				Console.WriteLine("Paytaxt Salati oyununa xos gelmisiniz.Oyunumuz ");

				Console.WriteLine("0 - İnformasiya almaq üçün\n 1 - Shoot metodu üçün\n 2 - GetRemainBulletCount metodu üçün\n  3 - Reload metodu üçün\n 4 - ChangeFireMode metodu üçün\n 5 - Proqramdan dayandırmaq üçün");
				Secimler = int.Parse(Console.ReadLine());
				Weapon new_Weapon = null;
				switch (Secimler)
				{
					case 0:
						Console.WriteLine("Tutum Daxil edin");
						int gulletutumu = int.Parse(Console.ReadLine());
						Console.WriteLine("Gulle sayi Daxil edin");
						int gullesayi = int.Parse(Console.ReadLine());
						Console.WriteLine("Firemode Daxil edin. tekli ve avtomatik olaraq sec!");
						string atismode = Console.ReadLine();
						new_Weapon = new Weapon(gulletutumu, gullesayi, atismode);
						break;
					case 1:
						new_Weapon.Shoot();
						break;
					case 2:
						Console.WriteLine($"Daragin tam dolmasi ucun lazim olan gulle sayi: {new_Weapon.GetRemainBulletCount(new_Weapon.Gulletutumu,new_Weapon.Gullesayi)}");
						break;
					case 3:
					
						 new_Weapon.Reload();
						Console.WriteLine("Daragi relod edildi");
						break;
					case 4:
						new_Weapon.ChangeFireMode();
                        Console.WriteLine("Atis modu deyisdirildi");
						break;
					case 5:
                        Console.WriteLine("Game over");
						break;
					default:
						Console.WriteLine("Invalid option");
						break ;


				}

					
			}
			while (Secimler != 5);
		}
	}
}
