namespace AdapterPatternRealWorldSample
{
    /// <summary>
    /// This is a custom control implemented by our team
    /// </summary>
    public class EditableControl1 : Control, IEditableControl
    {
        public void Copy()
        {
            Utils.DisplayTheCaller();
        }

        public void Cut()
        {
            Utils.DisplayTheCaller();
        }

        public void Paste()
        {
            Utils.DisplayTheCaller();
        }

        public void SelectAll()
        {
            Utils.DisplayTheCaller();
        }
    }
}