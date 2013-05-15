using System;
using CoreLibrary;
using DataEntity;

namespace DataEntityManager
{
	public class AreeDataEntityManager : AbstractDataEntityManager
	{
		public AreeDataEntityManager ()
		{

		}

		#region implemented abstract members of EngineBase

		public override DataEntityBase Read ()
		{
			//Inserimento della logica di lettura per un nuovo inserimento
			this.DataEntity = new AreeDataEntity(DataEntityState.Added);
			return this.DataEntity;
		}

		#endregion
	}
}

