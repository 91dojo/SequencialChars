using System;
using System.Text.RegularExpressions;

namespace ContinuousChars
{
    public class Validator
    {
        public bool IsContinuous(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException(nameof(input));

            var lowerInput = input.ToLower();
            int? lastChar = null;
            var regex = new Regex(@"[a-zA-Z]|[*]|\d");
            foreach (var character in lowerInput)
            {
                if (!regex.IsMatch(character.ToString()))
                {
                    return false;
                }

                if (lastChar == null)
                {
                    if (character != '*')
                    {
                        lastChar = character;
                    }

                    continue;
                }

                if (character == '*')
                {
                    lastChar += 1;
                    continue;
                }

                if (character - lastChar != 1)
                {
                    return false;
                }

                lastChar = character;
            }

            return true;
        }
    }
}