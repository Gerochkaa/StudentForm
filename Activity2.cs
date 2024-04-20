using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentForm
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class Activity2 : AppCompatActivity
    {

        Button openbtn, closebtn;
        ScrollView scrollView;
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout2);
            closebtn = FindViewById<Button>(Resource.Id.closeFileButton);
            openbtn = FindViewById<Button>(Resource.Id.openFileButton);
            scrollView = FindViewById<ScrollView>(Resource.Id.scrollView1);
            textView = FindViewById<TextView>(Resource.Id.textView1);
            openbtn.Click += openbtn_click;
            closebtn.Click += closebtn_click;   
        }
        private void openbtn_click(object sender, System.EventArgs e)
        {
            StreamReader sr = File.OpenText(Activity1.fullNameFile);
            string s = "";
            string entireText = "";

            while ((s = sr.ReadLine()) != null)
            {
                entireText += s + "\n";
            }
            sr.Close();
            scrollView.Enabled = true;
            textView.Text = entireText;
        }
        private void closebtn_click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}