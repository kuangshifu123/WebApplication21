using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication21.Service;
using WebApplication21.VM;

namespace WebApplication21.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PurchaseM> Get()
        {
            return new GetPrushesService().getPrushes();
        }
    }
}
