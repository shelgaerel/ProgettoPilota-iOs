using System;
using CoreLibrary;

namespace CoreLibrary
{
	public interface UIInterface
	{
		void LoadDataEntity(object pkValue);
		AbstractDataEntityManager CreateDataEntityManager();
		void GetDataEntityFromControls();
	}
}

