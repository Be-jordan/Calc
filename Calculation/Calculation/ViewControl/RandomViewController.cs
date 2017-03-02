using System;
using System.Linq;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class RandomViewController : UIViewController
	{
		private static Random random = new Random();

		private string ran = RandomString(12);

		private UILabel _randomLabel;
		private UIButton _randomButton;
		private UIButton _verifyButton;
		private UITextField _verifyTextField;
		private UILabel _verify;

		private static string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";

			return new string(Enumerable.Repeat(chars, length)
							  .Select(s => s[random.Next(s.Length)]).ToArray());

		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "Random string generator";

			SetUpTextRandom();
			SetUpTextButton();
			SetUpVerifyLabel();
			SetUpVerifyText();
			SetUpVerifyButton();

			_randomButton.TouchUpInside += Randomise;
			_verifyButton.TouchUpInside += verify;
		}

		public void Randomise(Object sender, EventArgs e)
		{
			_randomLabel.Text = ran;
		}

		public void verify(Object sender, EventArgs e)
		{
			string ver = _randomLabel.Text.ToString();

			if (_verifyTextField.Text.Equals(_randomLabel.Text, StringComparison.CurrentCultureIgnoreCase))
			{
				_verify.Text = "Verified";
			}
			else
			{
				_verify.Text = "wrong code";
			}
		}

		public void SetUpTextButton()
		{
			var rect = new CGRect(10, 400, 300, 30);

			_randomButton = new UIButton(rect);

			_randomButton.SetTitle("Randomise", UIControlState.Normal);
			_randomButton.Layer.BackgroundColor = UIColor.DarkGray.CGColor;
			_randomButton.Layer.BorderWidth = 1;
			_randomButton.Layer.CornerRadius = 5;

			View.Add(_randomButton);
		}

		public void SetUpVerifyButton()
		{
			var rect = new CGRect(10, 650, 300, 30);

			_verifyButton = new UIButton(rect);

			_verifyButton.SetTitle("Verify", UIControlState.Normal);
			_verifyButton.Layer.BackgroundColor = UIColor.DarkGray.CGColor;
			_verifyButton.Layer.BorderWidth = 1;
			_verifyButton.Layer.CornerRadius = 5;

			View.Add(_verifyButton);
		}

		public void SetUpTextRandom()
		{
			var rect = new CGRect(10, 300, 300, 30);

			_randomLabel = new UILabel(rect);
			_randomLabel.Text = " ";
			_randomLabel.TextColor = UIColor.Black;
			_randomLabel.Layer.BorderWidth = 1;
			_randomLabel.Layer.CornerRadius = 5;

			View.Add(_randomLabel);
		}

		public void SetUpVerifyLabel()
		{
			var rect = new CGRect(10, 450, 300, 30);

			_verify = new UILabel(rect);
			_verify.Text = " ";
			_verify.TextColor = UIColor.Black;
			_verify.Layer.BorderWidth = 1;
			_verify.Layer.CornerRadius = 5;

			View.Add(_verify);
		}

		public void SetUpVerifyText()
		{
			var rect = new CGRect(10, 550, 300, 30);

			_verifyTextField = new UITextField(rect);
			_verifyTextField.Text = null;
			_verifyTextField.TextColor = UIColor.Black;
			_verifyTextField.Layer.BorderWidth = 1;
			_verifyTextField.Layer.CornerRadius = 5;

			View.Add(_verifyTextField);
		}
	}
}
