
using System.Collections.Generic;
using CounterApi.Core.Interfaces;
using CounterApi.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CounterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUserRepository _sessionRepository;

        public ValuesController(IUserRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<int> Get()
        {
            return _sessionRepository.GetUsersCount();
        }



        // POST api/values
        [HttpPost]
        public void Post()
        {
            var user = new User();
            _sessionRepository.Add(new Core.Models.User { Name = "Mj" });
            _sessionRepository.Update();

            var x = _sessionRepository.GetUsersCount();
        }        
    }
}
