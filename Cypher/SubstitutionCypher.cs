using System;
using System.Collections.Generic;
using System.Linq;

namespace Cypher
{
    public class SubstitutionCypher
    {
        private readonly List<Substitution> _substitutionList;

        public SubstitutionCypher()
        {
            _substitutionList = new List<Substitution>();
        }

        public Substitution Substitute(char letterToSubstitute)
        {
            var upperCaseLetterToSubstitute = char.ToUpper(letterToSubstitute);
            var substitution = new Substitution(upperCaseLetterToSubstitute);

            _substitutionList.Add(substitution);

            return substitution;
        }

        public string Encrypt(string plainText)
        {
            var encryptedText = "";
            foreach (var letter in plainText.ToUpper())
            {
                var substitution = _substitutionList.SingleOrDefault(
                    s => s.LetterToSubstitute.Equals(letter));

                if (substitution != null)
                {
                    encryptedText += substitution.LetterToSubstituteWith;
                }
                else
                {
                    encryptedText += letter;
                }
            }

            return encryptedText;
        }
    }
}