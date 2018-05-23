using System;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postItOne = new PostIt("orange", "blue", "Idea 1");
            PostIt postItTwo = new PostIt("pink", "black", "Awesome");
            PostIt postItThree = new PostIt("yellow", "green", "Superb");

            postItOne.WriteOutFields();
            postItTwo.WriteOutFields();
            postItThree.WriteOutFields();
            Console.ReadLine();

        }
    }

    public struct PostIt
    {
        string backgroundColor;
        string textColor;
        string text;

        public PostIt(string backgroundColor, string textColor, string text)
        {
            this.backgroundColor = backgroundColor;
            this.textColor = textColor;
            this.text = text;
        }

        public void WriteOutFields()
        {
            string output = string.Format("Background color: {0}, Textcolor: {1}, Text: {2}", backgroundColor, textColor, text);
            Console.WriteLine(output);
        }
    }
}
