using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int bestLenght = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            int sequenceCounter = 0;

            while (input != "Clone them!")
            {
                
                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int lenght = 1;
                int bestCurrentLenght = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;

                sequenceCounter++;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {

                    if (currentSequence[i] == currentSequence[i+1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }

                    if (lenght>bestCurrentLenght)
                    {
                        bestCurrentLenght = lenght;
                        startIndex = i;
                    }
                    currentSequenceSum += currentSequence[i];

                }

                currentSequenceSum += currentSequence[n-1];

                if (bestCurrentLenght>bestLenght)
                {
                    bestLenght = bestCurrentLenght;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (bestCurrentLenght==bestLenght)
                {
                    if (startIndex<bestStartIndex)
                    {
                        bestLenght = bestCurrentLenght;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex==bestStartIndex)
                    {
                        if (currentSequenceSum>bestSequenceSum)
                        {
                            bestLenght = bestCurrentLenght;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }
                
                input = Console.ReadLine();
                
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
           
        }
    }
}
