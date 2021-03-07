using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Practice : Exam
    {
        public Practice() { }
        public override void show()
        {
            foreach (KeyValuePair<Question, Answer> dictioary in ExamDictionary)
            {
                Console.WriteLine($"{dictioary.Key.ToString()} Answer: {dictioary.Value}");
            }
        }
    }
}
