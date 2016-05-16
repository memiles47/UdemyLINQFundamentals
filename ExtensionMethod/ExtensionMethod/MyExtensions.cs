namespace ExtensionMethod
{
    static class MyExtensions
    {
        public static int CalculateDigits(this string value)
        {
            var count = 0;

            foreach (var ch in value)
            {
                if (char.IsDigit(ch))
                    count ++;
            }
            return count;
        }
    }
}