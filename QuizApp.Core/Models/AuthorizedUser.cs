namespace QuizApp.Core.Models
{
    public class AuthorizedUser
    {
        public string AccessToken { get; set; }
        public string IdentityToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
