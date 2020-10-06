using NUnit.Framework.Constraints;
using System;
using System.Linq;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int num = str.Split(letter).Length - 1;
            return num;
        }
    }
}
