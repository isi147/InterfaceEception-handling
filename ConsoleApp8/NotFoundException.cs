namespace ConsoleApp8;

internal class NotFoundException : Exception
{
    public string Message { get; set; }
    public NotFoundException(string Message) : base(Message)
    {

    }

}
