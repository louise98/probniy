using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    [Serializable()]
    enum Goal
    {
        lose, maintain, gain
    }
    [Serializable()]
    enum ActivityLevel
    {
        veryActive, active, lightlyActive, notVeryActive
    }
    [Serializable()]
    enum Gender
    {
        male, female
    }
    [Serializable()]
    class User
    {
        String name;
        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        String password;
        Goal goal;
        public Goal _goal
        {
            get
            {
                return this.goal;
            }
        }
        ActivityLevel activity;
        Gender gender;
        public Gender _gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
        DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                this.birthday = value;
            }
        }
        int height;
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        double currentWeight;
        double goalWeight;

        public User(String name, String password, String goal, String activity, String gender, DateTime birthday,
            int height, double currentWeight, double goalWeight)
        {
            this.name = name;
            this.password = password;
            switch(goal) {
                case "lose":
                    this.goal = Goal.lose;
                    break;
                case "maintain":
                    this.goal = Goal.maintain;
                    break;
                case "gain":
                    this.goal = Goal.gain;
                    break;
            }
            switch (activity)
            {
                case "veryActive":
                    this.activity = ActivityLevel.veryActive;
                    break;
                case "active":
                    this.activity = ActivityLevel.active;
                    break;
                case "lightlyActive":
                    this.activity = ActivityLevel.lightlyActive;
                    break;
                case "notVeryActive":
                    this.activity = ActivityLevel.notVeryActive;
                    break;
            }
            switch (gender)
            {
                case "male":
                    this.gender = Gender.male;
                    break;
                case "female":
                    this.gender = Gender.female;
                    break;
            }
            this.birthday = birthday;
            this.height = height;
            this.currentWeight = currentWeight;
            this.goalWeight = goalWeight;
        }

        public bool shouldLogin(String withPassword)
        {
            return this.password == withPassword;
        }

        public List<Meal> history = new List<Meal>();
        
    }
}
