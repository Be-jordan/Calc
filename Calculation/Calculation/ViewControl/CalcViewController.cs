using System;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class CalcViewController : UIViewController
	{
		private UIButton _navToCalc;
		private UIButton _navToName;

		CalculatorController calculatorController;

		NameController nameController;

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

			_navToCalc.TouchUpInside += NavToCalculator;
			_navToName.TouchUpInside += NavToName;
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
	}
}