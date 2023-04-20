namespace Scacchi {
    public class UserData {

        public string UserName { get; set; }
        public string? RealName { get; set; }
        public string Id { get; set; }
        public long Elo { get; set; }
        public int Wins { get; set; }
        public int Loss { get; set; }

        public string? CurrentTeamColor { get; set; }

        private UserData(string userName, string id) {
            UserName = userName;
            Id = id;
        }

        public static UserData CreateUser(string userName) {



        }

        public static UserData? RetrieveUser(string userName, string psw) {

        }

    }
}
