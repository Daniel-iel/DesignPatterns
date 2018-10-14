namespace _1_ChainOfResponsibility
{
    public class ConectOracle : Connect
    {
        public Connect NextConnection { get; set; }

        public string Connect(int timeOut)
        {
            if (timeOut <= 10)
            {
                return $"Connect to oracle success!";
            }

            return NextConnection.Connect(timeOut);
        }
    }
}
