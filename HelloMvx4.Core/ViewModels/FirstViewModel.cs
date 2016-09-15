using MvvmCross.Core.ViewModels;

namespace HelloMvx4.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
		public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

		private string _firstName = "Jacob";
		public string FirstName 
		{
			get { return _firstName; }
			set { SetProperty(ref _firstName, value); }
		}

		private string _lastName = "Jed";

		public string LastName
		{
			get { return _lastName; }
			set { SetProperty(ref _lastName, value); }
		}

		public IMvxCommand GoToSecondViewModel
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<SecondViewModel>(new SecondViewModelParams{ FirstName = this.FirstName, LastName = this.LastName });
				});
			}
		}
			
    }
}
