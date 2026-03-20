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

        public string AskForPassword()
        {
            string? input;
            Console.WriteLine("Create a password between 5-13 characters, no capital T, and no &.");
            input = Console.ReadLine();
            if (input != null)
            {
                foreach (char c in input)
                {
                    if (c == 'T') { Console.WriteLine("cannot contain the capitol T"); }
                    if (c == '&') { Console.WriteLine("cannot contain the & symbol"); }
                }
            }
            return input;
        }

        public void PasswordValidator(string input)
        {
        //foreach with a string lets you get its characters!
        // foreach (char letter in word) {... }
        //char has static methods to categorize letters!
        //char.IsUpper('T'), char.IsLower('t'), char.isDigit('4')

        }
    }
}
