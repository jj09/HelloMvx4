using System;
using MvvmCross.Core.ViewModels;

namespace HelloMvx4.Core.ViewModels
{
	public class SecondViewModel : MvxViewModel
	{
		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public FirstViewModel FirstViewModel
		{
			get;
			set;
		}

		public void Init(SecondViewModelParams parameters)
		{
			FirstName = parameters.FirstName;
			LastName = parameters.LastName;
		}

		public IMvxCommand GoToFirstViewModel
		{
			get
			{
				return new MvxCommand(() =>	ShowViewModel<FirstViewModel>());
			}
		}
	}

	public class SecondViewModelParams
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}

