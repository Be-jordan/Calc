using System;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public partial class CalculatorController : UIViewController
	{
		private UITextField _number1;
		private UITextField _number2;

		private UIButton _plus;
		private UIButton _minus;
		private UIButton _multiply;
		private UIButton _divide;
		private UIButton _clear;

		private UILabel _result;

		private CGColor _buttonBackgroundColor = UIColor.DarkGray.CGColor;

		private const int _borderWidth = 1;
		private const int _cornerRadius = 3;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "Calculator";

			//view = new CalculatorView();
			//View = view;

			SetTextNum1();
			SetTextNum2();

			SetAdd();
			SetMinus();
			SetMultiply();
			SetDivide();
			SetClear();

			SetResult();

			_plus.TouchUpInside += AddCalc;
			_minus.TouchUpInside += MinusCalc;
			_multiply.TouchUpInside += MultiplyCalc;
			_divide.TouchUpInside += DivideCalc;
			_clear.TouchUpInside += Clear;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public void AddCalc(Object sender, EventArgs e)
		{
			var add = (Int32.Parse(_number1.Text) + Int32.Parse(_number2.Text));
			_result.Text = add.ToString();
		}

		public void MinusCalc(Object sender, EventArgs e)
		{
			var subtract = (Int32.Parse(_number1.Text) - Int32.Parse(_number2.Text));
			_result.Text = subtract.ToString();
		}

		public void MultiplyCalc(Object sender, EventArgs e)
		{
			var multiply = (Int32.Parse(_number1.Text) * Int32.Parse(_number2.Text));
			_result.Text = multiply.ToString();
		}

		public void DivideCalc(Object sender, EventArgs e)
		{
			var divide = divideToFloat();
			_result.Text = divide.ToString();
		}

		public void Clear(Object sender, EventArgs e)
		{
			_number1.Text = null;
			_number2.Text = null;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		private float divideToFloat()
		{
			Numbers number;

			number = new Numbers();

			var x = Convert.ToInt32(number.FirstNumber.ToString(_number1.Text));
			var y = Convert.ToInt32(number.SecondNumber.ToString(_number2.Text));

			float z = (float)x / (float)y;

			return z;
		}

		private void SetTextNum1()
		{
			var rect = new CGRect(10, 90, 300, 30);

			_number1 = new UITextField(rect);
			_number1.BorderStyle = UITextBorderStyle.Line;


			View.Add(_number1);
		}

		private void SetTextNum2()
		{
			var rect = new CGRect(10, 130, 300, 30);

			_number2 = new UITextField(rect);
			_number2.BorderStyle = UITextBorderStyle.Line;

			View.Add(_number2);
		}

		public void SetAdd()
		{
			var rect1 = new CGRect(230, 400, 75, 150);

			_plus = new UIButton(rect1);
			_plus.Layer.BorderWidth = 1;
			_plus.Layer.CornerRadius = 5;
			_plus.Layer.BackgroundColor = UIColor.Orange.CGColor;

			_plus.SetTitle("+", UIControlState.Normal);
			_plus.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.AddSubview(_plus);
		}

		public void SetupButtonBorder(UIButton btn)
		{
			btn.Layer.BorderWidth = _borderWidth;
			btn.Layer.BorderWidth = _cornerRadius;
			btn.Layer.BorderColor = _buttonBackgroundColor;
		}

		private void SetMinus()
		{
			var rect = new CGRect(230, 300, 75, 100);

			_minus = new UIButton(rect);
			_minus.Layer.BorderWidth = 1;
			_minus.Layer.CornerRadius = 5;
			_minus.Layer.BackgroundColor = UIColor.Orange.CGColor;

			_minus.SetTitle("-", UIControlState.Normal);
			_minus.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.Add(_minus);
		}

		private void SetMultiply()
		{
			var rect = new CGRect(155, 425, 75, 125);

			_multiply = new UIButton(rect);
			_multiply.SetTitle("*", UIControlState.Normal);
			_multiply.SetTitleColor(UIColor.Black, UIControlState.Normal);

			_multiply.Layer.BorderWidth = 1;
			_multiply.Layer.CornerRadius = 5;
			_multiply.Layer.BackgroundColor = UIColor.Orange.CGColor;

			View.Add(_multiply);
		}

		private void SetDivide()
		{
			var rect = new CGRect(155, 300, 75, 125);

			_divide = new UIButton(rect);
			_divide.SetTitle("/", UIControlState.Normal);
			_divide.SetTitleColor(UIColor.Black, UIControlState.Normal);

			_divide.Layer.BorderWidth = 1;
			_divide.Layer.CornerRadius = 5;
			_divide.Layer.BackgroundColor = UIColor.Orange.CGColor;

			View.Add(_divide);
		}

		private void SetClear()
		{
			var rect = new CGRect(155, 225, 150, 75);

			_clear = new UIButton(rect);
			_clear.SetTitle("Clear", UIControlState.Normal);
			_clear.SetTitleColor(UIColor.Black, UIControlState.Normal);

			_clear.Layer.BorderWidth = 1;
			_clear.Layer.CornerRadius = 5;
			_clear.Layer.BackgroundColor = UIColor.Orange.CGColor;

			View.Add(_clear);
		}

		private void SetResult()
		{
			var rect = new CGRect(10, 190, 100, 30);

			_result = new UILabel(rect);

			_result.TextColor = UIColor.Black;
			_result.Text = "hello";


			View.Add(_result);
		}
	}
}

