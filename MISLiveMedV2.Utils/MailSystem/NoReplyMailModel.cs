namespace MISLiveMed.Utils.MailSystem
{
    public class NoReplyMailModel
    {
        public string MailFrom { get; set; }
        public string MailDisplayNameFrom { get; set; }
        public string MailTo { get; set; }
        public string MailDisplayNameTo { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string MailUserName { get; set; }
        public string MailPassword { get; set; }
        public int MailOutgoingPort { get; set; }
        public string MailHost { get; set; }
    }
}
