#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class JumpListItemBackgroundConverter : global::Windows.UI.Xaml.DependencyObject,global::Windows.UI.Xaml.Data.IValueConverter
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Enabled
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(EnabledProperty);
			}
			set
			{
				this.SetValue(EnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Disabled
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(DisabledProperty);
			}
			set
			{
				this.SetValue(DisabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DisabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Disabled), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty EnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Enabled), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.JumpListItemBackgroundConverter()
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.JumpListItemBackgroundConverter()
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Enabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Enabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Disabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Disabled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Convert( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object JumpListItemBackgroundConverter.Convert(object value, Type targetType, object parameter, string language) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ConvertBack( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object JumpListItemBackgroundConverter.ConvertBack(object value, Type targetType, object parameter, string language) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.EnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.DisabledProperty.get
		// Processing: Windows.UI.Xaml.Data.IValueConverter
	}
}
