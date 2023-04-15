using System;

namespace ConsoleApp
{
    class Program
    {
        static void ConvertDoubleToWord(double num)
        {
            string numStr = Convert.ToString(num);
            int numLength = numStr.Length;
            string numWord = "";

            for(int i = 0; i < numLength; i++)
            {
                if (numStr[i] == '-') numWord += "minus ";
                if (numStr[i] == ',') numWord += "point ";
                if (numStr[i] == '1') numWord += "one ";
                if (numStr[i] == '2') numWord += "two ";
                if (numStr[i] == '3') numWord += "three ";
                if (numStr[i] == '4') numWord += "four ";
                if (numStr[i] == '5') numWord += "five ";
                if (numStr[i] == '6') numWord += "six ";
                if (numStr[i] == '7') numWord += "seven ";
                if (numStr[i] == '8') numWord += "eight ";
                if (numStr[i] == '9') numWord += "nine ";
                if (numStr[i] == '0') numWord += "zero ";
            }
            Console.WriteLine(numWord);
        }
        static void Main(string[] args)
        {
            double num = 25.8;
            ConvertDoubleToWord(num);
        }
    }
}
