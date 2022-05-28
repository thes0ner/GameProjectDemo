using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    internal interface IOrderService
    {
        void Calculate(Campaign campaign,Order order);

    }
}
