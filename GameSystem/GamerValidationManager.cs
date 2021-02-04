using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class GamerValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (
                gamer.ID == 1 &&
                gamer.FirstName == "Fikret" &&
                gamer.LastName == "Gözütok" &&
                gamer.BirthYear == 2000 &&
                gamer.IdentityNumber == "12345"
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
