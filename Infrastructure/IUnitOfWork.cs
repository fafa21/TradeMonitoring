using ApplicationCore.Interface;

namespace ApplicationCore
{
    public interface IUnitOfWork
    {

        IUserRepository UserRepository { get; }

        Task CompleteAsync();
    }
}
