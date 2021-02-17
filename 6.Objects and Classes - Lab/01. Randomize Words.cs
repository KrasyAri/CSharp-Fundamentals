using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            SrtingRandomizer randomizer = new SrtingRandomizer();
            randomizer.Words = Console.ReadLine().Split();
            randomizer.Randomize();
            randomizer.PrintWords();

        }


       
    }

    public class SrtingRandomizer
    {
        public string[] Words;

        public void Randomize()
        {

            Random rand = new Random();
            for (int i = 0; i < Words.Length; i++)
            {
                int randomPosition = rand.Next(0, this.Words.Length);
                string temp = this.Words[i];
                this.Words[i] = this.Words[randomPosition];
                this.Words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(String.Join(Environment.NewLine,this.Words));
        } 
    }
}
