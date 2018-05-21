using Android.App;
using Android.OS;
using Android.Support.V4.App;
using QuizApp.Droid.Views;

namespace QuizApp.Droid
{
    [Activity(Label = "QuizApp.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : FragmentActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var tansaction = FragmentManager.BeginTransaction();
            var fragment = new MainView();
            tansaction.Replace(Resource.Id.container, fragment);
        }
    }
}

