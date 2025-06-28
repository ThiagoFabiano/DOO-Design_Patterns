using System;

public class ReceiptHandler : DocumentHandler
{
    public override void Handle(string documentType)
    {
        if (documentType == "Receipt")
        {
            Console.WriteLine("Processing Receipt...");
        }
        else
        {
            base.Handle(documentType);
        }
    }
}
