using Projet_Pagination_GridView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Pagination_GridView.Repository
{
    public interface IClient
    {
        int NombreClient();
        List<Client> ClientsPage(int? numeroPage, int nombreClientsParPage);
    }
}
