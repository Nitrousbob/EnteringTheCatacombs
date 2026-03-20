using System;
using System.Collections.Generic;
using System.Text;

namespace EnteringTheCatacombs
{
    internal class Validator
    {
        /*
         * Passwords must be at least 6 letters long and no more than 13 letters long
         * Passwords must contain at least one uppercase letter, one lowercase letter, and one number
         * Passwords cannot contain a capital T or an ampersand because ingelmar in IT has decreed it
         */

        public string input { get; private set; }

        public Validator(string input)
        {
            this.input = input;
        }

        public bool Validate(string input)
        {
            bool hasUC = false;
            bool hasLC = false;
            bool hasNum = false;
            bool allTypes = false;
            if (input.Length < 6 || input.Length > 13)
            {
                Console.WriteLine("Password needs to be between 5 and 13 characters");
                return false;
            }

            foreach (char c in input)
            {
                if (c == 'T' || c == '&')
                {
                    Console.WriteLine("cannot contain the capitol 'T' or '&'");
                    return false;
                }
                if (char.IsUpper(c)) { hasUC = true; }
                if (char.IsLower(c)) { hasLC = true; }
                if (char.IsDigit(c)) { hasNum = true; }
            }
            return (hasUC && hasLC && hasNum);
        }
    }
}
