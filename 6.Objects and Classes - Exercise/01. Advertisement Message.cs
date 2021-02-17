using System;

namespace _26._06_Objects_and_Classes_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                AdvertismentMessage ad = new AdvertismentMessage();
                Console.WriteLine(ad.GenerateMessage());
            }

        }
    }

    public class AdvertismentMessage
    {

        public string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", 
                                                    "Best product of its category.", "Exceptional product.", 
                                                    "I can’t live without this product." };

        public string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                                                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                                                "Try it yourself, I am very satisfied.", "I feel great!" };

        public string[] Autors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


        public string GenerateMessage()
        {
            Random rand = new Random();
            string currentPhrase = Phrases[rand.Next(0, Phrases.Length - 1)];
            string currentEvent = Events[rand.Next(0, Events.Length - 1)];
            string currentAutor = Autors[rand.Next(0, Autors.Length - 1)];
            string currentCity = Cities[rand.Next(0, Cities.Length - 1)];

            return $"{currentPhrase} {currentEvent} {currentAutor} – {currentCity}.";
        }


    }
}
