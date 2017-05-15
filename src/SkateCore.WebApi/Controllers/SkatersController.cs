using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SkateCore.Domain;
using SkateCore.Workflow.Interfaces;

namespace SkateCore.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SkatersController : Controller
    {
        private readonly ISkaterWorkflow workflow;

        public SkatersController(ISkaterWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public IList<Skater> Get()
        {
            return workflow.Get();
        }
    }
}