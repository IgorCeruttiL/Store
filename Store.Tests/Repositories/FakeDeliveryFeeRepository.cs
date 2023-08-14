using Store.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests.Repositories
{
    public class FakeDeliveryFeeRepository : IdeliveryFeeRepository
    {
        public decimal Get(string zipCode)
        {
            if (zipCode == "123456")
                return 10;
            else if (zipCode == "122456")
                return 7;

            return 0;
        }
    }
}
