using System;

namespace MISLiveMed.Models.Models.Users.Api
{
    public class LoggedInUserModel
    {
        private string _token;
        private string _authUserId;
        private DateTime _loginDate;

        public string Token
        {
            get => _token;
            set => _token = value;
        }

        public string AuthUserId
        {
            get => _authUserId;
            set => _authUserId = value;
        }

        public DateTime LoginDate
        {
            get => _loginDate;
            set => _loginDate = value;
        }
    }
}
