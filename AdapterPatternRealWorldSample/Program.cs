using System;

namespace AdapterPatternRealWorldSample
{
    class Program
    {
        private static CertainThirdPartyControl certainThirdPartyControl = new CertainThirdPartyControl();
        private static CertainFrameworkControl certainFrameworkControl = new CertainFrameworkControl();
        private static EditableControl1 editableControl1 = new EditableControl1();
        private static EditableControl2 editableControl2 = new EditableControl2();

        static void Main(string[] args)
        {
            SelectAll(certainThirdPartyControl);
            Copy(certainFrameworkControl);
            Paste(editableControl1);
            Cut(editableControl2);

            Console.ReadKey();
        }

        private static void SelectAll(Control control)
        {
            IEditableControl activeControl = GetActivecontrol(control);
            activeControl?.SelectAll();
        }

        private static void Copy(Control control)
        {
            IEditableControl activeControl = GetActivecontrol(control);
            activeControl?.Copy();
        }

        private static void Paste(Control control)
        {
            IEditableControl activeControl = GetActivecontrol(control);
            activeControl?.Paste();
        }

        private static void Cut(Control control)
        {
            IEditableControl activeControl = GetActivecontrol(control);
            activeControl?.Cut();
        }

        private static IEditableControl GetActivecontrol(Control control)
        {
            // Initially here there were about 10 lines of code that determined the active control.
            // In the production code, the control object passed as parameter is a container of controls.
            // But since determining the active control is out of scope, in order to keep things simple, we'll ignore those lines.
            return Utils.GetControl(control);
        }
    }
}