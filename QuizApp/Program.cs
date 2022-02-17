using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Question> questionList = new List<Question>();

            Question question1 = new Question("Sport" , "Who is Michael Jordan?" , "A" , "Basketball Player" , "Artist" , "Singer" , "Politican");
            Question question2 = new Question("Math", "2 + 2 = ?", "D", "1", "2", "3", "4");
            Question question3 = new Question("Math", "2 - 3 = ?", "A", "-1", "0", "1", "3");
            Question question4 = new Question("Sport", "Who is Cristiano Ronaldo?", "B", "Movie Player", "Football Player", "Singer", "Politican");
            Question question5 = new Question("Movie", "Iron-Man's name?", "B", "Walter White", "Tony Stark", "John Doe", "Bruce Wayne");

            questionList.Add(question1);
            questionList.Add(question2);
            questionList.Add(question3);
            questionList.Add(question4);
            questionList.Add(question5);

            int i = 1;
            int point = 0;
            int pointPerQuestion = 100 / questionList.Count;
            foreach (var question in questionList)
            {
                
                
                Console.WriteLine("Question " + i  + ":");
                Console.WriteLine("Question Type : " + question.QuestionType);
                Console.WriteLine("Question : " + question.QuestionText);               
                Console.WriteLine("Please answer the question?");
                Console.WriteLine();
                Console.WriteLine("(A) " + question.QuestionAnswerA);
                Console.WriteLine("(B) " + question.QuestionAnswerB);
                Console.WriteLine("(C) " + question.QuestionAnswerC);
                Console.WriteLine("(D) " + question.QuestionAnswerD);
                string answer = Console.ReadLine();
                string correctAnswer = question.QuestionAnswer.ToString();          
                bool correctCorrect = correctAnswer.Equals(answer);               
                if(answer == "A"  || answer == "B" || answer == "C" || answer == "D")
                {
                    if (correctCorrect)
                    {
                        point += pointPerQuestion;
                    }                   
                }
                else
                {
                    Console.Write("Please answer in the correct format !");
                }


                Console.WriteLine();
                Console.WriteLine("**********************");
                i += 1;
                
            }

            Console.WriteLine("Total Point = " + point);
            Console.ReadKey();
            


        }
    }
}
