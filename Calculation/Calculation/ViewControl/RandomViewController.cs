using System;
using System.Linq;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class RandomViewController : UIViewController
	{
		private static Random random = new Random();

		private UILabel _randomLabel;
		private UIButton _randomButton;

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

			_randomButton.TouchUpInside += Randomise;

		}

		public void Randomise(Object sender, EventArgs e)
		{
			string ran = RandomString(12);

			_randomLabel.Text = ran;
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
	}
}
