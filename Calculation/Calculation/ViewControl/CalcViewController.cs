using System;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class CalcViewController : UIViewController
	{
		private UIButton _navCalc;

		CalculatorController calculatorController;

		public CalcViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "Calculation";

			SetUpNavCalcButton();

			_navCalc.TouchUpInside += NavToCalculator;
		}

		public void NavToCalculator(Object sender, EventArgs e)
		{
			calculatorController = new CalculatorController();
			this.NavigationController.PushViewController(calculatorController, true);
		}

		private void SetUpNavCalcButton()
		{
			var rect = new CGRect(20, 200, 280, 44);  			_navCalc = new UIButton(rect); 			_navCalc.SetTitle("Calculator Sample", UIControlState.Normal); 			_navCalc.SetTitleColor(UIColor.Black, UIControlState.Normal);  			_navCalc.Layer.BorderWidth = 1; 			_navCalc.Layer.CornerRadius = 5; 			_navCalc.Layer.BackgroundColor = UIColor.LightGray.CGColor;  			View.Add(_navCalc);
		}
	}
}