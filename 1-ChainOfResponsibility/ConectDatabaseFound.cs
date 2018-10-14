namespace _1_ChainOfResponsibility
{
    public class ConectDatabaseFound : Connect
    {
        public Connect NextConnection { get; set; }

        public string Connect(int timeOut)
        {
            return $"Connect fail!";
        }
    }
}
