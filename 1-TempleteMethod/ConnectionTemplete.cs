namespace _1_TempleteMethod
{
    public abstract class ConnectionTemplete
    {
        public abstract void ConnectOracle(string connectionString);
        public abstract void ConnectSQL(string connectionString);

        public void Connect(string connectionString)
        {

            switch (connectionString.EndsWith('2'))
            {
                case true:
                    ConnectSQL(connectionString);
                    break;
                case false:
                    ConnectOracle(connectionString);
                    break;
                default:
                    break;
            }
        }
    }
}

