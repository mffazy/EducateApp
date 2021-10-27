namespace EducateApp.Controllers
{
    public class CreateUserViewModel
    {
        public string Email { get; internal set; }
        public string LastName { get; internal set; }
        public string FirstName { get; internal set; }
        public string Patronymic { get; internal set; }
        public string Password { get; internal set; }
    }
}