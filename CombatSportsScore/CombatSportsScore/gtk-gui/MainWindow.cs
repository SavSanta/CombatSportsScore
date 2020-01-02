
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

	private global::Gtk.Action SaveDatabaseAction;

	private global::Gtk.Action ExitAction1;

	private global::Gtk.Action HelpAction;

	private global::Gtk.Action AboutAction;

	private global::Gtk.Action NewScoreCardAction;

	private global::Gtk.Action DeleteScoreCardAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hboxMenu;

	private global::Gtk.MenuBar menubar;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.HBox hboxFightDateHeader;

	private global::Gtk.Label lblFighter1Name;

	private global::Gtk.Frame frameDate;

	private global::Gtk.Alignment GtkAlignmentDate;

	private global::Gtk.Label labelDate;

	private global::Gtk.Label GtkLabel3;

	private global::Gtk.Label lblFighter2Name;

	private global::Gtk.HSeparator hseparator2;

	private global::CombatSportsScore.ColourButton colourbutton1;

	private global::Gtk.Frame frameTotalScore;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.HPaned hpaneTotalScore;

	private global::Gtk.Label labelTotalScore1;

	private global::Gtk.Label labelTotalScore2;

	private global::Gtk.Label GtkLabelScore;

	private global::Gtk.ScrolledWindow scrollwindowFightComment;

	private global::Gtk.TextView textviewFightComment;

	private global::Gtk.Statusbar statusbarFooter;

	private global::Gtk.Label labelScoreCardID;

	private global::Gtk.Entry entryScoreCardName;

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
		this.SaveDatabaseAction = new global::Gtk.Action("SaveDatabaseAction", global::Mono.Unix.Catalog.GetString("Save Database"), null, null);
		this.SaveDatabaseAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save Database");
		w1.Add(this.SaveDatabaseAction, null);
		this.ExitAction1 = new global::Gtk.Action("ExitAction1", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction1, null);
		this.HelpAction = new global::Gtk.Action("HelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
		w1.Add(this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction, null);
		this.NewScoreCardAction = new global::Gtk.Action("NewScoreCardAction", global::Mono.Unix.Catalog.GetString("New ScoreCard"), null, null);
		this.NewScoreCardAction.ShortLabel = global::Mono.Unix.Catalog.GetString("New ScoreCard");
		w1.Add(this.NewScoreCardAction, "<Primary>n");
		this.DeleteScoreCardAction = new global::Gtk.Action("DeleteScoreCardAction", global::Mono.Unix.Catalog.GetString("Delete ScoreCard"), null, null);
		this.DeleteScoreCardAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Delete ScoreCard");
		w1.Add(this.DeleteScoreCardAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = "Combat Sports Scorecard";
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(3));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hboxMenu = new global::Gtk.HBox();
		this.hboxMenu.Name = "hboxMenu";
		this.hboxMenu.Spacing = 6;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='menubar'><menu name='FileAction1' action='FileAction1'><menuitem name='NewScoreCardAction' action='NewScoreCardAction'/><menuitem name='DeleteScoreCardAction' action='DeleteScoreCardAction'/><menuitem name='LoadDatabaseAction' action='LoadDatabaseAction'/><menuitem name='SaveDatabaseAction' action='SaveDatabaseAction'/><menuitem name='ExitAction1' action='ExitAction1'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar")));
		this.menubar.Name = "menubar";
		this.hboxMenu.Add(this.menubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxMenu[this.menubar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		w2.Padding = ((uint)(5));
		this.vbox1.Add(this.hboxMenu);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxMenu]));
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
		this.hboxFightDateHeader = new global::Gtk.HBox();
		this.hboxFightDateHeader.Name = "hboxFightDateHeader";
		this.hboxFightDateHeader.Spacing = 6;
		// Container child hboxFightDateHeader.Gtk.Box+BoxChild
		this.lblFighter1Name = new global::Gtk.Label();
		this.lblFighter1Name.Name = "lblFighter1Name";
		this.lblFighter1Name.LabelProp = global::Mono.Unix.Catalog.GetString("Fighter 1");
		this.lblFighter1Name.UseMarkup = true;
		this.lblFighter1Name.UseUnderline = true;
		this.hboxFightDateHeader.Add(this.lblFighter1Name);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxFightDateHeader[this.lblFighter1Name]));
		w5.Position = 0;
		// Container child hboxFightDateHeader.Gtk.Box+BoxChild
		this.frameDate = new global::Gtk.Frame();
		this.frameDate.Name = "frameDate";
		// Container child frameDate.Gtk.Container+ContainerChild
		this.GtkAlignmentDate = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignmentDate.Name = "GtkAlignmentDate";
		this.GtkAlignmentDate.LeftPadding = ((uint)(12));
		// Container child GtkAlignmentDate.Gtk.Container+ContainerChild
		this.labelDate = new global::Gtk.Label();
		this.labelDate.Name = "labelDate";
		this.labelDate.LabelProp = global::Mono.Unix.Catalog.GetString("MM-DD-YYYY");
		this.labelDate.UseMarkup = true;
		this.GtkAlignmentDate.Add(this.labelDate);
		this.frameDate.Add(this.GtkAlignmentDate);
		this.GtkLabel3 = new global::Gtk.Label();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.Xpad = 113;
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("<b> Date </b>");
		this.GtkLabel3.UseMarkup = true;
		this.frameDate.LabelWidget = this.GtkLabel3;
		this.hboxFightDateHeader.Add(this.frameDate);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxFightDateHeader[this.frameDate]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		w8.Padding = ((uint)(5));
		// Container child hboxFightDateHeader.Gtk.Box+BoxChild
		this.lblFighter2Name = new global::Gtk.Label();
		this.lblFighter2Name.Name = "lblFighter2Name";
		this.lblFighter2Name.LabelProp = global::Mono.Unix.Catalog.GetString("Fighter 2");
		this.lblFighter2Name.UseUnderline = true;
		this.hboxFightDateHeader.Add(this.lblFighter2Name);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxFightDateHeader[this.lblFighter2Name]));
		w9.Position = 2;
		this.vbox1.Add(this.hboxFightDateHeader);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxFightDateHeader]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator();
		this.hseparator2.Name = "hseparator2";
		this.vbox1.Add(this.hseparator2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator2]));
		w11.Position = 3;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.colourbutton1 = new global::CombatSportsScore.ColourButton();
		this.colourbutton1.Events = ((global::Gdk.EventMask)(256));
		this.colourbutton1.Name = "colourbutton1";
		this.vbox1.Add(this.colourbutton1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.colourbutton1]));
		w12.Position = 4;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frameTotalScore = new global::Gtk.Frame();
		this.frameTotalScore.Name = "frameTotalScore";
		this.frameTotalScore.BorderWidth = ((uint)(2));
		// Container child frameTotalScore.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(4));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.hpaneTotalScore = new global::Gtk.HPaned();
		this.hpaneTotalScore.CanFocus = true;
		this.hpaneTotalScore.Name = "hpaneTotalScore";
		this.hpaneTotalScore.Position = 260;
		this.hpaneTotalScore.BorderWidth = ((uint)(10));
		// Container child hpaneTotalScore.Gtk.Paned+PanedChild
		this.labelTotalScore1 = new global::Gtk.Label();
		this.labelTotalScore1.Name = "labelTotalScore1";
		this.labelTotalScore1.LabelProp = "<span fgcolor=\"red\" size=\"x-large\" weight=\"heavy\" > 0 </span>";
		this.labelTotalScore1.UseMarkup = true;
		this.labelTotalScore1.Wrap = true;
		this.hpaneTotalScore.Add(this.labelTotalScore1);
		global::Gtk.Paned.PanedChild w13 = ((global::Gtk.Paned.PanedChild)(this.hpaneTotalScore[this.labelTotalScore1]));
		w13.Resize = false;
		// Container child hpaneTotalScore.Gtk.Paned+PanedChild
		this.labelTotalScore2 = new global::Gtk.Label();
		this.labelTotalScore2.Name = "labelTotalScore2";
		this.labelTotalScore2.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"blue\" size=\"x-large\" weight=\"heavy\" > 0 </span>");
		this.labelTotalScore2.UseMarkup = true;
		this.hpaneTotalScore.Add(this.labelTotalScore2);
		this.GtkAlignment.Add(this.hpaneTotalScore);
		this.frameTotalScore.Add(this.GtkAlignment);
		this.GtkLabelScore = new global::Gtk.Label();
		this.GtkLabelScore.Name = "GtkLabelScore";
		this.GtkLabelScore.LabelProp = global::Mono.Unix.Catalog.GetString("<b> Score </b>");
		this.GtkLabelScore.UseMarkup = true;
		this.GtkLabelScore.Justify = ((global::Gtk.Justification)(1));
		this.frameTotalScore.LabelWidget = this.GtkLabelScore;
		this.vbox1.Add(this.frameTotalScore);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frameTotalScore]));
		w17.Position = 5;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.scrollwindowFightComment = new global::Gtk.ScrolledWindow();
		this.scrollwindowFightComment.Name = "scrollwindowFightComment";
		this.scrollwindowFightComment.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		this.scrollwindowFightComment.ShadowType = ((global::Gtk.ShadowType)(1));
		this.scrollwindowFightComment.WindowPlacement = ((global::Gtk.CornerType)(3));
		// Container child scrollwindowFightComment.Gtk.Container+ContainerChild
		this.textviewFightComment = new global::Gtk.TextView();
		this.textviewFightComment.HeightRequest = 80;
		this.textviewFightComment.CanFocus = true;
		this.textviewFightComment.Name = "textviewFightComment";
		this.textviewFightComment.Justification = ((global::Gtk.Justification)(2));
		this.textviewFightComment.WrapMode = ((global::Gtk.WrapMode)(3));
		this.scrollwindowFightComment.Add(this.textviewFightComment);
		this.vbox1.Add(this.scrollwindowFightComment);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrollwindowFightComment]));
		w19.Position = 6;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbarFooter = new global::Gtk.Statusbar();
		this.statusbarFooter.Name = "statusbarFooter";
		this.statusbarFooter.Spacing = 6;
		// Container child statusbarFooter.Gtk.Box+BoxChild
		this.labelScoreCardID = new global::Gtk.Label();
		this.labelScoreCardID.Name = "labelScoreCardID";
		this.labelScoreCardID.LabelProp = global::Mono.Unix.Catalog.GetString("ID: x");
		this.statusbarFooter.Add(this.labelScoreCardID);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.statusbarFooter[this.labelScoreCardID]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child statusbarFooter.Gtk.Box+BoxChild
		this.entryScoreCardName = new global::Gtk.Entry();
		this.entryScoreCardName.CanFocus = true;
		this.entryScoreCardName.Name = "entryScoreCardName";
		this.entryScoreCardName.Text = global::Mono.Unix.Catalog.GetString("Fighter 1 vs Fighter 2");
		this.entryScoreCardName.IsEditable = true;
		this.entryScoreCardName.WidthChars = 3;
		this.entryScoreCardName.InvisibleChar = '•';
		this.statusbarFooter.Add(this.entryScoreCardName);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.statusbarFooter[this.entryScoreCardName]));
		w21.Position = 1;
		this.vbox1.Add(this.statusbarFooter);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.statusbarFooter]));
		w22.Position = 7;
		w22.Expand = false;
		w22.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 566;
		this.DefaultHeight = 556;
		this.textviewFightComment.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ExitAction1.Activated += new global::System.EventHandler(this.OnExit);
		this.NewScoreCardAction.Activated += new global::System.EventHandler(this.OnNewScoreCardActionActivated);
		this.DeleteScoreCardAction.Activated += new global::System.EventHandler(this.OnDeleteScoreCardActionActivated);
	}
}
