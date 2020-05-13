using System;
using System.Windows.Input;
using Uno.UI.Samples.UITests.Helpers;
using Windows.UI.Core;
using Windows.UI.Xaml.Data;

#if HAS_UNO
using ICommand = System.Windows.Input.ICommand;
using EventHandler = System.EventHandler;
#else
using ICommand = Windows.UI.Xaml.Input.ICommand;
using EventHandler = System.EventHandler<object>;
using EventArgs = System.Object;
#endif

namespace UITests.Shared.Windows_UI_Xaml_Controls.TimePicker.Model
{
	[Bindable]
	public class TimePickerViewModel : ViewModelBase
	{
		private TimeSpan _time = new TimeSpan(12,0,0);

		public TimePickerViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public TimeSpan Time
		{
			get => _time;
			set
			{
				_time = value;
				RaisePropertyChanged("Time");
			}
		}

		public ICommand SetToCurrentTime => GetOrCreateCommand(() => Time = DateTime.Now.TimeOfDay);
	}
}
