using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Answer
    {
        public string QuesAnswer { get; set; }
        public Answer() { }
        public Answer(string _Aswer)
        {
            QuesAnswer = _Aswer;
        }
        public override string ToString()
        {
            return QuesAnswer;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(QuesAnswer);
        }
    }
}
