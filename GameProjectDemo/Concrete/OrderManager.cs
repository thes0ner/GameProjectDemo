using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    internal class OrderManager : IOrderService
    {
        private ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }


        public void Calculate(Campaign campaign, Order order)
        {
            _campaignService.Add(campaign, order);
        }
    }
}
