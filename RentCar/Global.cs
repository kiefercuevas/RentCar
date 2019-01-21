using System.Collections.Generic;

namespace RentCar
{
    public static class Global
    {
        public const string Username = "Username";
        public const string Roles = "Roles";
        public const string Id = "Id";

        public const string ADMINROLE = "ADMIN";
        public const string USEROLE = "USER";
        public static Dictionary<string, object> Variables = new Dictionary<string, object>();
    }
}
