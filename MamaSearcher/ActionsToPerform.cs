using System;

namespace MamaSearcher
{
    public class ActionsToPerform
    {
        public static void PrintIndexAtContent(int index, string content)
        {
            Console.WriteLine($"Content '{content}' contains a pattern at index {index}.");
        }
    }
}
