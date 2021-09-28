using Dapper;
using Microsoft.Data.SqlClient;
using Projet_Pagination_GridView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Pagination_GridView.Repository
{
    public class ClientService : IClient
    {
        public int NombreClient()
        {
            using (SqlConnection con= new SqlConnection(GestionnaireConnexionBD.cc))
            {
                var param = new DynamicParameters();
                var data = con.Query<int>("PS_NombreClients", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return data;
            }
        }

        public List<Client> ClientsPage(int? numeroPage, int nombreClientsParPage)
        {
            using (SqlConnection con = new SqlConnection(GestionnaireConnexionBD.cc))
            {
                var param = new DynamicParameters();
                param.Add("@numeroPage", numeroPage);
                param.Add("@nombreClientsParPage", nombreClientsParPage);
                var data = con.Query<Client>("PS_ClientsPage", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return data;
            }
        }

       
    }
}
