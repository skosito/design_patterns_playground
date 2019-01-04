namespace InterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document document)
        {
            //
        }

        // ...
        public void Print(Document document)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new System.NotImplementedException();
        }
    }
}