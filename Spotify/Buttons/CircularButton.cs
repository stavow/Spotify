using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace Spotify
{
	public class CircularButton : Button
	{
		public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register(nameof(PathData), typeof(Geometry), typeof(CircularButton), null);
		public static readonly DependencyProperty ActivePathDataProperty = DependencyProperty.Register(nameof(ActivePathData), typeof(Geometry), typeof(CircularButton), null);
		public static DependencyProperty IsSearchButtonProperty = DependencyProperty.RegisterAttached("IsSearchButton", typeof(bool), typeof(CircularButton), new PropertyMetadata(default(bool)));

		public Geometry PathData
		{
			get { return (Geometry)GetValue(PathDataProperty); }
			set { SetValue(PathDataProperty, value); }
		}

		public Geometry ActivePathData
		{
			get { return (Geometry)GetValue(ActivePathDataProperty); }
			set { SetValue(ActivePathDataProperty, value); }
		}

		public static void SetIsSearchButton(UIElement element, bool value)
		{
			element.SetValue(IsSearchButtonProperty, value);
		}

		public static bool GetIsSearchButton(UIElement element)
		{
			return (bool)element.GetValue(IsSearchButtonProperty);
		}
	}
}