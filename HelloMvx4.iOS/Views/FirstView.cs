using System.Windows.Input;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;

namespace HelloMvx4.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
			set.Bind(FirstNameTextField).To(vm => vm.FirstName);
			set.Bind(LastNameTextField).To(vm => vm.LastName);

			set.Bind(navigateButton).To(vm => vm.GoToSecondViewModel);
            set.Apply();

			navigateButton.TouchUpInside += (sender, e) =>
			{
				
			};
        }
    }
}
