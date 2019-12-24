
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action LoadAction;

	private global::Gtk.Action SaveAction;

	private global::Gtk.Action ExitAction;

	private global::Gtk.Action FileAction1;

	private global::Gtk.Action LoadDatabaseAction;

	private global::Gtk.Action SaveAction1;

	private global::Gtk.Action ExitAction1;

	private global::Gtk.Action HelpAction;

	private global::Gtk.Action AboutAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Label lblFighter1mid;

	private global::Gtk.TextView textviewFightDetails;

	private global::Gtk.Label lblFighter2mid;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.LoadAction = new global::Gtk.Action("LoadAction", global::Mono.Unix.Catalog.GetString("Load"), null, null);
		this.LoadAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Load");
		w1.Add(this.LoadAction, null);
		this.SaveAction = new global::Gtk.Action("SaveAction", global::Mono.Unix.Catalog.GetString("Save"), null, null);
		this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save");
		w1.Add(this.SaveAction, null);
		this.ExitAction = new global::Gtk.Action("ExitAction", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction, null);
		this.FileAction1 = new global::Gtk.Action("FileAction1", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction1, null);
		this.LoadDatabaseAction = new global::Gtk.Action("LoadDatabaseAction", global::Mono.Unix.Catalog.GetString("Load Database"), null, null);
		this.LoadDatabaseAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Load Database");
		w1.Add(this.LoadDatabaseAction, null);
		this.SaveAction1 = new global::Gtk.Action("SaveAction1", global::Mono.Unix.Catalog.GetString("Save Database"), null, null);
		this.SaveAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Save Database");
		w1.Add(this.SaveAction1, null);
		this.ExitAction1 = new global::Gtk.Action("ExitAction1", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction1, null);
		this.HelpAction = new global::Gtk.Action("HelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
		w1.Add(this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Combat Sports Scorecard");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(3));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='FileAction1' action='FileAction1'><menuitem name='LoadDatabaseAction' action='LoadDatabaseAction'/><menuitem name='SaveAction1' action='SaveAction1'/><menuitem name='ExitAction1' action='ExitAction1'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.hbox1.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		w2.Padding = ((uint)(5));
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.Name = "hseparator1";
		this.vbox1.Add(this.hseparator1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.lblFighter1mid = new global::Gtk.Label();
		this.lblFighter1mid.Name = "lblFighter1mid";
		this.lblFighter1mid.LabelProp = global::Mono.Unix.Catalog.GetString("Fighter 1");
		this.lblFighter1mid.UseUnderline = true;
		this.hbox3.Add(this.lblFighter1mid);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.lblFighter1mid]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.textviewFightDetails = new global::Gtk.TextView();
		this.textviewFightDetails.Buffer.Text = global::Mono.Unix.Catalog.GetString("Fight Details");
		this.textviewFightDetails.Name = "textviewFightDetails";
		this.textviewFightDetails.Editable = false;
		this.textviewFightDetails.Justification = ((global::Gtk.Justification)(2));
		this.textviewFightDetails.WrapMode = ((global::Gtk.WrapMode)(2));
		this.hbox3.Add(this.textviewFightDetails);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.textviewFightDetails]));
		w6.Position = 1;
		w6.Padding = ((uint)(5));
		// Container child hbox3.Gtk.Box+BoxChild
		this.lblFighter2mid = new global::Gtk.Label();
		this.lblFighter2mid.Name = "lblFighter2mid";
		this.lblFighter2mid.LabelProp = global::Mono.Unix.Catalog.GetString("Fighter 2");
		this.lblFighter2mid.UseUnderline = true;
		this.hbox3.Add(this.lblFighter2mid);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.lblFighter2mid]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 404;
		this.DefaultHeight = 556;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
