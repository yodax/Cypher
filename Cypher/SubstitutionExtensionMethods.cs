namespace Cypher
{
    public static class SubstitutionExtensionMethods
    {
        public static void For(this Substitution substitution, char letterToSubstituteWith)
        {
            substitution.LetterToSubstituteWith = char.ToUpper(letterToSubstituteWith);
        }
    }
}