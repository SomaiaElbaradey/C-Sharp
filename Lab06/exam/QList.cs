using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace exam
{
    class QList: List<Question>
    {
        public List<Question> questionsList { get; set; } = new List<Question>();
        public void addList(Question question)
        {
            base.Add(question);
            string path = @$"..\..\..\QuestionList\questions.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path)) { };
            }
            File.AppendAllText(path, question.ToString() + "\n");
        }
    }
}
