namespace _03.CorrectBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountBrackets
    {
        public string iSBreacketsEven(string formula)
        {
            int startBrack = 0;
            int endBrack = 0;
            char[] stringToChar = formula.ToArray();

            for (int i = 0; i < stringToChar.Length; i++)
            {
                if (stringToChar[0] == ')' || stringToChar[stringToChar.Length - 1] == '(')
                {
                    return "Incorect";
                }
                if (stringToChar[i] == '(')
                {
                    startBrack++;
                }
                if (stringToChar[i] == ')')
                {
                    endBrack++;
                }
            }

            if (startBrack == endBrack)
            {
                return "Correct";
            }
            else
            {
                return "Incorrect";
            }
        }
    }

    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string formula = Console.ReadLine();
            CountBrackets bracket = new CountBrackets();
            Console.WriteLine(bracket.iSBreacketsEven(formula));

        }
    }
}
