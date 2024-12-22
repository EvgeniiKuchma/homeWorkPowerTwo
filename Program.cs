using System;

namespace homeWorkPowerTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPower = 0;
            int numberPowerTwo =2;
            int numberTwo = 2;
            int givenNumber;
            int minValue = 2;
            int maxValue = 100;
            bool isRunning = true;

            Random random = new Random();
            givenNumber = random.Next(minValue,maxValue);

            while (isRunning)
            {
                numberPowerTwo *= numberTwo;
                countPower++;

                if (numberPowerTwo > givenNumber)
                { 
                isRunning = false;
                }
            }

            Console.WriteLine(givenNumber);
            Console.WriteLine(numberPowerTwo);
            Console.WriteLine(countPower);
        }
    }
}
