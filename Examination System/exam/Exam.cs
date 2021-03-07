using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    abstract class Exam
    {
        public int Time { get; set; }
        public Dictionary<Question, Answer> ExamDictionary { get; set; } = new Dictionary<Question, Answer>();
        public virtual void show() { }
    }
}