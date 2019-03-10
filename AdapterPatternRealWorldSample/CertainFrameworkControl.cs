namespace AdapterPatternRealWorldSample
{
    /// <summary>
    /// Let's suppose that this is a certain Windows Forms control
    /// </summary>
    public class CertainFrameworkControl : Control
    {
        internal void SelectAll()
        {
            Utils.DisplayTheCaller();
        }

        internal void Copy()
        {
            Utils.DisplayTheCaller();
        }

        internal void Paste()
        {
            Utils.DisplayTheCaller();
        }

        internal void Cut()
        {
            Utils.DisplayTheCaller();
        }
    }
}