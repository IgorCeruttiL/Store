﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IdeliveryFeeRepository
    {
        decimal Get(string zipCode);
    }
}
