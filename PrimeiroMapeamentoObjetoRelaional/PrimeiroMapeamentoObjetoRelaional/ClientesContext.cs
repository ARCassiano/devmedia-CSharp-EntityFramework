using System.Data.Entity;

namespace PrimeiroMapeamentoObjetoRelaional
{
    public class ClientesContext : DbContext
    {
        public ClientesContext():base("BancoClientes")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
