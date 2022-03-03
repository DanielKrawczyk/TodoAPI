namespace TodosAPI.Features
{
    internal class Paths
    {
        public const string Url = "/api";

        public static class Todos
        {
            public const string Url = Paths.Url + "/todos";
        }

        public static class Users
        {
            public const string Url = Paths.Url + "/users";
        }
    }
}
