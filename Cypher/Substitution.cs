namespace Cypher
{
    public class Substitution
    {
        public char LetterToSubstitute { get; }
        public char LetterToSubstituteWith { get; set; }

        public Substitution(char letterToSubstitute)
        {
            LetterToSubstitute = letterToSubstitute;
        }
    }
}