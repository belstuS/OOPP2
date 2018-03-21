using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Calculator
    {
        string inputString1;
        string inputString2;
        string inputString3;
        string inputString4;
        public Calculator()
        { }
        public Calculator(string inputString1, string inputString2, string inputString3,
            string inputString4)
        {
            Initialize(inputString1, inputString2, inputString3, inputString4);
        }
        public void Initialize(string inputString1, string inputString2, string inputString3,
            string inputString4)
        {
            this.inputString1 = inputString1;
            this.inputString2 = inputString2;
            this.inputString3 = inputString3;
            this.inputString4 = inputString4;
        }
        public string Union()
        {
            return inputString1 + inputString2;
        }
        public string Delete()
        {
            return inputString1.Replace(inputString2, "");
        }
        public string Replace()
        {
            return inputString1.Replace(inputString2, inputString4);
        }
        public string IndexOfSymbol()
        {
            return Convert.ToString(inputString1[Convert.ToInt32(inputString2)]);
        }
        public string LenghtOfString()
        {
            return Convert.ToString(inputString3.Length);
        }
        public string DoubleVowel()
        {
            StringBuilder buf = new StringBuilder(inputString3);
            char[] vowels = { 'a', 'y', 'u', 'i', 'o', 'e' };
            for (int i = 0; i < inputString3.Length; i++)
            {
                if (vowels.Contains(buf[i]))
                {
                    buf.Insert(i + 1, buf[i++].ToString());
                }
            }
            return buf.ToString();
        }
    }
}
