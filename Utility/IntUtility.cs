namespace Utility
{
    public static class IntUtility
    {
        public static int GetNearestMultiple(int source, int multiple)
        {
            while (source % multiple != 0)
            {
                source++;
            }

            return source;
        }
    }
}