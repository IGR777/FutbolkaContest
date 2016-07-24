using System;
using System.Windows.Input;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Forms;
using Xamarin.Forms;

namespace Futbolochka
{
	public class HavkaViewModel : BaseAzureViewModel<Havka>
	{
		IEasyMobileServiceClient _client;
		public HavkaViewModel (IEasyMobileServiceClient client) : base (client) {
			_client = client;
		}


		string _pervoeText;
		public string PervoeText {
			get {
				return _pervoeText;
			}
			set {
				_pervoeText = value;
				OnPropertyChanged ("PervoeText");
			}
		}

		string _vtoroeText;
		public string VtoroeText {
			get {
				return _vtoroeText;
			}
			set {
				_vtoroeText = value;
				OnPropertyChanged ("VtoroeText");
			}
		}

		public ICommand AddCommand {
			get {
				return new Command (() => {
					var item = new Havka {
						Pervoe = PervoeText,
						Vtoroe = VtoroeText
					};
					Items.Add (item);
					AddItemAsync (item);
				});
			}
		}
	}
}

