namespace AdapterPatternRealWorldSample
{
    public class CertainFrameworkControlAdapter : IEditableControl
    {
        CertainFrameworkControl control;

        public CertainFrameworkControlAdapter(CertainFrameworkControl control)
        {
            this.control = control;
        }

        public void Copy() => control.Copy();

        public void Cut() => control.Cut();

        public void Paste() => control.Paste();

        public void SelectAll() => control.SelectAll();
    }
}