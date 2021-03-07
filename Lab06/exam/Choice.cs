using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Choice
    {
        public string theChoice { get; set; }
        public Choice() { }
        public Choice(string _Choice)
        {
            theChoice = _Choice;
        }
        public override string ToString()
        {
            return theChoice;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(theChoice);
        }
    }
}
