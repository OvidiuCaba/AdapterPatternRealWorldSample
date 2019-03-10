namespace AdapterPatternRealWorldSample
{
    /// <summary>
    /// Let's suppose that this is a certain third party control
    /// </summary>
    public class CertainThirdPartyControl : Control
    {
        /// <summary>
        /// Note that this class doesn't have a SelectAll() method; instead, it has a Select() method
        /// </summary>
        internal void Select()
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