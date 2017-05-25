using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class HelperFunctions
    {
        public static bool validateUsername(String name)
        {
            if (name.Length < 3)
                return false;
            foreach(char c in name) {
                if( !Char.IsLetterOrDigit(c) )
                {
                    return false;
                }
            }
            return true;
        }

        public static bool validatePassword(String password)
        {
            if(password.Length < 8)
            {
                return false;
            }
            return true;
        }

        public static bool validateHeight(int height)
        {
            if(height < 150 || height > 220)
            {
                return false;
            }
            return true;
        }

        public static bool validateWeight(double weight)
        {
            if(weight < 40 || weight > 150)
            {
                return false;
            }
            return true;
        }

        public static void signUpNewUser()
        {
            User newUser = new WpfApplication2.User(
                Data.newUserName,
                Data.newUserPassword,
                Data.newUserGoal,
                Data.newUserActivity,
                Data.newUserGender,
                Data.newUserBirthday,
                Data.newUserHeight,
                Data.newUserCurrentWeight,
                Data.newUserGoalWeight);
            // DB INTERACTION - INSERT NEW USER INTO TABLE
            ///
            ////
            Data.users.Add(newUser);
            HelperFunctions.serUsers();
            /////
            //////
            ///////
            ////////

            Data.currentUser = newUser;
        }
        
        public static void serUsers()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\users.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
             formatter.Serialize(stream, Data.users);
            stream.Close();
            stream = new FileStream(@"D:\meals.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Data.meals);
            stream.Close();
        }

        public static void deserUsers()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\users.bin",
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            Data.users = (List<User>)formatter.Deserialize(stream);
            stream.Close();
            stream = new FileStream(@"D:\meals.bin",
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            Data.meals = (List<Meal>)formatter.Deserialize(stream);
            stream.Close();
        }

    }
}
