using System;
using CoreLibrary;

namespace DataEntity
{
	public class AreeDataEntity : DataEntityBase
	{
		public AreeDataEntity ()
		{
			State = DataEntityState.UnChanged;
		}

		public AreeDataEntity(DataEntityState state)
		{
			State = state;
		}

		#region implemented abstract members of AbstractEntity

		public override bool OnIsValid ()
		{
			return true;
		}

		#endregion

		#region Interfaccia a Proprietà

		[EntityColumnName("CodArea")]
		public string CodArea { get; set; }

		[EntityColumnName("Descrizione")]
		public string Descrizione { get; set; }

		#endregion
	}
}

