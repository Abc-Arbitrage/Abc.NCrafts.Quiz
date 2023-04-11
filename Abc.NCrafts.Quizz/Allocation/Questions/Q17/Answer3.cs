namespace Abc.NCrafts.Quizz.Allocation.Questions.Q17
{
    public class Answer3
    {
        public static void Run()
        {
            Create(0);

            // begin
            var item = Create(1);
            // end

            Logger.Log("Value: {0}", item.Value);
        }

        private static Item Create(int value)
        {
            return Create<Item>(value);
        }

        private static T Create<T>(int i)
            where T : IHasValue, new()
        {
            return new T { Value = i };
        }

        public interface IHasValue
        {
            int Value { get; set; }
        }

        public struct Item : IHasValue
        {
            public int Value { get; set; }
        }
    }
}