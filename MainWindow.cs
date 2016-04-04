﻿using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void bye (object sender, EventArgs e)
	{
		Application.Quit ();
	}

	protected void openFile (object sender, EventArgs e)
	{
		Gtk.FileChooserDialog filechooser =
			new Gtk.FileChooserDialog("Choose the file to open",
				this,
				FileChooserAction.Open,
				"Cancel",ResponseType.Cancel,
				"Open",ResponseType.Accept);

		if (filechooser.Run() == (int)ResponseType.Accept) 
		{
			String src = "";
			if (sender.ToString () == "Gtk.Button") {
				Gtk.Button butt = sender as Gtk.Button;
				src = butt.Name;
			} else if (sender.ToString () == "Gtk.Action") {
				Gtk.Action act = sender as Gtk.Action;
				src = act.Name;
			} else {
				src = sender.ToString ();
			}

			if (src == "OpenInputFileAction" || src == "inputFileButton") {
				inputFileEntry.Text = filechooser.Filename;
			} else {
				outputFileEntry.Text = filechooser.Filename;
			}
		}

		filechooser.Destroy();
	}
}