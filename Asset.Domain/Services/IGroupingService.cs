﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Domain.Services
{
    public interface IGroupingService
    {
        IEnumerable<T> GetAll<T>(List<T>Assets,string groupItem) where T : class;
    }
}
