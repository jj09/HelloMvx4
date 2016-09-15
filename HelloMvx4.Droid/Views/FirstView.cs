using Android.App;
using Android.OS;
using Android.Widget;
using HelloMvx4.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Views;

namespace HelloMvx4.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
		}
    }
}
