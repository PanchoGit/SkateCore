using System;
using SkateCore.Workflow.Interfaces;

namespace SkateCore.Workflow
{
    public class SkaterWorkflow : ISkaterWorkflow
    {
        public string Get()
        {
            return "Skaters";
        }
    }
}
