using System;
using Foundation;
using UIKit;

namespace Calculation
{
	public class TableViewStringController : UIViewController
	{
		private UITableView table;


		public TableViewStringController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			table = new UITableView(View.Bounds); // defaults to Plain style
			string[] tableItems = new string[] { "example" };
			table.Source = new TableSource(tableItems);
			Add(table);
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
	}
}
