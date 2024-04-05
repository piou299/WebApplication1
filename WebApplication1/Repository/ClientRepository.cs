using WebApplication1.IRepository;
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly BddContecxt _Context;
        public ClientRepository (BddContecxt Context) 
        {
            _Context = Context;
        }
        

        public IEnumerable<Livre> GetClient => _Context.Clients.ToList();

        public async Task<Livre> AddClient(Livre client)
        {
            await _Context.Clients.AddAsync(client);
            await _Context.SaveChangesAsync();
            return client;
        }

        public Livre GetClientByID(int Id)
        {
            return _Context.Clients.FirstOrDefault(c => c.ClientId == Id);
        }
    }
}
