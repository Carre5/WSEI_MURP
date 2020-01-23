using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Logic
{
    public class Validators
    {
        public bool EmailValid(string email)
        {
            bool result = false;
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException();
            }

            if (email != null && email.Contains("@"))
            {
                string[] emailSeparated = email.Split("@");
                result = emailSeparated[1].Contains(".") ? true : false;
            }
            return result;
        }

        public bool CarRegistrationNumberValid(string registrationNumber)
        {
            bool result = false;
            if (registrationNumber == "")
            {
                throw new ArgumentException();
            }

            if (registrationNumber.Contains("KR"))
            {
                result = true;
            }

            return result;
        }
    }
}
