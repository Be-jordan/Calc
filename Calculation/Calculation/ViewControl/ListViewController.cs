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
		private UILabel _listView;

		public ListViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "List samples";

			SetListView();
			SetListButton();

			_listButton.TouchUpInside += AddContent;
		}

		public List<string> SetList()
		{
			random.Add("Hi");
			random.Add("there");
			random.Add(",");
			random.Add("how");
			random.Add("are");
			random.Add("you");
			random.Add("?");

			return random;
		}

		private void AddContent(Object sender, EventArgs e)
		{
			string[] add = new string[4];
			add[0] = (" ");
			add[1] = (" ");
			add[2] = (" ");
			add[3] = (" ");

			random.AddRange(add);

			foreach (string i in random)
			{
				_listView.Text = string.Format(i, UIControlState.Normal);
			}
		}

		public void SetListButton()
		{
			var rect = new CGRect(10, 150, 300, 30);

			_listButton = new UIButton(rect);
			_listButton.SetTitle("Add content", UIControlState.Normal);
			_listButton.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_listButton.Layer.CornerRadius = 5;

			View.Add(_listButton);
		}

		public void SetListView()
		{
			var rect = new CGRect(10, 90, 300, 30);

			_listView = new UILabel(rect);
			_listView.Text = "Hello";
			_listView.TextColor = UIColor.Black;

			View.Add(_listView);
		}

		public class RandomString
		{
			public string random { get; set; }
		}

	}
}
