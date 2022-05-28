using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Order order)
        {
            double sum = campaign.DiscountRate * order.UnitPrice;
            Console.WriteLine($"Campaign Name: {campaign.Name} Campaign Price: {sum} ");
        }

        public void Delete(Campaign campaign , Order order)
        {
            Console.WriteLine("Campaign deleted.");
        }

        public void Update(Campaign campaign, Order order)
        {
            Console.WriteLine("Campaign updated.");
        }
    }
}
