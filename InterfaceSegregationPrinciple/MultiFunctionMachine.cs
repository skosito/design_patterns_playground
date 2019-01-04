namespace InterfaceSegregationPrinciple
{
    public class MultiFunctionMachine : IMachine
    {
        public void Fax(Document document)
        {
            //
        }

        public void Print(Document document)
        {
            // 
        }

        public void Scan(Document document)
        {
            //
        }
    }
}