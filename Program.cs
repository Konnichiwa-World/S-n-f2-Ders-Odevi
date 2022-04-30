using System;
namespace Sınıf2
{public class Tasit
	{public String yakit;// Taşıtın yakıt tipi
		public int hiz; // Taşıtın Maximum hızı 
		public String renk; // Taşıtın rengi
		public String marka; // Taşıtın markası
		// Taşıtın bilgilerini ekrana yazdıran metot
		public void tasitInfo() {
			String tasit = "Taşıtın markası: " + marka + " rengi: " + renk + " yakıt tipi: " + yakit + " maximum hızı: " + hiz;
			System.Console.WriteLine (tasit);
		}
	}
	class MainClass
	{public static void Main (string[] args)
		{// Taşıt tipinden otomobil nesnesini oluşturuyoruz
			Tasit otomobil = new Tasit ();
			// nesnemize özellik değerlerini giriyoruz
			otomobil.hiz = 220;
			otomobil.yakit = "LPG";
			otomobil.renk = "Siyah";
			otomobil.marka = "Renault";
			// Bilgileri ekrana yazdıracak metodu çağırıyoruz
			otomobil.tasitInfo();
		}
	}
}

