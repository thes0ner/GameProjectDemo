using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    internal class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} Added.");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} Deleted.");
        }

        public  virtual void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} Updated");
        }
    }
}
