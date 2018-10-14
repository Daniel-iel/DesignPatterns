namespace _1_ChainOfResponsibility
{
    public interface Connect
    {
        Connect NextConnection { get; set; }

        string Connect(int timeOut);
    }
}
