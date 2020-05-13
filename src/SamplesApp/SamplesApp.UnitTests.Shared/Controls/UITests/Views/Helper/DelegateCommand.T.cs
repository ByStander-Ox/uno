#if NETFX_CORE
using System;
using Windows.UI.Xaml.Input;

#if HAS_UNO_WINUI
using ICommand = Windows.UI.Xaml.Input.ICommand;
using EventHandler = System.EventHandler<object>;
#else
using ICommand = System.Windows.Input.ICommand;
using EventHandler;
#endif

namespace Uno.UI.Common
{
	public class DelegateCommand<T> : ICommand
	{
		private Action<T> _action;
		private bool _canExecuteEnabled = true;

		public event EventHandler<object> CanExecuteChanged;

		public DelegateCommand(Action<T> action)
		{
			_action = action;
		}

		public bool CanExecute(object parameter) => CanExecuteEnabled;

		public void Execute(object parameter)
		{
			if (parameter is T t)
			{
				_action?.Invoke(t);
			}
			else if (parameter == null && !typeof(T).IsValueType)
			{
				_action?.Invoke(default(T));
			}
			else
			{
				throw new InvalidCastException($"parameter must be a {typeof(T)}");
			}
		}

		private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

		public bool CanExecuteEnabled
		{
			get => _canExecuteEnabled;
			set
			{
				_canExecuteEnabled = value;
				OnCanExecuteChanged();
			}
		}
	}
}
#endif
