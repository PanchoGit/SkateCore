﻿using SkateCore.Domain;
using System.Collections.Generic;

namespace SkateCore.Workflow.Interfaces
{
    public interface ISkaterWorkflow
    {
        IList<Skater> Get();
    }
}