using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.Console;

namespace StudyApp3
{
    class Question
    {       
        public static string Term = "Terms.txt";
        public static string[] Terms = File.ReadAllLines(Term);
        public static string Define = "Definitions.txt";
        public static string[] Definitions = File.ReadAllLines(Define);

        public string QuestionTitle { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
