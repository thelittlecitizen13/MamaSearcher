using System;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            MamaSearcher ms = new MamaSearcher();
            ms.Subscribe("abc", ActionsToPerform.PrintIndexAtContent);
            ms.Subscribe("yuval", ActionsToPerform.PrintIndexAtContent);
            ms.Subscribe("assa", ActionsToPerform.PrintIndexAtContent);
            ms.Subscribe("amit", ActionsToPerform.PrintIndexAtContent);
            ms.PerformSearch("amitassa");
        }
    }
}
