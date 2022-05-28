using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;





namespace GameProjectDemo.Concrete
{
    internal class GamerManager : BaseGamerManager
    {
        private IValidationCheckService _validationCheckService;
        public GamerManager(IValidationCheckService validationCheckService)
        {
            _validationCheckService = validationCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_validationCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Gamer is valid person.");
                base.Add(gamer);
            }    
            else
                Console.WriteLine( "Not a valid gamer.");
        }

        public override void Update(Gamer gamer)
        {
            base.Update(gamer);
        }

        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);
        }

    }
}
