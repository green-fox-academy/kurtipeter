using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayHelloToAllTheWorld.Models
{
    public class Greeting
    {
        private static int autoID = 1;
        private static string[] colors = new string[] { "aqua", "red", "blue", "green" };
        private static string[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};

        public int Id { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Greet { get; set; }

        public Greeting()
        {
            Id = autoID;
            autoID++;
            Color = PickStringFromList(0, colors.Length-1, colors);
            Size = PickIntFromList(14, 60) + "px";
            Greet = PickStringFromList(0, hellos.Length - 1, hellos);
        }

        private string PickStringFromList(int start, int end, string[] input)
        {
            string output = string.Empty;
            Random rnd = new Random();
            output = input[rnd.Next(start, end)];
            return output;
        }

        private int PickIntFromList(int start, int end)
        {
            int output = 0;
            Random rnd = new Random();
            output = rnd.Next(start, end);
            return output;
        }
    }
}
