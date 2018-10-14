namespace _1_ChainOfResponsibility
{
    public class TryConnection
    {
        public string Connect(int timeOut)
        {
            Connect oracle = new ConectOracle();
            Connect sql = new ConectSqlServer();
            Connect noConnect = new ConectDatabaseFound();

            oracle.NextConnection = sql;
            sql.NextConnection = noConnect;

            return oracle.Connect(timeOut);
        }
    }
}
