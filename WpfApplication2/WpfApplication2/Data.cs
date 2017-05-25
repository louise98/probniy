using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Data
    {
        public static String newUserName;
        public static String newUserPassword;
        public static String newUserGoal;
        public static String newUserActivity;
        public static String newUserGender;
        public static DateTime newUserBirthday;
        public static int newUserHeight;
        public static double newUserCurrentWeight;
        public static double newUserGoalWeight;

        public static User currentUser;

        public static List<User> users = new List<User>();
        public static List<Meal> meals = new List<Meal>();
    }
}
