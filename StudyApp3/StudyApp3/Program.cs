using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.Console;

namespace StudyApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            WriteLine("Please enter your name.");
            Player.Name = ReadLine();
            Clear();

            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Welcome {Player.Name} press any key to start.");
            ReadKey();
            ResetColor();
            Clear();

            ForegroundColor = ConsoleColor.Gray;
            Write("Here are your ");
            ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            Write("Terms ");
            ResetColor();
            ForegroundColor = ConsoleColor.Gray;
            Write("and ");
            ResetColor();
            ForegroundColor = ConsoleColor.DarkRed;
            Write("Definitions:\n");
            ResetColor();

            int n = 0;
            do
            {
                WriteLine("--------------------------");
                ForegroundColor = ConsoleColor.Cyan;
                Write($"{Question.Terms[n]}: ");
                ResetColor();
                ForegroundColor = ConsoleColor.DarkRed;
                Write($"{Question.Definitions[n]}\n");
                ResetColor();
                n++;
            } while (n <= 14);

            WriteLine("--------------------------");
            WriteLine("Press any key to start the quiz");
            ReadKey();
            Clear();

            var q1 = new Question();
            q1.QuestionTitle = $"{Question.Definitions[0]}";
            q1.Answers = new string[] { "boolean", "class", "private", "integer" };
            q1.CorrectAnswer = 3;

            var q2 = new Question();
            q2.QuestionTitle = $"{Question.Definitions[1]}";
            q2.Answers = new string[] { "array element", "boolean", "switch", "for loop" };
            q2.CorrectAnswer = 1;

            var q3 = new Question();
            q3.QuestionTitle = $"{Question.Definitions[2]}";
            q3.Answers = new string[] { "array", "string", "integer", "void" };
            q3.CorrectAnswer = 0;

            var q4 = new Question();
            q4.QuestionTitle = $"{Question.Definitions[3]}";
            q4.Answers = new string[] { "conditional statement", "class", "public", "while loop" };
            q4.CorrectAnswer = 1;

            var q5 = new Question();
            q5.QuestionTitle = $"{Question.Definitions[4]}";
            q5.Answers = new string[] { "boolean", "array index number", "array", "array element" };
            q5.CorrectAnswer = 3;

            var q6 = new Question();
            q6.QuestionTitle = $"{Question.Definitions[5]}";
            q6.Answers = new string[] { "array index number", "array element", "string", "array" };
            q6.CorrectAnswer = 0;

            var q7 = new Question();
            q7.QuestionTitle = $"{Question.Definitions[6]}";
            q7.Answers = new string[] { "void", "public", "private", "switch" };
            q7.CorrectAnswer = 2;

            var q8 = new Question();
            q8.QuestionTitle = $"{Question.Definitions[7]}";
            q8.Answers = new string[] { "void", "public", "private", "switch" };
            q8.CorrectAnswer = 1;

            var q9 = new Question();
            q9.QuestionTitle = $"{Question.Definitions[8]}";
            q9.Answers = new string[] { "class", "static", "for loop", "boolean" };
            q9.CorrectAnswer = 1;

            var q10 = new Question();
            q10.QuestionTitle = $"{Question.Definitions[9]}";
            q10.Answers = new string[] { "class", "array element", "string", "void" };
            q10.CorrectAnswer = 3;

            var q11 = new Question();
            q11.QuestionTitle = $"{Question.Definitions[10]}";
            q11.Answers = new string[] { "conditional statement", "private", "static", "integer" };
            q11.CorrectAnswer = 0;

            var q12 = new Question();
            q12.QuestionTitle = $"{Question.Definitions[11]}";
            q12.Answers = new string[] { "void", "while loop", "string", "class" };
            q12.CorrectAnswer = 2;

            var q13 = new Question();
            q13.QuestionTitle = $"{Question.Definitions[12]}";
            q13.Answers = new string[] { "for loop", "switch", "array", "while loop" };
            q13.CorrectAnswer = 3;

            var q14 = new Question();
            q14.QuestionTitle = $"{Question.Definitions[13]}";
            q14.Answers = new string[] { "array", "for loop", "while loop", "switch" };
            q14.CorrectAnswer = 1;

            var q15 = new Question();
            q15.QuestionTitle = $"{Question.Definitions[14]}";
            q15.Answers = new string[] { "string", "conditional statement", "switch", "array element" };
            q15.CorrectAnswer = 2;

            Random random = new Random();

            List<Question> questions = new List<Question>();
            questions.Add(q1);
            questions.Add(q2);
            questions.Add(q3);
            questions.Add(q4);
            questions.Add(q5);
            questions.Add(q6);
            questions.Add(q7);
            questions.Add(q8);
            questions.Add(q9);
            questions.Add(q10);
            questions.Add(q11);
            questions.Add(q12);
            questions.Add(q13);
            questions.Add(q14);
            questions.Add(q15);

            var sortedQuestions = questions.OrderBy(x => random.Next());

            foreach (var q in sortedQuestions)
            {


                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine(q.QuestionTitle);
                ResetColor();
                for (int i = 0; i < q.Answers.Length; i++)
                {
                    Write($"{i + 1}) ");
                    ForegroundColor = ConsoleColor.Cyan;
                    Write($"{q.Answers[i]}\n");
                    ResetColor();
                }
                WriteLine(String.Empty);



                int answer = -1;

                int.TryParse(ReadLine(), out answer);

                Player.points += Player.AnswerQuestion(q, answer);
                Clear();
            }
            WriteLine($"Good job {Player.Name}, you finished the quiz!");
            Write("You got a score of ");
            ForegroundColor = ConsoleColor.Green;
            Write($"{Player.points} ");
            ResetColor();
            Write("out of ");
            ForegroundColor = ConsoleColor.Green;
            Write("15\n");
            ResetColor();
            WriteLine("Press any key to exit");
            ReadKey();
        }    
    }
}
