using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BranchAndChicken.api.DataAccess;
using BranchAndChicken.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BranchAndChicken.api.Controllers
{
    [Route("api/chickens")]
    [ApiController]
    public class ChickensController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Chicken>> GetAllChickens()
        {
            var repo = new ChickenRepository();
            return repo.GetAll();
        }
    }
}