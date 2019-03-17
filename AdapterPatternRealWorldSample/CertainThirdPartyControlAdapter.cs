namespace AdapterPatternRealWorldSample
{
    public class CertainThirdPartyControlAdapter : IEditableControl
    {
        CertainThirdPartyControl control;

        public CertainThirdPartyControlAdapter(CertainThirdPartyControl control)
        {
            this.control = control;
        }

        public void Copy() => control.Copy();

        public void Cut() => control.Cut();

        public void Paste() => control.Paste();

        // Note that we call Select() because this is what CertainThirdPartyControl exposes for this functionality
        public void SelectAll() => control.Select();
    }
}