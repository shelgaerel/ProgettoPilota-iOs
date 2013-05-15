using System;
using CoreLibrary;
using DataEntityManager;

namespace CoreFactory
{
	public static class DataEntityManagerFactory
	{
		public static AbstractDataEntityManager GetDataEntityManager(MenuItems menuItem)
		{
			switch (menuItem) {
				case MenuItems.Aree:
					return new AreeDataEntityManager ();

				default:
					return null;

			}
		}
	}
}

