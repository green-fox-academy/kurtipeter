using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>();
            foxes.Add(new Fox { Name = "Joci", Color = "green", Type = "palsdfdsf" });
            foxes.Add(new Fox { Name = "Miyu", Color = "yellow", Type = "pdfdf" });
            foxes.Add(new Fox { Name = "Lulu", Color = "blue", Type = "vulpies" });
            foxes.Add(new Fox { Name = "Popo", Color = "green", Type = "pallida" });
            foxes.Add(new Fox { Name = "Kiki", Color = "green", Type = "pallida" });

            var greenFox = from fox in foxes
                           where fox.Color == "green"
                           select fox;

            var greenPallidaFox = from fox in foxes
                           where fox.Color == "green" && fox.Type == "pallida"
                           select fox;

            foreach (var item in greenFox)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            foreach (var item in greenPallidaFox)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }

    class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
    }
}
