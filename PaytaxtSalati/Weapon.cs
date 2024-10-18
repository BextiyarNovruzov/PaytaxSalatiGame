using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytaxtSalati
{
	internal class Weapon
	{

		//Step: Fields yaratmaq
		private int _gulletutumu;
		private int _gullesayi;
		private string _atismodu;

		//Step: Construkto yaratmaq 
		public Weapon(int daragingulletutumu, int daragdakigullesayi, string atismodu)
		{
			_gulletutumu = daragingulletutumu;
			_gullesayi = daragdakigullesayi;
			_atismodu = atismodu;
		}

		//Step:Propertyes yaratmaq
		public int Gulletutumu
		{
			get
			{
				return _gulletutumu;
			}
			set 
			{
				if( value < 0)
				{
					Console.WriteLine("Menfi sayda gulle sayi olmaz");
				}
				else
				{
					value = _gulletutumu;

				}
			}
		}
		public int Gullesayi 
		{
			get
			{
				return _gullesayi;
			}
			set
			{
				if (value < 0)
				{
					Console.WriteLine("Menfi sayda gulle sayi olmaz");
				}
				else
				{
					value = _gullesayi;

				}
			}
		}
		public string Atismodu { get; set; }

		//Step: Shoot methodu yaratmaq
		public void Shoot()
		{
			if (Gullesayi <= 0)
			{
				Console.WriteLine("Daraq bosdur.");
				return;
			}

			if (Atismodu== "tekli")
			{
				TekliShot();
			}
			else if (Atismodu == "avtomatik")
			{
				AutomatikShot();
			}
		}
		//tekli atis
		private void TekliShot()
		{
			if (Gullesayi > 0)
			{
				Gullesayi--;
				Console.WriteLine("Bir gulle atıldı. Qalan gulle sayı: " + Gullesayi);
			}
			else
			{
				Console.WriteLine("Daraq bosdur.");
			}
		}

		// Avtomatik atıs
		private void AutomatikShot()
		{
			Gullesayi = 0;
		}

		//Step: GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
		public int GetRemainBulletCount(int Gulletutumu, int Gullesayi)
		{
			int lazimolan = Gulletutumu - Gullesayi;
			return lazimolan;
		}


		//Step: Reload() - darağı yenidən doldurur.

		public int Reload()
		{
			Gulletutumu = Gullesayi;
			return Gulletutumu;
		}

		//Step: ChangeFireMode() - Atış modunu dəyişir.
		public string ChangeFireMode()
		{
			if (Atismodu == "tekli")
			{
				Atismodu = "avtomatik";
				return Atismodu;
			}
			else
			{
                Console.WriteLine("atis modenu duzgun secin ya tekli yada  avtomatik sece billersiz.");
			}
			return Atismodu;
		}


	}
}
