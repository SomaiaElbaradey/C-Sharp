using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    abstract class Question
    {
        public int Mark { get; set; }
        public string Body { get; set; }
        public ChoiceList ChoicesList { get; set; } = new ChoiceList();
    }
    class TF : Question
    {
        public TF(int _mark, string _body)
        {
            Mark = _mark;
            Body = _body;
            ChoicesList.Add(new Choice("True"));
            ChoicesList.Add(new Choice("False"));
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Mark, Body, ChoicesList);
        }
        public override string ToString()
        {
            return $"Mark: {Mark} the Question: {Body} Its Choices: {ChoicesList.listChoices(ChoicesList)}";
        }
    }
    class MCQ : Question
    {
        public MCQ(int _mark, string _body, ChoiceList _choicesList)
        {
            Mark = _mark;
            Body = _body;
            ChoicesList = _choicesList;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Mark, Body, ChoicesList);
        }
        public override string ToString()
        {
            return $"Mark: {Mark} the Question: {Body} Its Choices: {ChoicesList.listChoices(ChoicesList)}";
        }
    }
}