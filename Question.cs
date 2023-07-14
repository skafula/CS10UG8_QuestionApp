using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Question
    {
        public string questionText;
        public string optionA;
        public string optionB;
        public string optionC;
        public string optionD;
        public char correctAnswerLetter;

        static char defaultCorrectAnswerLetter;

        public Question()
        {
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Question(string questionText)
        {
            this.questionText = questionText;
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
        {
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.correctAnswerLetter = correctAnswerLetter;
        }

        static Question()
        {
            defaultCorrectAnswerLetter = 'X';
        }

        public bool AreOptionsValid()
        {
            int i = 0;
            i += (optionA != null) ? 1 : 0;
            i += (optionB != null) ? 1 : 0;
            i += (optionC != null) ? 1 : 0;
            i += (optionD != null) ? 1 : 0;

            return i > 1;
        }
    }
}
