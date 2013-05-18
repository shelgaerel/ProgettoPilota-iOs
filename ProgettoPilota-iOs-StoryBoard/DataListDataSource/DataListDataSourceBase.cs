using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections;
using System.Collections.Generic;
using CoreLibrary;
using DataEntityManager;
using DataEntity;
using CoreFactory;

namespace ProgettoPilotaiOsStoryBoard
{
	public class DataListDataSourceBase: UITableViewSource
	{
		protected AbstractDataEntityManager DataManager;
		protected string CellIdentifier;
		protected UITableViewController RootController;

		public DataListDataSourceBase (string cellIdentifier, UITableViewController rootController)
		{
			this.CellIdentifier = cellIdentifier;
			this.RootController = rootController;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			throw new NotImplementedException ();
		}

		public int GetItem(int id)
		{
			throw new NotImplementedException ();
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			throw new NotImplementedException ();
		}
	}
}

