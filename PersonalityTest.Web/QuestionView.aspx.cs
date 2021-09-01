using PersonalityTest.Business;
using PersonalityTest.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalityTest.Web
{
    public partial class QuestionView : System.Web.UI.Page
    {
        private static QuestionsIterator QuestionsIterator = new QuestionsIterator();
        public Question CurrentQuestion
        {
            get { return QuestionsIterator.CurrentQuestion; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                QuestionsIterator.Reset();
                UpdateControls();
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            QuestionsIterator.MoveEnd();
            Response.Redirect("Result.aspx?IsIntrovert=" + QuestionsIterator.IsIntrovert());
        }
        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            QuestionsIterator.MoveBack();
            UpdateControls();
        }
        protected void btnNext_Click(object sender, EventArgs e)
        {
            QuestionsIterator.Move();
            UpdateControls();
        }

        void UpdateControls()
        {
            lblHeaderTitle.Text = $"QUESTION {QuestionsIterator.QuestionNo} OF {QuestionsIterator.QuestionTotalNo}";
            lblQuestion.Text = QuestionsIterator.CurrentQuestion.Title;
            var questions = QuestionsIterator.CurrentQuestion.Options
                                .Select(x => new ListItem(x, x))
                                .ToArray();
            foreach( var question in questions)
            {
                question.Selected = false;
            }
            var answer = QuestionsIterator.AnswerRepository.GetCurrentAnswer(QuestionsIterator.QuestionNo - 1);
            if (answer!= null && answer.SelectedOptionIndex > 0)
                questions[answer.SelectedOptionIndex].Selected = true;
            rblQuestions.Items.Clear();
            rblQuestions.Items.AddRange(questions);
            btnPrevious.Visible = QuestionsIterator.HasPrevious();
            btnNext.Visible = QuestionsIterator.HasNext();
            btnFinish.Visible = QuestionsIterator.HasPrevious();
        }

        protected void rblQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionsIterator.SelectAnswer(rblQuestions.SelectedIndex);
        }
    }
}