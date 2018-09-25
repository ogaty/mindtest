using System;
using Android.OS;
using Android.Views;

namespace kuruapp.Droid
{
    public class TrainingFragment : Android.Support.V4.App.Fragment, IFragmentVisible
    {
        public static TrainingFragment NewInstance() =>
            new TrainingFragment { Arguments = new Bundle() };
   
        public TrainingFragment()
        {
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_browse, container, false);
            return view;
        }

        public void BecameVisible()
        {
        }
    }
}
