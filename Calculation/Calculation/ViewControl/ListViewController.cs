using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
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
		private UIButton _listTableStringButton;

		private UITableView _listStringView;
		private UITextField _listIntView;
		private UITextField _listClassView;

		TableViewStringController tableViewController;

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
			//SetListStringView();
			SetListClassView();
			SetListTableStringButton();

			_listButton.TouchUpInside += AddStringContent;
			_listIntButton.TouchUpInside += AddIntContent;
			_listClassButton.TouchUpInside += AddClassContent;
			_listTableStringButton.TouchUpInside += NavToStringList;
		}

		public void NavToStringList(object sender, EventArgs e)
		{
			tableViewController = new TableViewStringController();
			this.NavigationController.PushViewController(tableViewController, true);
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

			foreach (string value in random)
			{
				_listStringView.Add(_listClassView);
			}
		}

		public void SetListTableStringButton()
		{
			var rect = new CGRect(10, 550, 300, 30);

			_listTableStringButton = new UIButton(rect);
			_listTableStringButton.SetTitle("Basic list on label", UIControlState.Normal);
			_listTableStringButton.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_listTableStringButton.Layer.CornerRadius = 5;

			View.Add(_listTableStringButton);
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

		public class TableSource : UITableViewSource
		{

			string[] TableItems;
			string CellIdentifier = "TableCell";

			public TableSource(string[] items)
			{
				TableItems = items;
			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return TableItems.Length;
			}

			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
				string item = TableItems[indexPath.Row];

				//---- if there are no cells to reuse, create a new one
				if (cell == null)
				{ cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

				cell.TextLabel.Text = item;

				return cell;
			}


		}

		//public void SetListStringView()
		//{


		//	var rect = new CGRect(10, 90, 300, 30);




		//	View.Add(_listStringView);
		//}

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
