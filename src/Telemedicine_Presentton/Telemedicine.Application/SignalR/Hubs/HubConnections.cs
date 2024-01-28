namespace Telemedicine.Application.SignalR.Hubs
{
    public static class HubConnections
    {
        public static Dictionary<string,List<string>> Users = new Dictionary<string, List<string>>();

        public static bool HasUserConnection(string userId, string connectionId)
        {
            if(Users.ContainsKey(userId))
            {
                return Users[userId].Any(P => P.Contains(connectionId));
            }

            return false;
        }

        public static void AddUserConnection(string userId, string connectionId)
        {
            if(!string.IsNullOrEmpty(userId) && HasUserConnection(userId,connectionId))
            {
                Users[userId].Add(connectionId);
            }
            Users.Add(userId, new List<string>() { connectionId});
        }

        public static List<string> OnlineUser()
        {
            return Users.Keys.ToList();
        }
    }
}
