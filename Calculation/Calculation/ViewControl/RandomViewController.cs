using System;
using System.Linq;
using UIKit;

namespace Calculation
{
	public class RandomViewController : UIViewController
	{
		private static Random random = new Random();
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

		}

		public void SetUpTextRandom()
		{

		}
	}
}
