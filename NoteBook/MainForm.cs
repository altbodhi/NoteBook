using System;
using Eto.Forms;
using Eto.Drawing;

namespace NoteBook
{
	/// <summary>
	/// Your application's main form
	/// </summary>
	public class MainForm : Form
	{
		public MainForm()
		{
			Title = "My Eto Form";
			ClientSize = new Size(400, 350);
            var gv = new GridView();
            gv.Columns.Add(new GridColumn() {HeaderText="Creator", DataCell = new TextBoxCell("CreatorName") });
            var ds = new NoteRepo();
            gv.DataStore = ds.GetAll();
			var layout = new TableLayout();
			layout.Rows.Add(new TableRow(new TableCell(new Scrollable()
			{
				Content = gv
            })));

            layout.Rows.Add(new TableRow(new TableCell(new Panel())));
            // scrollable region as the main content
            Content = layout;

			// create a few commands that can be used for the menu and toolbar
			var clickMe = new Command { MenuText = "Click Me!", ToolBarText = "Click Me!" };
			clickMe.Executed += (sender, e) => MessageBox.Show(this, "I was clicked!");

			var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
			quitCommand.Executed += (sender, e) => Application.Instance.Quit();
			
			var aboutCommand = new Command { MenuText = "About..." };
			aboutCommand.Executed += (sender, e) => MessageBox.Show(this, "About my app...");
					
			// create menu
			Menu = new MenuBar
			{
				Items = {
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = { clickMe } },
					// new ButtonMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new ButtonMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
				ApplicationItems = {
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences..." },
				},
				QuitItem = quitCommand,
				AboutItem = aboutCommand
			};
			
			// create toolbar			
			ToolBar = new ToolBar { Items = { clickMe } };
		}
	}
}