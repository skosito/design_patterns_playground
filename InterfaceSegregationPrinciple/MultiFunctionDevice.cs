namespace InterfaceSegregationPrinciple
{
    public class Printer : IPrinter
    {
        public void Print(Document document)
        {
            //
        }
    }

    public class Scanner : IScanner
    {
        public void Scan(Document document)
        {
            // 
        }
    }

    // example of decorator pattern, to delegate implementation to fields
    public class MultiFunctionDevice : IMultiFunctionDevice
    {
        private Printer _printer;
        private Scanner _scanner;

        public MultiFunctionDevice(Printer printer, Scanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }
    }
}