using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;

namespace QuizApp.Droid.Views
{
    class MainView : Fragment
    {
        private RecyclerView _recycler;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var root = inflater.Inflate(Resource.Layout.MainView, container, false);

            _recycler = root.FindViewById<RecyclerView>(Resource.Id.MainView_recycler);

            return root;
        }
    }
}