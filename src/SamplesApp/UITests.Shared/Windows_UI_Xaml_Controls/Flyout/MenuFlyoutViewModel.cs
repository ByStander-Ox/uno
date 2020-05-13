using System.Windows.Input;
using Windows.UI.Core;
using Uno.UI.Samples.UITests.Helpers;

#if HAS_UNO
using ICommand = System.Windows.Input.ICommand;
using EventHandler = System.EventHandler;
#else
using ICommand = Windows.UI.Xaml.Input.ICommand;
using EventHandler = System.EventHandler<object>;
using EventArgs = System.Object;
#endif

namespace Uno.UI.Samples.Content.UITests.MenuFlyout
{
	public class MenuFlyoutViewModel : ViewModelBase
	{
		private string _selectedOption = string.Empty;

		public MenuFlyoutViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public string SelectedOption
		{
			get => _selectedOption;
			private set
			{
				_selectedOption = value;
				RaisePropertyChanged();
			}
		}

		public bool IsOption2Visible { get; set; } = true;

		public ICommand SelectOption => GetOrCreateCommand<object>(param => SelectedOption = $"You selected: '{param}'");
	}
}
