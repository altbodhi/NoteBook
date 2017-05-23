using System;
using Eto.Forms;
using Eto.Drawing;

namespace NoteBook
{
	public static class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Helper.BuildSchema();

			// run application with our main form
			new Application().Run(new MainForm());
		}
	}
}
