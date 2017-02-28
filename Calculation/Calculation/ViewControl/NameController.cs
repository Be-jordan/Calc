using System;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class NameController : UIViewController
	{

		private string foreName;
		private string surName;
		private string middleName;

		private UITextField _foreName;
		private UITextField _surName;

		private UIButton _combine;

		private UILabel _finalName;

		public string ForeName { get { return foreName; } set { foreName = value; } }

		public string SurName { get { return surName; } set { surName = value; } }

		public NameController()
		{

		}

		public NameController(string fName, string sName, string mName = "Rae")
		{
			foreName = fName;
			surName = sName;
			middleName = mName;
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "Combine Name";

			SetForeName();
			SetSurName();
			SetFinalName();
			SetNameButton();

			_combine.TouchUpInside += CombineName;

		}

		public void SetNameButton()
		{
			var rect1 = new CGRect(230, 400, 75, 150);

			_combine = new UIButton(rect1);
			_combine.Layer.BorderWidth = 1;
			_combine.Layer.CornerRadius = 5;
			_combine.Layer.BackgroundColor = UIColor.Orange.CGColor;

			_combine.SetTitle("+", UIControlState.Normal);
			_combine.SetTitleColor(UIColor.Black, UIControlState.Normal);

			View.AddSubview(_combine);
		}

		public void SetForeName()
		{
			var rect = new CGRect(10, 90, 300, 30);

			_foreName = new UITextField(rect);
			_foreName.BorderStyle = UITextBorderStyle.Line;

			View.Add(_foreName);
		}

		public void SetSurName()
		{
			var rect = new CGRect(10, 130, 300, 30);

			_surName = new UITextField(rect);
			_surName.BorderStyle = UITextBorderStyle.Line;

			View.Add(_surName);
		}

		private void SetFinalName()
		{
			var rect = new CGRect(10, 170, 300, 30);

			_finalName = new UILabel(rect);
			_finalName.TextColor = UIColor.Black;
			_finalName.Text = "hello";

			View.Add(_finalName);
		}

		public string GetName()
		{
			string x = foreName + " " + middleName + " " + surName;
			return x;
		}

		public void CombineName(Object sender, EventArgs e)
		{
			NameController x = new NameController(_foreName.Text, _surName.Text);

			_finalName.Text = string.Format("{0}", x.GetName());

		}
	}
}
