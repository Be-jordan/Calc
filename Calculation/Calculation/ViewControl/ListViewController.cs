using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace Calculation
{
	public class ListViewController : UIViewController
	{
		private List<string> random = new List<string>();

		private List<int> intList = new List<int>();


		private UIButton _listButton;
		private UIButton _listIntButton;
		private UIButton _listClassButton;

		private UITextField _listStringView;
		private UITextField _listIntView;
		private UITextField _listClassView;



		public ListViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;
			Title = "List samples";

			SetListStringButton();
			SetListClassButton();
			SetListIntButton();
			SetListIntView();
			SetListStringView();
			SetListClassView();

			_listButton.TouchUpInside += AddStringContent;
			_listIntButton.TouchUpInside += AddIntContent;
			_listClassButton.TouchUpInside += AddClassContent;
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

			_listStringView.Text = string.Join(Environment.NewLine, random);
		}

		private void AddClassContent(object sender, EventArgs e)
		{
			List<Name> list = new List<Name>();

			list.Add(new Name() { firstName = "john" });

			_listClassView.Text = string.Join(Environment.NewLine, list);
		}



		private void AddIntContent(Object sender, EventArgs e)
		{
			intList.Add(1);
			intList.Add(2);
			intList.Add(3);
			intList.Add(4);
			intList.Add(5);

			_listIntView.Text = string.Join(Environment.NewLine, intList);
		}

		public void SetListClassButton()
		{
			var rect = new CGRect(10, 450, 300, 30);

			_listClassButton = new UIButton(rect);
			_listClassButton.SetTitle("Basic list on label", UIControlState.Normal);
			_listClassButton.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_listClassButton.Layer.CornerRadius = 5;

			View.Add(_listClassButton);
		}

		public void SetListStringButton()
		{
			var rect = new CGRect(10, 400, 300, 30);

			_listButton = new UIButton(rect);
			_listButton.SetTitle("Basic list on label", UIControlState.Normal);
			_listButton.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_listButton.Layer.CornerRadius = 5;

			View.Add(_listButton);
		}

		public void SetListIntButton()
		{
			var rect = new CGRect(10, 350, 300, 40);

			_listIntButton = new UIButton(rect);
			_listIntButton.SetTitle("Hello", UIControlState.Normal);
			_listIntButton.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_listIntButton.Layer.CornerRadius = 5;

			View.Add(_listIntButton);
		}

		public void SetListIntView()
		{
			var rect = new CGRect(10, 130, 300, 30);

			_listIntView = new UITextField(rect);
			_listIntView.Text = "Hello";
			_listIntView.TextColor = UIColor.Black;
			_listIntView.BorderStyle = UITextBorderStyle.Line;
			_listIntView.Layer.BorderColor = UIColor.Black.CGColor;

			View.Add(_listIntView);
		}

		public void SetListStringView()
		{
			var rect = new CGRect(10, 90, 300, 30);

			_listStringView = new UITextField(rect);
			_listStringView.Text = "Hello";
			_listStringView.TextColor = UIColor.Black;
			_listStringView.BorderStyle = UITextBorderStyle.Line;
			_listStringView.Layer.BorderColor = UIColor.Black.CGColor;

			View.Add(_listStringView);
		}

		public void SetListClassView()
		{
			var rect = new CGRect(10, 170, 300, 30);

			_listClassView = new UITextField(rect);
			_listClassView.Text = "Hello";
			_listClassView.TextColor = UIColor.Black;
			_listClassView.BorderStyle = UITextBorderStyle.Line;
			_listClassView.Layer.BorderColor = UIColor.Black.CGColor;

			View.Add(_listClassView);
		}


	}
}
