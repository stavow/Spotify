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
	public class SpotifyButton : CheckBox
	{
		public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register(nameof(PathData), typeof(Geometry), typeof(SpotifyButton), null);
		public static readonly DependencyProperty ActivePathDataProperty = DependencyProperty.Register(nameof(ActivePathData), typeof(Geometry), typeof(SpotifyButton), null);

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
