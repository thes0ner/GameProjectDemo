using System;
using GameProjectDemo.Concrete;
using GameProjectDemo.Adapters;
using GameProjectDemo.Entity;
namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamerManager = new GamerManager(new ValidationCheckAdapter());
            gamerManager.Add(new Gamer() { Id = 1, FirstName = "Soner", LastName = "Abduramanov", NationalityNumber = "2101200048", DateOfBirth = new DateTime(2000, 01, 21) });


            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Calculate(new Campaign() { Id = 1, Name = "WeeklyCampaign" , DiscountRate = 0.4 },new Order() { Id = 1 , UnitPrice = 40});





        }
    }
}
