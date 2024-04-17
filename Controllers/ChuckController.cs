using Microsoft.AspNetCore.Mvc;
using RefitExample.Interfaces;
using RefitExample.Models;

namespace RefitExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChuckController : ControllerBase
    {

        private readonly IChuckApi _clientChuck; 

        public ChuckController(IChuckApi clientChuck)
        {
            _clientChuck = clientChuck;
        }

        [HttpGet]
        public async Task<ChuckNorrisModel> GetAdviceAsync()
        {
            return await _clientChuck.GetAdvice();
        }
    }
}
