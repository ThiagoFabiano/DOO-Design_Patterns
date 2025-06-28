using System;

public abstract class DocumentHandler
{
    protected DocumentHandler nextHandler;
    
    public DocumentHandler SetNext(DocumentHandler handler)
    {
        nextHandler = handler;
        return handler;
    }
    
    public virtual void Handle(string documentType)
    {
        if (nextHandler != null)
        {
            nextHandler.Handle(documentType);
        }
        else
        {
            Console.WriteLine($"Cannot process {documentType}.");
        }
    }
}
