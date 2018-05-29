using System;

namespace TheGardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            Tree purpleTree = new Tree("purple");
            Tree orangeTree = new Tree("orange");
            Flower yellowFlower = new Flower("yellow");
            Flower blueFlower = new Flower("blue");

            myGarden.AddPlants(purpleTree, orangeTree, yellowFlower, blueFlower);

            Console.WriteLine(myGarden.StateOfTheGarden());
            Console.WriteLine();

            myGarden.Watering(40);
            Console.WriteLine(myGarden.StateOfTheGarden());
            Console.WriteLine();

            myGarden.Watering(70);
            Console.WriteLine(myGarden.StateOfTheGarden());
            Console.ReadLine();
        }
    }
}
