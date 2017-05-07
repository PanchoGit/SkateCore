using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkateCore.Workflow;

namespace SkateCore.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Skaters")]
    public class SkatersController : Controller
    {
        public string Get()
        {
            return new SkaterWorkflow().Get();
        }
    }
}