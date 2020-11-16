using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.Console;

namespace StudyApp3
{
    class Player
    {

        public static int points = 0;
        public static string Name;

        public Player()
        {
            Title = "Study App by Jack Gunther";
            Title = "Study App by Jack Gunther";
            WriteLine("Welcome to Study App by Jack Gunther.");
            WriteLine("-------------------------------");
        }

        public static int AnswerQuestion(Question question, int answer)
        {
            int result = 0;
            if (question.CorrectAnswer + 1 == answer)
            {
                result = 1;
            }
            return result;
        }
    }
}
