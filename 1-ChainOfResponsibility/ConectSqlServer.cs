namespace _1_ChainOfResponsibility
{
    public class ConectSqlServer : Connect
    {
        public Connect NextConnection { get; set; }

        public string Connect(int timeOut)
        {
            if (timeOut <= 15)
            {
                return $"Connect to sql success!";
            }

            return NextConnection.Connect(timeOut);
        }
    }
}
