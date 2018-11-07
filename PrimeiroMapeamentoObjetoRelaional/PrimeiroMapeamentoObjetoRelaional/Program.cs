using System;

namespace PrimeiroMapeamentoObjetoRelaional
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente
            {
                Nome = "Anderson C.",
                Credito = 1000,
                Idade = 22
            };

            ClientesContext clientesContext = new ClientesContext();
            clientesContext.Clientes.Add(cliente);
            clientesContext.SaveChanges();

            Console.WriteLine("Cliente salvo com sucesso!");
            Console.ReadKey();
        }
    }
}
