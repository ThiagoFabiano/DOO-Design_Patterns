using System;


public class InvoiceHandler : DocumentHandler
{
    public override void Handle(string documentType)
    {
        if (documentType == "Invoice")
        {
            Console.WriteLine("Processing Invoice...");
        }
        else
        {
            base.Handle(documentType);
        }
    }
}
