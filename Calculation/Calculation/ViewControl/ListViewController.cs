using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class ListViewController : UIViewController
	{
		private List<string> random = new List<string>();

		private UIButton _listButton;
		private UITextField _listView;

		public ListViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "List samples";

			SetListStringView();
			SetListStringButton();

			_listButton.TouchUpInside += AddStringContent;
		}

		private void AddStringContent(Object sender, EventArgs e)
		{
			random.Add("Hi");
			random.Add("there");
			random.Add(",");
			random.Add("how");
			random.Add("are");
			random.Add("you");
			random.Add("?");

			_listView.Text = string.Join(Environment.NewLine, random);
		}

		public void SetListStringButton()
		{
			var rect = new CGRect(10, 300, 300, 30);

			_listButton = new UIButton(rect);
			_listButton.SetTitle("Basic list on label", UIControlState.Normal);
			_listButton.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_listButton.Layer.CornerRadius = 5;

			View.Add(_listButton);
		}

		public void SetListStringView()
		{
			var rect = new CGRect(10, 90, 300, 30);

			_listView = new UITextField(rect);
			_listView.Text = "Hello";
			_listView.TextColor = UIColor.Black;
			_listView.BorderStyle = UITextBorderStyle.Line;
			_listView.Layer.BorderColor = UIColor.Black.CGColor;

			View.Add(_listView);
		}


	}
}
