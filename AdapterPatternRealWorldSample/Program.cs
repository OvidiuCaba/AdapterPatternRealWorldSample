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
            // Initially here there were about 10 lines of code that determined the active control.
            // In the production code, the control object passed as parameter is a container of controls.
            // But since determining the active control is out of scope, in order to keep things simple, we'll ignore those lines.
            Control activeControl = control;

            if (activeControl is CertainFrameworkControl)
            {
                ((CertainFrameworkControl)activeControl).SelectAll();
            }
            else if (activeControl is IEditableControl)
            {
                ((IEditableControl)activeControl).SelectAll();
            }
            else if (activeControl is CertainThirdPartyControl)
            {
                ((CertainThirdPartyControl)activeControl).Select();
            }
        }

        private static void Copy(Control control)
        {
            // Initially here there were about 10 lines of code that determined the active control
            Control activeControl = control;

            if (activeControl is CertainFrameworkControl)
            {
                ((CertainFrameworkControl)activeControl).Copy();
            }
            else if (activeControl is IEditableControl)
            {
                ((IEditableControl)activeControl).Copy();
            }
            else if (activeControl is CertainThirdPartyControl)
            {
                ((CertainThirdPartyControl)activeControl).Copy();
            }
        }

        private static void Paste(Control control)
        {
            // Initially here there were about 10 lines of code that determined the active control
            Control activeControl = control;

            if (activeControl is CertainFrameworkControl)
            {
                ((CertainFrameworkControl)activeControl).Paste();
            }
            else if (activeControl is IEditableControl)
            {
                ((IEditableControl)activeControl).Paste();
            }
            else if (activeControl is CertainThirdPartyControl)
            {
                ((CertainThirdPartyControl)activeControl).Paste();
            }
        }

        private static void Cut(Control control)
        {
            // Initially here there were about 10 lines of code that determined the active control
            Control activeControl = control;

            if (activeControl is CertainFrameworkControl)
            {
                ((CertainFrameworkControl)activeControl).Cut();
            }
            else if (activeControl is IEditableControl)
            {
                ((IEditableControl)activeControl).Cut();
            }
            else if (activeControl is CertainThirdPartyControl)
            {
                ((CertainThirdPartyControl)activeControl).Cut();
            }
        }
    }
}