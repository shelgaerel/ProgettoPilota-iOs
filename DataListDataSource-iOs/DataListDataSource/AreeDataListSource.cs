using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections;
using System.Collections.Generic;
using CoreLibrary;
using DataEntityManager;
using DataEntity;
using CoreFactory;

namespace DataListDataSourceiOs
{
	public class AreeDataListSource: DataListDataSourceBase
	{
		public List<AreeDataEntity> DataEntities { get; protected set;}

		public AreeDataListSource (string cellIdentifier)
			:base(cellIdentifier)
		{

			this.DataManager = DataEntityManagerFactory.GetDataEntityManager (MenuItems.Aree);
			this.DataEntities = this.DataManager.GetEntityList<AreeDataEntity> ();
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return DataEntities.Count;
		}

		public new int GetItem(int id)
		{
			return DataEntities[id].ID;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell, 
			UITableViewCell cell = tableView.DequeueReusableCell (this.CellIdentifier);
			// now set the properties as normal
			cell.TextLabel.Text = DataEntities[indexPath.Row].CodArea;

			return cell;
		}
	}
}

