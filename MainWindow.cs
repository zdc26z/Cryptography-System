using System;
using Gtk;
using CryptographySystem;

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

	protected void doEncryption (object sender, EventArgs e)
	{
		//TODO:  handle empty fields
		String algorithm = "";
		GLib.SList radios = DES.Group;
		foreach (RadioButton radio in radios) {
			if (radio.Active) {
				algorithm = radio.Name;
				break;
			}
		}
		String inFile = inputFileEntry.Text;
		String outFile = outputFileEntry.Text;
		String pword = passwordEntry.Text;
		EncDec.Encrypt (inFile, outFile, pword, algorithm);
	}

	protected void doDecryption (object sender, EventArgs e)
	{
		//TODO:  handle empty fields
		//crashes if password is wrong
		String algorithm = "";
		GLib.SList radios = DES.Group;
		foreach (RadioButton radio in radios) {
			if (radio.Active) {
				algorithm = radio.Name;
				break;
			}
		}
		String inFile = inputFileEntry.Text;
		String outFile = outputFileEntry.Text;
		String pword = passwordEntry.Text;
		EncDec.Decrypt (inFile, outFile, pword, algorithm);
	}
}
