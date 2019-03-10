using System;
using System.Runtime.CompilerServices;

namespace AdapterPatternRealWorldSample
{
    public static class Utils
    {
        public static void DisplayTheCaller([CallerFilePath] string fileName = "", [CallerMemberName] string callerMethod = "")
        {
            Console.WriteLine($"{fileName.Substring(fileName.LastIndexOf('\\') + 1).Replace(".cs", string.Empty)}.{callerMethod}()");
        }
    }
}