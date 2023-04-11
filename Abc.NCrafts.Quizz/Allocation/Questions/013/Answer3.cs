namespace Abc.NCrafts.Quizz.Questions._013
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var areEqual = AreEqual("NewCrafts", "newcrafts");
            // end

            Logger.Log("AreEqual: {0}", areEqual);
        }

        private static bool AreEqual(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            var enum1 = s1.GetEnumerator();
            var enum2 = s2.GetEnumerator();
            while (enum1.MoveNext() && enum2.MoveNext())
            {
                if (char.ToLower(enum1.Current) != enum2.Current)
                    return false;
            }
            return true;
        }
    }
}