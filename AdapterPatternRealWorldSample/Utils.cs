using System;
using System.Runtime.CompilerServices;

namespace AdapterPatternRealWorldSample
{
    public static class Utils
    {
        public static IEditableControl GetControl(Control control)
        {
            if (control is IEditableControl)
            {
                return (IEditableControl)control;
            }
            else if (control is CertainFrameworkControl)
            {
                return new CertainFrameworkControlAdapter((CertainFrameworkControl)control);
            }
            else if (control is CertainThirdPartyControl)
            {
                return new CertainThirdPartyControlAdapter((CertainThirdPartyControl)control);
            }
            else
            {
                return null;
            }
        }

        public static void DisplayTheCaller([CallerFilePath] string fileName = "", [CallerMemberName] string callerMethod = "")
        {
            Console.WriteLine($"{fileName.Substring(fileName.LastIndexOf('\\') + 1).Replace(".cs", string.Empty)}.{callerMethod}()");
        }
    }
}