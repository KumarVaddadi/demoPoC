using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoPoC.Models;
using demoPoC.RestClients;

namespace demoPoC.Services
{
    public class CarServices
    {
        public async Task<List<Cars>> GetCarsAsync(string uri)
        {
            RestClient<Cars> restClient = new RestClient<Cars>();
            var CarsList = await restClient.GetAsync(uri);
            return CarsList;
        }

        public async Task PostCarsAsync(Cars Cars, string uri)
        {
            RestClient<Cars> restClient = new RestClient<Cars>();
            var teamsList = await restClient.PostAsync(Cars, uri);
        }

        public async Task PutCarsAsync(int id, Cars Cars, string uri)
        {
            RestClient<Cars> restClient = new RestClient<Cars>();
            var teamsList = await restClient.PutAsync(id, Cars, uri);
        }

        public async Task DeleteCarsAsync(int id, Cars Cars, string uri)
        {
            RestClient<Cars> restClient = new RestClient<Cars>();
            var teamsList = await restClient.DeleteAsync(id, Cars, uri);
        }
    }
}
