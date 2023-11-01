using Alura.RPA.Domain.Repositories;

namespace Alura.RPA.Domain.Services
{
    public class UserService
    {
        private readonly ICursosRepository userRepository;

        public UserService(ICursosRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void DoSomething()
        {
            Environment.Exit(0);
        }
    }
}
