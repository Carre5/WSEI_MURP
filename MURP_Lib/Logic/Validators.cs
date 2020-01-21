using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Logic
{
    public static class Validators
    {
        public static bool EmailValid(string email)
        {
            bool result = false;
            if (email == "")
            {
                throw new ArgumentException();
            }

            if (email != null && email.Contains("@"))
            {
                string[] emailSeparated = email.Split("@");
                result = emailSeparated[1].Contains(".") ? true : false;
            }
            return result;
        }

        public static bool CarRegistrationNumberValid(string registrationNumber)
        {
            bool result = false;
            if (registrationNumber == "")
            {
                throw new ArgumentException();
            }

            if (registrationNumber.Contains(" "))
            {
                string[] temp = registrationNumber.Split(" ");
                result = temp[0].Length == 3 ? true : false;
            }

            return result;
        }
    }
}
