using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Garbage_IDE
{
	public partial class MainWindow : Window
	{
		public void ui_init(object sender, RoutedEventArgs e)
		{
			
		}
		private void ToolBar_Loaded(object sender, RoutedEventArgs e)
		{
			ToolBar? toolBar = sender as ToolBar;

			var overflowGrid = (FrameworkElement)toolBar.Template.FindName("OverflowGrid", toolBar) as FrameworkElement;

			if (overflowGrid != null)
			{
				overflowGrid.Visibility = Visibility.Collapsed;
			}

			var mainPanelBorder = toolBar.Template.FindName("MainPanelBorder", toolBar) as FrameworkElement;

			if (mainPanelBorder != null)
			{
				mainPanelBorder.Margin = new Thickness();
			}
		}

		public void open_file(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if(openFileDialog.ShowDialog() == true)
			{
				string text = openFileDialog.FileName;

				code_textbox.Document.Blocks.Add(new Paragraph(new Run(text)));
			}
		}
		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
