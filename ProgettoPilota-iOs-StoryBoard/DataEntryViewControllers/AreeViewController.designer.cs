// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using CoreLibrary;

namespace ProgettoPilotaiOsStoryBoard
{
	[Register ("AreeViewController")]
	partial class AreeViewController
	{
		[EntityBindingProperty("CodArea")]
		[Outlet]
		public MonoTouch.UIKit.UITextField txtCodice { get; set; }

		[EntityBindingProperty("Descrizione")]
		[Outlet]
		public MonoTouch.UIKit.UITextField txtDescrizione { get; set; }

		[Action ("Save:")]
		partial void Save (MonoTouch.Foundation.NSObject sender);

		[Action ("Delete:")]
		partial void Delete (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtCodice != null) {
				txtCodice.Dispose ();
				txtCodice = null;
			}

			if (txtDescrizione != null) {
				txtDescrizione.Dispose ();
				txtDescrizione = null;
			}
		}
	}
}
