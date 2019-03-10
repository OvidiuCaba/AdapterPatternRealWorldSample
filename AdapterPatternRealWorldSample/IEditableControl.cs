namespace AdapterPatternRealWorldSample
{
    /// <summary>
    /// This interface is created by our team, all our editable controls implement this interface
    /// </summary>
    public interface IEditableControl
    {
        void SelectAll();
        void Copy();
        void Paste();
        void Cut();
    }
}