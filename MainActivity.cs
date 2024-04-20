using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace StudentForm
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText nameField, lastnameField, emailField, passwordField, studyFieldField, phoneField;
        Button submitButton; 
        static bool isFormCompleted = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout3);


            nameField = FindViewById<EditText>(Resource.Id.nameField);
            lastnameField = FindViewById<EditText>(Resource.Id.lastnameField);
            passwordField = FindViewById<EditText>(Resource.Id.passwordField);
            studyFieldField = FindViewById<EditText>(Resource.Id.studyFieldField);
            phoneField = FindViewById<EditText>(Resource.Id.phoneField);
            submitButton = FindViewById<Button>(Resource.Id.submitButton);
            submitButton.Click += SubmitButton_Click;

            void NewMethod()
            {
                emailField = FindViewById<EditText>(Resource.Id.emailField);
            }
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            Student.Name = nameField.Text;
            Student.Lastname = lastnameField.Text;
            Student.Email = emailField.Text;
            Student.Password = passwordField.Text;
            Student.PhoneNumber = phoneField.Text;  
            Student.FieldOfStudy = studyFieldField.Text;
            StartActivity(typeof(Activity1));
        }

    }
}