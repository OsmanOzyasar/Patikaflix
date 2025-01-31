using System;

namespace Patikaflix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Series> series = new List<Series>();


            Console.WriteLine("Bir dizi oluşturmak ister misiniz? (e/h)");
        start:
            string userInput = Console.ReadLine();

            while (userInput != "e" && userInput != "h")
            {
                Console.WriteLine("Geçerli bir değer giriniz.");
                userInput = Console.ReadLine();
            }

            if (userInput == "e")
            {
                Series serie = new Series();
                Console.Write("Dizi adı: ");
                serie.Name = Console.ReadLine();

            retry:
                try
                {
                    Console.Write("Dizi çıkış yılı: ");
                    serie.Year = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Geçerli bir değer giriniz");
                    goto retry;
                }

                Console.Write("Dizi türü:  ");
                serie.Type = Console.ReadLine();

                Console.Write("Dizi yönetmeni: ");
                serie.Director = Console.ReadLine();

                Console.Write("Yayınlandığı ilk platform: ");
                serie.Channel = Console.ReadLine();

                series.Add(serie);
                Console.WriteLine("Yeni bir dizi eklemek ister misiniz? (e/h)");
                string userInput2 = Console.ReadLine();

                while (userInput2 != "e" && userInput2 != "h")
                {
                    Console.WriteLine("Geçerli bir değer giriniz.");
                    userInput2 = Console.ReadLine();
                }

                if (userInput2 == "e")
                {
                    goto start;
                }
            }

            if (series.Count == 0)
            {
                Console.WriteLine("Bir dizi bulunamadı. Uygulamamızı kullandığınız için teşekkür ederiz.");
            }
            else
            {
                List<FunnySeries> funnies = series.Where(x => x.Type == "Komedi")
                    .Select(x => new FunnySeries { SeriesName = x.Name, SeriesType = x.Type, SeriesDirector = x.Director })
                    .ToList();

                foreach (var item in funnies)
                {
                    Console.WriteLine($"Dizi adı: {item.SeriesName}\nDizi Türü: {item.SeriesType}\nDizi Yönetmeni: {item.SeriesDirector}");
                }

                Console.WriteLine("uygulamamızı kullandığınız için teşekkür ederiz.");
            }
        }
    }
}