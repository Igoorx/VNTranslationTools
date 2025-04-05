namespace VNTextPatch.Shared
{
    public struct ScriptString
    {
        public ScriptString(string text, ScriptStringType type, int offset = 0)
        {
            Offset = offset;
            Text = text;
            Type = type;
        }

        public int Offset;
        public string Text;
        public ScriptStringType Type;

        public override string ToString()
        {
            return Text;
        }
    }
}
