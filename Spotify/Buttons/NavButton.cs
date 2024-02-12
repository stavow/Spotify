using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Spotify
{
	public class NavButton : RadioButton
	{
		public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register(nameof(PathData), typeof(Geometry), typeof(NavButton), null);
		public static readonly DependencyProperty ActivePathDataProperty = DependencyProperty.Register(nameof(ActivePathData), typeof(Geometry), typeof(NavButton), null);

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
	}
}
