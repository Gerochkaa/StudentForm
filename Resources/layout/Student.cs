using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentForm
{
    public class Student
    {
        public static string Name { get; set; }
        public static string Lastname { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string FieldOfStudy { get; set; }
        public static string PhoneNumber { get; set; }

        public static string showDetails()
        {
            string details;
            details = "name: " + Name + "\n";
            details += "surname: " + Lastname + "\n";
            details += "email: " + Email + "\n";
            details += "password: " + Password + "\n";
            details += "field of study: " + FieldOfStudy + "\n";
            details += "phone number: " + PhoneNumber + "\n";
            return details;
        }
    }
}