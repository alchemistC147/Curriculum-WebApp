using System;
using AppTypes;
using Curriculum_WebApp.Models;

namespace Helper
{

    public abstract class TypeConverter
    {

        public static User UserModel_To_User(UserModel userModel)
        {
            User u = new User();
            u.password = userModel.password;
            u.userName = userModel.userName;
            


            return u;
        }


    }
}

