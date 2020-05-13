using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Uno.UI.Common;
using DelegateCommand = Uno.UI.Common.DelegateCommand;

#if HAS_UNO
using ICommand = System.Windows.Input.ICommand;
#else
using ICommand = Windows.UI.Xaml.Input.ICommand;
#endif

namespace Uno.UI.Samples.Content.UITests.CommandBar
{
	public class CommandBarCommandViewModel
	{
		public string Content { get; } = "Binding";
		public ICommand Command { get; } = new DelegateCommand(async () =>
		{
			await new Windows.UI.Popups.MessageDialog("Command executed").ShowAsync();
		});
	}
}
