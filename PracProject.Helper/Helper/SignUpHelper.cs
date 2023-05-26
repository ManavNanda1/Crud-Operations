using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Helper.Helper
{
    public class SignUpHelper
    {
        public Users AddUser (SignUpModel SignUpData)
        {
            try
            {

            Users Data = new Users();
            Data.ID = SignUpData.Id;
            Data.Username = SignUpData.Username;
            Data.Email = SignUpData.Email;
            Data.Password = SignUpData.Password;

            return Data;
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
