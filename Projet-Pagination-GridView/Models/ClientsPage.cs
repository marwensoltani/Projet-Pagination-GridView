using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Projet_Pagination_GridView.Models
{
    public class ClientsPage
    {
        public int? nueroPage { get; set; }
        public StaticPagedList<Client> clients { get; set; }
    }
}
