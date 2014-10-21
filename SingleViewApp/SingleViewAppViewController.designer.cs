// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SingleViewApp
{
	[Register ("SingleViewAppViewController")]
	partial class SingleViewAppViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnTest { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnTest != null) {
				btnTest.Dispose ();
				btnTest = null;
			}
			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}
		}
	}
}
