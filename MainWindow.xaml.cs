using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			string file_data = File.ReadAllText("C:\\Users\\Devashish Lahariya\\source\\repos\\Garbage IDE\\settings\\preferences.txt");		//Find a way to locate the IDE install path.

			code_textbox.Document.Blocks.Clear();
			code_textbox.Document.Blocks.Add(new Paragraph(new Run(file_data)));

			int window_size_x = 0, window_size_y = 0;

			string str_window_size_x = "", str_window_size_y = "";

			string cmd = "application.size.x = ";

			string data_to_print = "";

			if (file_data.Contains(cmd))
			{
				str_window_size_x = Regex.Match(file_data, @"\d+").Value;

				window_size_x = Int32.Parse(str_window_size_x);

				data_to_print = "WINDOW.SIZE.X = " + str_window_size_x;
			}

			cmd = "application.size.y = ";

			if (file_data.Contains(cmd))
			{
				int index = file_data.IndexOf(cmd);

				str_window_size_y = Regex.Match(file_data.Substring(index), @"\d+").Value;

				window_size_y = Int32.Parse(str_window_size_y);

				data_to_print += "\nWINDOW.SIZE.Y = " + str_window_size_y;
			}
			code_textbox.Document.Blocks.Clear();
			code_textbox.Document.Blocks.Add(new Paragraph(new Run(data_to_print)));

			main_window.Width = window_size_x;
			main_window.Height = window_size_y;
		}

		public static string getBetween(string strSource, string strStart, string strEnd)
		{
			if (strSource.Contains(strStart) && strSource.Contains(strEnd))
			{
				int Start, End;
				Start = strSource.IndexOf(strStart, 0) + strStart.Length;
				End = strSource.IndexOf(strEnd, Start);

				return strSource.Substring(Start, End - Start);
			}
			return "";
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

		public void create_file(object sender, RoutedEventArgs e)
		{
			FileStream file = new FileStream("preferences.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

			string data = "Hello, World!! This is the preferences file for the application.";

			byte[] bytes = Encoding.ASCII.GetBytes(data);

			file.Write(bytes, 0, data.Length);
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

				string window_title = "Garbage IDE - " + file_name;

				main_window.Title = window_title;

				//Print The File Data

				string file_data = System.IO.File.ReadAllText(file_path);

				code_textbox.Document.Blocks.Clear();
				code_textbox.Document.Blocks.Add(new Paragraph(new Run(file_data)));
			}
		}

		public void save_file(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			if(saveFileDialog.ShowDialog() == true)
			{
				TextRange textRange = new TextRange(code_textbox.Document.ContentStart, code_textbox.Document.ContentEnd);

				string text = textRange.Text;

				System.IO.File.WriteAllText(saveFileDialog.FileName, text);
			}
		}

		public MainWindow()
		{
			InitializeComponent();
		}
	}
}