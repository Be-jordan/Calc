using System;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class CalcViewController : UIViewController
	{
		private UIButton _navToCalc;
		private UIButton _navToName;
		private UIButton _navToList;

		CalculatorController calculatorController;

		NameController nameController;

		ListViewController listController;

		public CalcViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "Calculation";

			SetUpNavCalcButton();
			SetUpNavNameButton();
			SetUpNavListButton();

			_navToCalc.TouchUpInside += NavToCalculator;
			_navToName.TouchUpInside += NavToName;
			_navToList.TouchUpInside += NavToList;
		}

		public void NavToName(object sender, EventArgs e)
		{
			nameController = new NameController();
			this.NavigationController.PushViewController(nameController, true);
		}

		public void NavToCalculator(Object sender, EventArgs e)
		{
			calculatorController = new CalculatorController();
			this.NavigationController.PushViewController(calculatorController, true);
		}

		public void NavToList(Object sender, EventArgs e)
		{
			listController = new ListViewController();
			this.NavigationController.PushViewController(listController, true);
		}

		private void SetUpNavCalcButton()
		{
			var rect = new CGRect(20, 200, 280, 44);  			_navToCalc = new UIButton(rect); 			_navToCalc.SetTitle("Calculator Sample", UIControlState.Normal); 			_navToCalc.SetTitleColor(UIColor.Black, UIControlState.Normal);  			_navToCalc.Layer.BorderWidth = 1; 			_navToCalc.Layer.CornerRadius = 5; 			_navToCalc.Layer.BackgroundColor = UIColor.LightGray.CGColor;  			View.Add(_navToCalc);
		}

		private void SetUpNavNameButton()
		{
			var rect = new CGRect(20, 250, 280, 44);

			_navToName = new UIButton(rect);
			_navToName.SetTitle("Combine Name Sample", UIControlState.Normal);
			_navToName.SetTitleColor(UIColor.Black, UIControlState.Normal);

			_navToName.Layer.BorderWidth = 1;
			_navToName.Layer.CornerRadius = 5;
			_navToName.Layer.BackgroundColor = UIColor.LightGray.CGColor;

			View.Add(_navToName);
		}

		private void SetUpNavListButton()
		{
			var rect = new CGRect(20, 300, 280, 44);

			_navToList = new UIButton(rect);
			_navToList.SetTitle("List Sample", UIControlState.Normal);
			_navToList.SetTitleColor(UIColor.Black, UIControlState.Normal);

			_navToList.Layer.BorderWidth = 1;
			_navToList.Layer.CornerRadius = 5;
			_navToList.Layer.BackgroundColor = UIColor.LightGray.CGColor;

			View.Add(_navToList);
		}
	}
}