using Microsoft.AspNetCore.Mvc;
using Projet_Pagination_GridView.Models;
using Projet_Pagination_GridView.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Projet_Pagination_GridView.Controllers
{
    public class ClientController : Controller
    {
        IClient _IClient;

        public ClientController(IClient maIClient)
        {
            _IClient = maIClient;
        }
        
              
        
        public IActionResult Client(int? numeroPage = 1)
        {
            ClientsPage clientsPage = new ClientsPage();
            if (numeroPage < 0)
            {
                numeroPage = 1;
            }
            var indicePage = (numeroPage ?? 1) - 1;
            var nombreClientsParPage = 6;
            int nombreClients = _IClient.NombreClient();
            var clients = _IClient.ClientsPage(numeroPage, nombreClientsParPage).ToList();
            var listeClientsPage = new StaticPagedList<Client>(clients, indicePage + 1, nombreClientsParPage, nombreClients);
            clientsPage.clients = listeClientsPage;
            clientsPage.nueroPage = numeroPage;

            return View(clientsPage);
        }
    }
}
