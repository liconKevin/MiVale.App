
using MiVale.Domain.Entities;
using MiVale.Domain.ValueObjects;

namespace MiVale.Domain.Repositories
{
    public interface ClientRepositorie
    {
        Task CreateClient(Client client);

        Task DeleteClient(PhoneNumber phoneNumber);

        Task UpdateClient(Client client);

        Task<Client> GetClient(PhoneNumber phoneNumber);

        Task<List<Client>> GetClients();

    }
}
