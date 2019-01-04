namespace Builder
{
    public class HtmlBuilder
    {
        private string _rootName;
        private HtmlElement _root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            _root.Name = rootName;
            _rootName = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var child = new HtmlElement(childName, childText);
            _root.Elements.Add(child);
            
            return this;
        }

        public override string ToString()
        {
            return _root.ToString();
        }

        public void Clear()
        {
            _root = new HtmlElement { Name = _rootName };
        }
    }
}