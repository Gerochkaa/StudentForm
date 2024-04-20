using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Java.Security.Cert;

namespace StudentForm
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class Activity1 : AppCompatActivity
    {
        public static string fullNameFile = Android.App.Application.Context.GetExternalFilesDir("").AbsolutePath + "Students.txt";
        StreamWriter streamWriter = new StreamWriter(fullNameFile, true);
        Button buttonNext, buttonSave, buttonPrevious;
        TextView textView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout1);
            
            Button buttonPrevious = FindViewById<Button>(Resource.Id.buttonPrevious);
            Button buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            Button buttonSave = FindViewById<Button>(Resource.Id.buttonSave);
            textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = Student.showDetails();

            

            if (!File.Exists(fullNameFile))
            {
                streamWriter.WriteLine("Students");
                streamWriter.WriteLine("----------------------");
            }

            buttonNext.Click += buttonNext_Clicked;
            buttonPrevious.Click += buttonPrevious_Clicked;
            buttonSave.Click += buttonSave_Clicked;
        }

        private void buttonPrevious_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        private void buttonNext_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(Activity2));
        }

        private void buttonSave_Clicked(object sender, EventArgs e)
        {
            string student = Student.showDetails();
            string[] studentProperties = student.Split('\n');
            
            using (streamWriter)
            {
                for (int i = 0; i < studentProperties.Length; i++)
            {
                streamWriter.WriteLine(studentProperties[i]);
            }
            streamWriter.WriteLine("----------------------");
            }
        }
    }
}