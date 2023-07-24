namespace homework_21_quiz_remake.Helpers;

    public static class Extensions
    {
        private static readonly Random @Random = new ();

        public static void Shuffle<T>(this IList<T> list)
        {
            var count = list.Count;
            while (count > 1)
            {
                count--;
                var k = @Random.Next(count + 1);
                (list[k], list[count]) = (list[count], list[k]);
            }
        }
    }
