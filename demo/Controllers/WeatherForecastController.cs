using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDenemeRepo _denemeRepo;
        public WeatherForecastController(IDenemeRepo denemeRepository)
        {
            _denemeRepo = denemeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<deneme>> GetCustomers()
        {
            return await _denemeRepo.GetAllCustomers();
        }
    }
}
