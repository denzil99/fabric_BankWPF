using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ClassLibrary
{
    internal class Repository
    {
        ObservableCollection<Client> clients;

        public Repository()
        {
            clients = new ObservableCollection<Client>();
        }

        //public Repository(IEnumerable<Client> cl)
        //{
        //    clients = cl.To;
        //}

        public void Add(Client client) => clients.Add(client);
        
        public void Remove(Client client) => clients.Remove(client);

        public void RewriteClients(Client oldClient, Client newClient)
        {
            clients.Remove(oldClient);
            clients.Add(newClient);
        }




    }
}
