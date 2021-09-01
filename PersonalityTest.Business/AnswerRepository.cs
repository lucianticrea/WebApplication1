using PersonalityTest.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalityTest.Business
{
    public class AnswerRepository
    {
        private List<Answer> _answersList = new List<Answer>();
        public AnswerRepository()
        {
        }
        public List<Answer> Get()
        {
            return _answersList;
        }
        public void Reset()
        {
            _answersList = new List<Answer>();
        }

        public void SelectAnswer(int questionIndex, int optionIndex)
        {
            if (_answersList.Any(x => x.QuestionIndex == questionIndex))
            {
                _answersList.First(x => x.QuestionIndex == questionIndex).SelectedOptionIndex = optionIndex;

            }
            else
            {
                _answersList.Add(new Answer
                {
                    QuestionIndex = questionIndex - 1,
                    SelectedOptionIndex = optionIndex
                });
            }
        }

        public Answer GetCurrentAnswer(int questionIndex)
        {
            return _answersList.FirstOrDefault(x => x.QuestionIndex == questionIndex);
        }
        public bool IsSelected(int questionIndex, int optionIndex)
        {
            return _answersList.Any(x => x.QuestionIndex == questionIndex
                           && x.SelectedOptionIndex == optionIndex);
        }
    }
}