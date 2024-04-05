using WebApplication1.Model;

namespace WebApplication1.IRepository
{
    public interface IClientRepository
    {
        public Task<Livre> AddClient(Livre client);
        Livre GetClientByID(int Id);
        IEnumerable<Livre> GetClient { get; }
    }
}
