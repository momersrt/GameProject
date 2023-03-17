
using System;
namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "Ömer" && gamer.LastName == "Sert" && gamer.NationalityId == "123456")
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

