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
		public void ui_init(object sender, RoutedEventArgs e)		//Sourav's Comment
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
				//Open the File & Set The Window Title

				string file_path = openFileDialog.FileName;

				string file_name;

				int idx = file_path.Length - 1;
				char curr_char = file_path[idx];

				while(curr_char != '\\')
				{
					idx--;

					curr_char = file_path[idx];
				}
				idx++;

				file_name = file_path.Substring(idx);

				string window_title = "Garbage IDE " + "(" + file_name + ")";

				main_window.Title = window_title;

				//Print The File Data

				code_textbox.Text = System.IO.File.ReadAllText(file_path);
			}
		}
		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
