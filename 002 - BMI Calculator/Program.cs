using static System.Console;
using static System.Convert;

namespace bmicalculator
{
    class bmicalculator
    {
        public static void Main(string[] args)
        {
            float nWeight, nHeight, nBMI;

            nWeight = validateNumericInput("Enter your weight in Kilograms: ");

            nHeight = validateNumericInput("Enter yout height in metres: ");

            nBMI = nWeight / (nHeight * nHeight);

            WriteLine("Your BMI is {0:F2}", nBMI);

            if (nBMI < 18.5)
            {
                WriteLine("Your are underweight");
            }
            else if (nBMI > 18.5 && nBMI < 25)
            {
                WriteLine("Your weight is Normal");
            }
            else if (nBMI > 25 && nBMI < 29.9)
            {
                WriteLine("Your are overweight");
            }
            else
            {
                WriteLine("Your are Obese.");
            }

            Read();
        }

        public static float validateNumericInput(string cMessage)
        {
            while (true)
            {
                WriteLine(cMessage);
                string? cInput = ReadLine();

                try
                {
                    float nInput = ToSingle(cInput);
                    return nInput;
                }
                catch (Exception e)
                {
                    WriteLine("You have entered an invalid number. Please Try again: {0} {1}", e.Message, "\n");
                }
            }
        }
    }
}