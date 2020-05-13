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

namespace SamplesApp.UITests.Windows_UI_Xaml_Controls.Models
{
	public class ChatBoxViewModel : ViewModelBase
	{
		public ChatBoxViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{			
			_clickCount = 0;
		}

		public ICommand ToggleHeader => GetOrCreateCommand(ExecuteToggleHeader);

		private int _clickCount;

		public int ClickCount {
			get => _clickCount;
			set
			{
				_clickCount = value;
				RaisePropertyChanged();
			}
		}

		private void ExecuteToggleHeader()
		{
			ClickCount ++;
		}
	}
}
