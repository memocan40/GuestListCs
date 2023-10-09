namespace GuestList.Data
{
    public class Connectionstring
    {
        public static string Get()
        {
            var uriString = "postgres://zetjioms:NEqIO3LOKV0_dsUq9o_PPhYyViplMyy4@cornelius.db.elephantsql.com/zetjioms";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);
            return connStr;
        }
    }
}
