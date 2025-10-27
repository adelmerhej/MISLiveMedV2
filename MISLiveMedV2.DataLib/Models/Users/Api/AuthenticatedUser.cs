namespace MISLiveMed.Models.Models.Users.Api
{
    public class AuthenticatedUser
    {
        private string _accessToken;
        private string _authUserId;

        public string Access_Token
        {
            get => _accessToken;
            set => _accessToken = value;
        }

        public string AuthUserId
        {
            get => _authUserId;
            set => _authUserId = value;
        }
    }
}
