using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    internal class ChoiceList: List<Choice>
    {
        public ChoiceList(): base() { }
        public string listChoices(List<Choice> choiceList)
        {
            string choices = "";
            foreach (var item in choiceList)
            {
                choices = string.Concat(choices, item.theChoice, ",");
            }
            return choices;
        }
    }
}
