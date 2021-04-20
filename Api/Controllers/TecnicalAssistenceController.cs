using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace TecnicalAssistence.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/tecnical-assistence")]
    public class TecnicalAssistenceController : ControllerBase
    {
        
        private readonly ILogger<TecnicalAssistenceController> _logger;

        public TecnicalAssistenceController(ILogger<TecnicalAssistenceController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet]
        public List<Dto.TecnicalAssistence> Get()
        {
            return null;
        }
    }
}
