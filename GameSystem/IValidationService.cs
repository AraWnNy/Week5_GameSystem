using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}
