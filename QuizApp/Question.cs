using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Question
    {
        private string questionType;
        private string questionText;
        private string questionAnswer;
        private string questionAnswerA;
        private string questionAnswerB;
        private string questionAnswerC;
        private string questionAnswerD;

        public Question(string questiontype, string questiontext, string questionanswer, string questionanswera, string questionanswerb, string questionanswerc, string questionanswerd)
        {
            questionType = questiontype;
            questionText = questiontext;    
            questionAnswer = questionanswer;             
            questionAnswerA = questionanswera;
            questionAnswerB = questionanswerb;
            questionAnswerC = questionanswerc;
            questionAnswerD = questionanswerd;

        }
        
        public string QuestionType { get => questionType; set => questionType = value; }
        public string QuestionText { get => questionText; set => questionText = value; }
        public string QuestionAnswer { get => questionAnswer; set => questionAnswer = value; }
        public string QuestionAnswerA { get => questionAnswerA; set => questionAnswerA = value; }
        public string QuestionAnswerB { get => questionAnswerB; set => questionAnswerB = value; }
        public string QuestionAnswerC { get => questionAnswerC; set => questionAnswerC = value; }
        public string QuestionAnswerD { get => questionAnswerD; set => questionAnswerD = value; }
    }
}
