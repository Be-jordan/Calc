using System;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public partial class ViewController : UIViewController
	{
		public UITextField number1;
		public UITextField number2;

		public UIButton Plus;
		public UIButton Minus;
		public UIButton Multiply;
		public UIButton Divide;

		public UILabel result;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SetTextNum1();
			SetTextNum2();

			SetAdd();
			SetMinus();
			SetMultiply();
			SetDivide();

			SetResult();

			Plus.TouchUpInside += add_calc;
			Minus.TouchUpInside += minus_calc;
			Multiply.TouchUpInside += multiply_calc;
			Divide.TouchUpInside += divide_calc;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public void add_calc(Object sender, EventArgs e)
		{
			int plus = (Int32.Parse(number1.Text) + Int32.Parse(number2.Text));
			result.Text = plus.ToString();
		}

		public void minus_calc(Object sender, EventArgs e)
		{
			int subtract = (Int32.Parse(number1.Text) - Int32.Parse(number2.Text));
			result.Text = subtract.ToString();
		}

		public void multiply_calc(Object sender, EventArgs e)
		{
			int multiply = (Int32.Parse(number1.Text) * Int32.Parse(number2.Text));
			result.Text = multiply.ToString();
		}

		public void divide_calc(Object sender, EventArgs e)
		{
			int divide = (Int32.Parse(number1.Text) / Int32.Parse(number2.Text));
			result.Text = divide.ToString();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
		private void SetTextNum1()
		{
			var rect = new CGRect(10, 50, 50, 30);

			number1 = new UITextField(rect);
			number1.BorderStyle = UITextBorderStyle.Line;

			View.Add(number1);
		}

		private void SetTextNum2()
		{
			var rect = new CGRect(10, 90, 50, 30);

			number2 = new UITextField(rect);
			number2.BorderStyle = UITextBorderStyle.Line;

			View.Add(number2);
		}

		private void SetAdd()
		{
			var rect = new CGRect(10, 150, 20, 30);

			Plus = new UIButton(rect);
			Plus.SetTitle("+", UIControlState.Normal);
			Plus.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.Add(Plus);
		}

		private void SetMinus()
		{
			var rect = new CGRect(50, 150, 20, 30);

			Minus = new UIButton(rect);
			Minus.SetTitle("-", UIControlState.Normal);
			Minus.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.Add(Minus);
		}

		private void SetMultiply()
		{
			var rect = new CGRect(90, 150, 20, 30);

			Multiply = new UIButton(rect);
			Multiply.SetTitle("*", UIControlState.Normal);
			Multiply.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.Add(Multiply);
		}

		private void SetDivide()
		{
			var rect = new CGRect(130, 150, 20, 30);

			Divide = new UIButton(rect);
			Divide.SetTitle("/", UIControlState.Normal);
			Divide.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.Add(Divide);
		}

		private void SetResult()
		{
			var rect = new CGRect(10, 190, 100, 30);

			result = new UILabel(rect);

			result.TextColor = UIColor.Black;
			result.Text = "hello";


			View.Add(result);
		}
	}
}
