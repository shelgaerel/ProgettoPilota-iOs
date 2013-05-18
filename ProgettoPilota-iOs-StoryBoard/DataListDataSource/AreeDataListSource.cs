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
	public class AreeDataListSource: DataListDataSourceBase
	{
		public List<AreeDataEntity> DataEntities { get; protected set;}


		public AreeDataListSource (string cellIdentifier, RootViewController root)
			:base(cellIdentifier, root)
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

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			RootController.PerformSegue("SingleAreaSegue", this);
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell, 
//			UITableViewCell cell = tableView.DequeueReusableCell (this.CellIdentifier);
//
//			UILabel label = (UILabel)cell.ViewWithTag (101);
//			label.Text = DataEntities[indexPath.Row].CodArea;

			tableView.RegisterNibForCellReuse (MenuTableViewCell.Nib, MenuTableViewCell.Key);

			MenuTableViewCell cell;

			cell = (MenuTableViewCell)(tableView.DequeueReusableCell (this.CellIdentifier));
			UILabel label = (UILabel)cell.ViewWithTag (100);
			label.Text = DataEntities[indexPath.Row].CodArea;
			UIImageView image = (UIImageView)cell.ViewWithTag (101);
			image.Image = UIImage.FromBundle (ImageFactory.GetImage());

			return cell;
		}
	}
}

