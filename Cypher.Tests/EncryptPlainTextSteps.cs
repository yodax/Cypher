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
                cypher.Substitute(tableRow[0][0]).For(tableRow[1][0]);
            }

            _encryptedText = cypher.Encrypt(_plainText);
        }
        
        [Then(@"the cypher text should be")]
        public void ThenTheCypherTextShouldBe(string expectedCypherText)
        {
            _encryptedText.Should().Be(expectedCypherText);
        }
    }
}
