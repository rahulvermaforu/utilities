namespace Library
{
    public static class RandomNumberGenerator
    {
        static Random random = new Random();
        public static int Generate()
        {
            return random.Next();
        }
    }
}