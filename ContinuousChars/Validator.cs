using System;

namespace ContinuousChars
{
    public class Validator
    {
        public bool IsContinuous(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            if (input.Length == 1)
            {
                return true;
            }

            var characterLookup = "abcdefghijklmnopqrstuvwxyz";

            return characterLookup.Contains(input);
        }
    }
}