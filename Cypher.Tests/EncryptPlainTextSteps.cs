using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Cypher.Tests
{
    [Binding]
    public class EncryptPlainTextSteps
    {
        private string _plainText;
        private string _encryptedText;

        [Given(@"the plain text")]
        public void GivenThePlainText(string plainText)
        {
            _plainText = plainText;
        }

        [When(@"I encrypt the text using the following letter substitution")]
        public void WhenIEncryptTheTextUsingTheFollowingLetterSubstitution(Table table)
        {
            var cypher = new SubstitutionCypher();

            foreach (var tableRow in table.Rows)
            {
                cypher.Substitute(tableRow[0]).For(tableRow[1]);
            }

            _encryptedText = cypher.Encrypt(_plainText);
        }
        
        [Then(@"the cypher text should be")]
        public void ThenTheCypherTextShouldBe(string expectedCypherText)
        {
            _encryptedText.Should().Be(expectedCypherText);
        }
    }

    public class SubstitutionCypher
    {
        private readonly List<Substitution> _substitutionList;

        public SubstitutionCypher()
        {
            _substitutionList = new List<Substitution>();
        }

        public Substitution Substitute(string letterToSubstitute)
        {
            var substitution = new Substitution(letterToSubstitute.ToUpper());

            _substitutionList.Add(substitution);

            return substitution;
        }

        public string Encrypt(string plainText)
        {
            var encryptedText = "";
            foreach (var letter in plainText.ToUpper())
            {
                var substitution = _substitutionList.SingleOrDefault(
                    s => s.LetterToSubstitute.Equals(letter.ToString(), StringComparison.OrdinalIgnoreCase));

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

    public static class SubstitutionExtensionMethods
    {
        public static void For(this Substitution substitution, string letterToSubstituteWith)
        {
            substitution.LetterToSubstituteWith = letterToSubstituteWith.ToUpper();
        }
    }

    public class Substitution
    {
        public string LetterToSubstitute { get; }
        public string LetterToSubstituteWith { get; set; }

        public Substitution(string letterToSubstitute)
        {
            LetterToSubstitute = letterToSubstitute;
        }
    }
}
