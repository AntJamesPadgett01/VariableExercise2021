using System;

namespace VariablesExercise2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Ralph";
            int userAge = 31;
            char nickName = 'C';
            bool isTall = true;
            double yearBorn = 1989;
            decimal userWeight = 210.3m;


            Console.WriteLine($"My friends name is {userName}, he is {userAge} years old. His nickname is {nickName} and it {isTall}, hes 6 foot. In {yearBorn} he was born and he weighs {userWeight} pounds");
        } 
    }
}
