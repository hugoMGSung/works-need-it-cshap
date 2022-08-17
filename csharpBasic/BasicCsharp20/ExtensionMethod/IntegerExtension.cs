namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int Int)
        {
            return Int * Int;
        }

        public static int Power(this int Int, int exponent)
        {
            int result = Int;
            for (int i = 1; i < exponent; i++)
            {
                result *= Int;
            }
            return result;
        }
    }
}