using PersonalityTest.Business;
using PersonalityTest.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalityTest.Web
{
    public class QuestionsIterator
    {
        public static QuestionRepository QuestionRepository = new QuestionRepository();
        public static AnswerRepository AnswerRepository = new AnswerRepository();
        public List<Question> QuestionsList { get { return QuestionRepository.Get(); } }
        public List<Answer> AnswersList { get { return AnswerRepository.Get(); } }
        public int QuestionNo { get; set; }
        public int QuestionTotalNo { get; set; }
        public Question CurrentQuestion
        {
            get { return QuestionsList[QuestionNo-1]; }
        }
        public void Reset()
        {
            QuestionNo = 1;
            AnswerRepository.Reset();
        }
        public QuestionsIterator()
        {
            QuestionNo = 1;
            QuestionTotalNo = QuestionsList.Count;
        }

        public void SelectAnswer(int selected)
        {
            AnswerRepository.SelectAnswer(QuestionNo, selected);
        }

        public void Move()
        {
            QuestionNo++;
        }
        public void MoveBack()
        {
            QuestionNo--;
        }
        public bool HasNext()
        {
            return QuestionNo < QuestionTotalNo;
        }
        public bool HasPrevious()
        {
            return QuestionNo > 1;
        }
        public void MoveEnd()
        {
            QuestionNo=QuestionTotalNo;
        }

        public bool IsIntrovert()
        {
            return AnswersList.Sum(x => x.SelectedOptionIndex) < QuestionsList.Sum(x => x.Options.Length) / 2;
        }
    }
}