using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Adapters;

namespace GameProjectDemo.Concrete
{
    internal class ValidationCheckAdapter : IValidationCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            DateTime _dateOfBirth = gamer.DateOfBirth;
            if (gamer.NationalityNumber == "2101200048" && gamer.FirstName == "Soner" && gamer.LastName == "Abduramanov" && _dateOfBirth == new DateTime(2000, 01, 21)){ 
                return true; 
            }
            else { 
                return false; 
            }
        
        }
    }
}
