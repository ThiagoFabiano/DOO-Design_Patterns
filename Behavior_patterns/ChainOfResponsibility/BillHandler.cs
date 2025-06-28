using System;

public class BillHandler : DocumentHandler
{
    public override void Handle(string documentType)
    {
        if (documentType == "Bill")
        {
            Console.WriteLine("Processing Bill...");
        }
        else
        {
            base.Handle(documentType);
        }
    }
}
