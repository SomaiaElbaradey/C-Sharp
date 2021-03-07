using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoiceList Choices01 = new ChoiceList();
            Choices01.Add(new Choice("C"));
            Choices01.Add(new Choice("C++"));
            Choices01.Add(new Choice("Java"));
            Choices01.Add(new Choice("C#"));
            Choices01.Add(new Choice("JS"));
            Choices01.Add(new Choice("Python"));
            
            ChoiceList Choices02 = new ChoiceList();
            Choices02.Add(new Choice("C#"));
            Choices02.Add(new Choice("JS"));
            Choices02.Add(new Choice("Python"));

            Console.WriteLine("Final:");
            Final Exam01 = new Final();
            Exam01.ExamDictionary.Add(new MCQ(2, "fav programming language", Choices01), new Answer("JS"));
            Exam01.ExamDictionary.Add(new MCQ(1, "which programming language you're learning rn?", Choices02), new Answer("C#"));
            Exam01.show();

            Console.WriteLine("Practic:");
            Practice practice01 = new Practice();
            practice01.ExamDictionary.Add(new MCQ(1, "fav programming language", Choices01), new Answer("Python"));
            practice01.ExamDictionary.Add(new MCQ(1, "which programming language you're learning rn?", Choices02), new Answer("C#"));
            practice01.show();

            //add to file
            QList QList01 = new QList();
            QList01.addList(new MCQ(1, "your fav programming language..", Choices01));

            QList QList02 = new QList();
            QList02.addList(new MCQ(1, "which programming language you're learning rn?", Choices02));
        }
    }
}