using System;
using System.Collections.Generic;
using AppServiceHelpers.Abstractions;
using Xamarin.Forms;

namespace Futbolochka
{
	public partial class HavkaPage : ContentPage
	{
		public HavkaPage (IEasyMobileServiceClient client) {
			InitializeComponent ();
			BindingContext = new HavkaViewModel (client);

			Title = "Chto pokushat?";
		}
	}
}

