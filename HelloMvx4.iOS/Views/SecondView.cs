using System;

using UIKit;

using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace HelloMvx4.iOS
{
	public partial class SecondView : MvxViewController
	{
		public SecondView() : base("SecondView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<SecondView, Core.ViewModels.SecondViewModel>();
			set.Bind(FirstNameLabel).To(vm => vm.FirstName);
			set.Bind(LastNameLabel).To(vm => vm.LastName);
			set.Apply();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


