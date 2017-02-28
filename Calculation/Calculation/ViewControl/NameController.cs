using System;
using UIKit;

namespace Calculation
{
	public class NameController : UIViewController
	{

		private UITextField _foreName;
		private UITextField _surName;

		public NameController()
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "Combine Name";
		}
	}
}
