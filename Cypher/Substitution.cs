namespace Cypher
{
    public class Substitution
    {
        public Substitution(char letterToSubstitute)
        {
            LetterToSubstitute = letterToSubstitute;
        }

        public char LetterToSubstitute { get; }
        public char LetterToSubstituteWith { get; set; }
    }
}