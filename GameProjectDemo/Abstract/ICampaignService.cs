using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    internal interface ICampaignService 
    {
        void Add(Campaign campaign, Order order);
        void Update(Campaign campaign, Order order);
        void Delete(Campaign campaign, Order order);
    }
}
