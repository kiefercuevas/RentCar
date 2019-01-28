using System.Collections.Generic;

namespace RentCar
{
    public static class Global
    {
        public const string Username = "Username";
        public const string rol = "Rol";
        public const string Id = "Id";

        public const string DefaultPassword = @"A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=";


        public const string ADMINROLE = "ADMIN";
        public const string USEROLE = "USER";
        public static Dictionary<string, object> Variables = new Dictionary<string, object>();

        public  enum Filter :int
        {
            FILTER_BY_PARAM,
            FILTER_BY_START_DATE,
            FILTER_BY_END_DATE,
            FILTER_BY_START_DATE_AND_PARAM,
            FILTER_BY_END_DATE_AND_PARAM,
            FILTER_BETWEEN_DATES,
            FILTER_BETWEEN_DATES_AND_PARAM,
        }
    }


    

}
