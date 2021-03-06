
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action FileAction1;
	
	private global::Gtk.Action HelpAction1;
	
	private global::Gtk.Action OpenInputFileAction;
	
	private global::Gtk.Action OpenOutputFileAction;
	
	private global::Gtk.Action ExitAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Alignment alignment1;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar5;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Entry inputFileEntry;
	
	private global::Gtk.Button inputFileButton;
	
	private global::Gtk.HBox hbox8;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.ProgressBar progressbar1;
	
	private global::Gtk.HButtonBox hbuttonbox2;
	
	private global::Gtk.Button encryptButton;
	
	private global::Gtk.Button decryptButton;
	
	private global::Gtk.Button digestButton;
	
	private global::Gtk.Button exitButton;
	
	private global::Gtk.Frame frame2;
	
	private global::Gtk.Alignment GtkAlignment1;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.RadioButton md5;
	
	private global::Gtk.RadioButton sha1;
	
	private global::Gtk.RadioButton sha256;
	
	private global::Gtk.RadioButton sha512;
	
	private global::Gtk.Label GtkLabel13;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.RadioButton DES;
	
	private global::Gtk.RadioButton RC2;
	
	private global::Gtk.RadioButton Rijndael;
	
	private global::Gtk.RadioButton TripleDES;
	
	private global::Gtk.Label GtkLabel8;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Entry passwordEntry;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Entry outputFileEntry;
	
	private global::Gtk.Button outputFileButton;
	
	private global::Gtk.Label label3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.FileAction1 = new global::Gtk.Action ("FileAction1", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction1, "<Alt><Mod2>f");
		this.HelpAction1 = new global::Gtk.Action ("HelpAction1", global::Mono.Unix.Catalog.GetString ("_Help"), null, null);
		this.HelpAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction1, "<Alt><Mod2>h");
		this.OpenInputFileAction = new global::Gtk.Action ("OpenInputFileAction", global::Mono.Unix.Catalog.GetString ("Open _Input File"), null, null);
		this.OpenInputFileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Input File");
		w1.Add (this.OpenInputFileAction, "<Alt><Mod2>i");
		this.OpenOutputFileAction = new global::Gtk.Action ("OpenOutputFileAction", global::Mono.Unix.Catalog.GetString ("Open _Output File"), null, null);
		this.OpenOutputFileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Output File");
		w1.Add (this.OpenOutputFileAction, "<Alt><Mod2>o");
		this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("E_xit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.ExitAction, "<Alt><Mod2>x");
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("_About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, "<Alt><Mod2>a");
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Cryptography System");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(9));
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar5'><menu name='FileAction1' action='FileAction1'><menuitem name='OpenInputFileAction' action='OpenInputFileAction'/><menuitem name='OpenOutputFileAction' action='OpenOutputFileAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='HelpAction1' action='HelpAction1'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar5 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar5")));
		this.menubar5.Name = "menubar5";
		this.vbox1.Add (this.menubar5);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar5]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 0F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Input File");
		this.vbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label2]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.inputFileEntry = new global::Gtk.Entry ();
		this.inputFileEntry.CanFocus = true;
		this.inputFileEntry.Name = "inputFileEntry";
		this.inputFileEntry.IsEditable = true;
		this.inputFileEntry.InvisibleChar = '●';
		this.hbox1.Add (this.inputFileEntry);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.inputFileEntry]));
		w4.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.inputFileButton = new global::Gtk.Button ();
		this.inputFileButton.CanFocus = true;
		this.inputFileButton.Name = "inputFileButton";
		this.inputFileButton.UseUnderline = true;
		this.inputFileButton.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
		this.hbox1.Add (this.inputFileButton);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.inputFileButton]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Progress Status");
		this.hbox8.Add (this.label5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label5]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.progressbar1 = new global::Gtk.ProgressBar ();
		this.progressbar1.Name = "progressbar1";
		this.hbox8.Add (this.progressbar1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.progressbar1]));
		w8.Position = 1;
		this.vbox1.Add (this.hbox8);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox8]));
		w9.PackType = ((global::Gtk.PackType)(1));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox2 = new global::Gtk.HButtonBox ();
		this.hbuttonbox2.Name = "hbuttonbox2";
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.encryptButton = new global::Gtk.Button ();
		this.encryptButton.CanFocus = true;
		this.encryptButton.Name = "encryptButton";
		this.encryptButton.UseUnderline = true;
		this.encryptButton.Label = global::Mono.Unix.Catalog.GetString ("_ENCRYPT");
		this.hbuttonbox2.Add (this.encryptButton);
		global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.encryptButton]));
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.decryptButton = new global::Gtk.Button ();
		this.decryptButton.CanFocus = true;
		this.decryptButton.Name = "decryptButton";
		this.decryptButton.UseUnderline = true;
		this.decryptButton.Label = global::Mono.Unix.Catalog.GetString ("_DECRYPT");
		this.hbuttonbox2.Add (this.decryptButton);
		global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.decryptButton]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.digestButton = new global::Gtk.Button ();
		this.digestButton.CanFocus = true;
		this.digestButton.Name = "digestButton";
		this.digestButton.UseUnderline = true;
		this.digestButton.Label = global::Mono.Unix.Catalog.GetString ("DI_GEST");
		this.hbuttonbox2.Add (this.digestButton);
		global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.digestButton]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.exitButton = new global::Gtk.Button ();
		this.exitButton.CanFocus = true;
		this.exitButton.Name = "exitButton";
		this.exitButton.UseUnderline = true;
		this.exitButton.Label = global::Mono.Unix.Catalog.GetString ("E_XIT");
		this.hbuttonbox2.Add (this.exitButton);
		global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.exitButton]));
		w13.Position = 3;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox1.Add (this.hbuttonbox2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox2]));
		w14.PackType = ((global::Gtk.PackType)(1));
		w14.Position = 4;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.md5 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("MD5"));
		this.md5.CanFocus = true;
		this.md5.Name = "md5";
		this.md5.DrawIndicator = true;
		this.md5.UseUnderline = true;
		this.md5.BorderWidth = ((uint)(6));
		this.md5.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox5.Add (this.md5);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.md5]));
		w15.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.sha1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("SHA1"));
		this.sha1.CanFocus = true;
		this.sha1.Name = "sha1";
		this.sha1.DrawIndicator = true;
		this.sha1.UseUnderline = true;
		this.sha1.Group = this.md5.Group;
		this.hbox5.Add (this.sha1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.sha1]));
		w16.Position = 1;
		// Container child hbox5.Gtk.Box+BoxChild
		this.sha256 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("SHA256"));
		this.sha256.CanFocus = true;
		this.sha256.Name = "sha256";
		this.sha256.DrawIndicator = true;
		this.sha256.UseUnderline = true;
		this.sha256.Group = this.md5.Group;
		this.hbox5.Add (this.sha256);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.sha256]));
		w17.Position = 2;
		// Container child hbox5.Gtk.Box+BoxChild
		this.sha512 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("SHA512"));
		this.sha512.CanFocus = true;
		this.sha512.Name = "sha512";
		this.sha512.DrawIndicator = true;
		this.sha512.UseUnderline = true;
		this.sha512.BorderWidth = ((uint)(6));
		this.sha512.Group = this.md5.Group;
		this.hbox5.Add (this.sha512);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.sha512]));
		w18.Position = 3;
		this.GtkAlignment1.Add (this.hbox5);
		this.frame2.Add (this.GtkAlignment1);
		this.GtkLabel13 = new global::Gtk.Label ();
		this.GtkLabel13.Name = "GtkLabel13";
		this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Message Digest Algorithm</b>");
		this.GtkLabel13.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel13;
		this.vbox1.Add (this.frame2);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame2]));
		w21.PackType = ((global::Gtk.PackType)(1));
		w21.Position = 5;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.DES = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("DES"));
		this.DES.CanFocus = true;
		this.DES.Name = "DES";
		this.DES.DrawIndicator = true;
		this.DES.UseUnderline = true;
		this.DES.BorderWidth = ((uint)(6));
		this.DES.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox4.Add (this.DES);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.DES]));
		w22.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.RC2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("RC2"));
		this.RC2.CanFocus = true;
		this.RC2.Name = "RC2";
		this.RC2.DrawIndicator = true;
		this.RC2.UseUnderline = true;
		this.RC2.BorderWidth = ((uint)(6));
		this.RC2.Group = this.DES.Group;
		this.hbox4.Add (this.RC2);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.RC2]));
		w23.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.Rijndael = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Rijndael"));
		this.Rijndael.CanFocus = true;
		this.Rijndael.Name = "Rijndael";
		this.Rijndael.DrawIndicator = true;
		this.Rijndael.UseUnderline = true;
		this.Rijndael.BorderWidth = ((uint)(6));
		this.Rijndael.Group = this.DES.Group;
		this.hbox4.Add (this.Rijndael);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.Rijndael]));
		w24.Position = 2;
		// Container child hbox4.Gtk.Box+BoxChild
		this.TripleDES = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("TripleDES"));
		this.TripleDES.CanFocus = true;
		this.TripleDES.Name = "TripleDES";
		this.TripleDES.DrawIndicator = true;
		this.TripleDES.UseUnderline = true;
		this.TripleDES.BorderWidth = ((uint)(6));
		this.TripleDES.Group = this.DES.Group;
		this.hbox4.Add (this.TripleDES);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.TripleDES]));
		w25.Position = 3;
		this.GtkAlignment.Add (this.hbox4);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel8 = new global::Gtk.Label ();
		this.GtkLabel8.Name = "GtkLabel8";
		this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Encryption Algorithm</b>");
		this.GtkLabel8.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel8;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w28.PackType = ((global::Gtk.PackType)(1));
		w28.Position = 6;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Password:");
		this.hbox3.Add (this.label4);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.passwordEntry = new global::Gtk.Entry ();
		this.passwordEntry.WidthRequest = 294;
		this.passwordEntry.CanFocus = true;
		this.passwordEntry.Name = "passwordEntry";
		this.passwordEntry.IsEditable = true;
		this.passwordEntry.Visibility = false;
		this.passwordEntry.InvisibleChar = '●';
		this.hbox3.Add (this.passwordEntry);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.passwordEntry]));
		w30.Position = 1;
		w30.Expand = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w31.PackType = ((global::Gtk.PackType)(1));
		w31.Position = 7;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.outputFileEntry = new global::Gtk.Entry ();
		this.outputFileEntry.CanFocus = true;
		this.outputFileEntry.Name = "outputFileEntry";
		this.outputFileEntry.IsEditable = true;
		this.outputFileEntry.InvisibleChar = '●';
		this.hbox2.Add (this.outputFileEntry);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.outputFileEntry]));
		w32.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.outputFileButton = new global::Gtk.Button ();
		this.outputFileButton.CanFocus = true;
		this.outputFileButton.Name = "outputFileButton";
		this.outputFileButton.UseUnderline = true;
		this.outputFileButton.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
		this.hbox2.Add (this.outputFileButton);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.outputFileButton]));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w34.PackType = ((global::Gtk.PackType)(1));
		w34.Position = 8;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 0F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Output File");
		this.vbox1.Add (this.label3);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label3]));
		w35.PackType = ((global::Gtk.PackType)(1));
		w35.Position = 9;
		w35.Expand = false;
		w35.Fill = false;
		this.alignment1.Add (this.vbox1);
		this.Add (this.alignment1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 484;
		this.DefaultHeight = 360;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.OpenInputFileAction.Activated += new global::System.EventHandler (this.openFile);
		this.OpenOutputFileAction.Activated += new global::System.EventHandler (this.openFile);
		this.ExitAction.Activated += new global::System.EventHandler (this.bye);
		this.inputFileButton.Clicked += new global::System.EventHandler (this.openFile);
		this.outputFileButton.Clicked += new global::System.EventHandler (this.openFile);
		this.encryptButton.Clicked += new global::System.EventHandler (this.doEncryption);
		this.decryptButton.Clicked += new global::System.EventHandler (this.doDecryption);
		this.digestButton.Clicked += new global::System.EventHandler (this.doDigest);
		this.exitButton.Activated += new global::System.EventHandler (this.bye);
		this.exitButton.Clicked += new global::System.EventHandler (this.bye);
	}
}
