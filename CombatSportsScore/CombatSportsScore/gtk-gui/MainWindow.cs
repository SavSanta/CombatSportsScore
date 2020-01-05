
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

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.Table rdtable;

	private global::CombatSportsScore.RDWidget[] rdwidget;

	private global::Gtk.Frame frameTotalScore;

	private global::Gtk.Alignment GtkAlignment3;

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
		this.FileAction = new global::Gtk.Action("FileAction", "File", null, null);
		this.FileAction.ShortLabel = "File";
		w1.Add(this.FileAction, null);
		this.LoadAction = new global::Gtk.Action("LoadAction", "Load", null, null);
		this.LoadAction.ShortLabel = "Load";
		w1.Add(this.LoadAction, null);
		this.SaveAction = new global::Gtk.Action("SaveAction", "Save", null, null);
		this.SaveAction.ShortLabel = "Save";
		w1.Add(this.SaveAction, null);
		this.ExitAction = new global::Gtk.Action("ExitAction", "Exit", null, null);
		this.ExitAction.ShortLabel = "Exit";
		w1.Add(this.ExitAction, null);
		this.FileAction1 = new global::Gtk.Action("FileAction1", "File", null, null);
		this.FileAction1.ShortLabel = "File";
		w1.Add(this.FileAction1, null);
		this.LoadDatabaseAction = new global::Gtk.Action("LoadDatabaseAction", "Load Database", null, null);
		this.LoadDatabaseAction.ShortLabel = "Load Database";
		w1.Add(this.LoadDatabaseAction, null);
		this.SaveDatabaseAction = new global::Gtk.Action("SaveDatabaseAction", "Save Database", null, null);
		this.SaveDatabaseAction.ShortLabel = "Save Database";
		w1.Add(this.SaveDatabaseAction, null);
		this.ExitAction1 = new global::Gtk.Action("ExitAction1", "Exit", null, null);
		this.ExitAction1.ShortLabel = "Exit";
		w1.Add(this.ExitAction1, null);
		this.HelpAction = new global::Gtk.Action("HelpAction", "Help", null, null);
		this.HelpAction.ShortLabel = "Help";
		w1.Add(this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", "About", null, null);
		this.AboutAction.ShortLabel = "About";
		w1.Add(this.AboutAction, null);
		this.NewScoreCardAction = new global::Gtk.Action("NewScoreCardAction", "New ScoreCard", null, null);
		this.NewScoreCardAction.ShortLabel = "New ScoreCard";
		w1.Add(this.NewScoreCardAction, "<Primary>n");
		this.DeleteScoreCardAction = new global::Gtk.Action("DeleteScoreCardAction", "Delete ScoreCard", null, null);
		this.DeleteScoreCardAction.ShortLabel = "Delete ScoreCard";
		w1.Add(this.DeleteScoreCardAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.WidthRequest = 455;
		this.Name = "MainWindow";
		this.Title = "Combat Sports Scorecard";
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		this.AllowShrink = true;
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
		this.lblFighter1Name.LabelProp = "Fighter 1";
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
		this.labelDate.LabelProp = "MM-DD-YYYY";
		this.GtkAlignmentDate.Add(this.labelDate);
		this.frameDate.Add(this.GtkAlignmentDate);
		this.GtkLabel3 = new global::Gtk.Label();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.Xpad = 113;
		this.GtkLabel3.LabelProp = "<b> Date </b>";
		this.GtkLabel3.UseMarkup = true;
		this.GtkLabel3.Justify = ((global::Gtk.Justification)(2));
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
		this.lblFighter2Name.LabelProp = "Fighter 2";
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
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w12 = new global::Gtk.Viewport();
		w12.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.rdtable = new global::Gtk.Table(((uint)(1)), ((uint)(1)), false);
		this.rdtable.Name = "rdtable";
		this.rdtable.RowSpacing = ((uint)(1));
        // Container child rdtable.Gtk.Table+TableChild
        this.rdwidget = new global::CombatSportsScore.RDWidget[1];
        this.rdwidget[0] = new global::CombatSportsScore.RDWidget();
		this.rdwidget[0].Events = ((global::Gdk.EventMask)(256));
		this.rdwidget[0].Name = "rdwidget1";
		this.rdwidget[0].RoundNumber = "1";
		this.rdtable.Add(this.rdwidget[0]);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.rdtable[this.rdwidget[0]]));
		w13.XOptions = ((global::Gtk.AttachOptions)(0));
		w13.YOptions = ((global::Gtk.AttachOptions)(0));
		w12.Add(this.rdtable);
		this.GtkScrolledWindow.Add(w12);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w16.Position = 4;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frameTotalScore = new global::Gtk.Frame();
		this.frameTotalScore.Name = "frameTotalScore";
		this.frameTotalScore.BorderWidth = ((uint)(2));
		// Container child frameTotalScore.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(4));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.hpaneTotalScore = new global::Gtk.HPaned();
		this.hpaneTotalScore.CanFocus = true;
		this.hpaneTotalScore.Name = "hpaneTotalScore";
		this.hpaneTotalScore.Position = 219;
		this.hpaneTotalScore.BorderWidth = ((uint)(10));
		// Container child hpaneTotalScore.Gtk.Paned+PanedChild
		this.labelTotalScore1 = new global::Gtk.Label();
		this.labelTotalScore1.Name = "labelTotalScore1";
		this.labelTotalScore1.LabelProp = "<span fgcolor=\"red\" size=\"x-large\" weight=\"heavy\" > 0 </span>";
		this.labelTotalScore1.UseMarkup = true;
		this.labelTotalScore1.Wrap = true;
		this.hpaneTotalScore.Add(this.labelTotalScore1);
		global::Gtk.Paned.PanedChild w17 = ((global::Gtk.Paned.PanedChild)(this.hpaneTotalScore[this.labelTotalScore1]));
		w17.Resize = false;
		// Container child hpaneTotalScore.Gtk.Paned+PanedChild
		this.labelTotalScore2 = new global::Gtk.Label();
		this.labelTotalScore2.Name = "labelTotalScore2";
		this.labelTotalScore2.LabelProp = "<span fgcolor=\"blue\" size=\"x-large\" weight=\"heavy\" > 0 </span>";
		this.labelTotalScore2.UseMarkup = true;
		this.hpaneTotalScore.Add(this.labelTotalScore2);
		this.GtkAlignment3.Add(this.hpaneTotalScore);
		this.frameTotalScore.Add(this.GtkAlignment3);
		this.GtkLabelScore = new global::Gtk.Label();
		this.GtkLabelScore.Name = "GtkLabelScore";
		this.GtkLabelScore.LabelProp = "<b> Score </b>";
		this.GtkLabelScore.UseMarkup = true;
		this.GtkLabelScore.Justify = ((global::Gtk.Justification)(1));
		this.frameTotalScore.LabelWidget = this.GtkLabelScore;
		this.vbox1.Add(this.frameTotalScore);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frameTotalScore]));
		w21.Position = 5;
		w21.Expand = false;
		w21.Fill = false;
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
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrollwindowFightComment]));
		w23.Position = 6;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbarFooter = new global::Gtk.Statusbar();
		this.statusbarFooter.Name = "statusbarFooter";
		this.statusbarFooter.Spacing = 6;
		// Container child statusbarFooter.Gtk.Box+BoxChild
		this.labelScoreCardID = new global::Gtk.Label();
		this.labelScoreCardID.Name = "labelScoreCardID";
		this.labelScoreCardID.LabelProp = "ID: ";
		this.statusbarFooter.Add(this.labelScoreCardID);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.statusbarFooter[this.labelScoreCardID]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child statusbarFooter.Gtk.Box+BoxChild
		this.entryScoreCardName = new global::Gtk.Entry();
		this.entryScoreCardName.CanFocus = true;
		this.entryScoreCardName.Name = "entryScoreCardName";
		this.entryScoreCardName.Text = "Fighter 1 vs Fighter 2";
		this.entryScoreCardName.IsEditable = true;
		this.entryScoreCardName.WidthChars = 3;
		this.entryScoreCardName.InvisibleChar = '•';
		this.statusbarFooter.Add(this.entryScoreCardName);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.statusbarFooter[this.entryScoreCardName]));
		w25.Position = 1;
		this.vbox1.Add(this.statusbarFooter);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.statusbarFooter]));
		w26.Position = 7;
		w26.Expand = false;
		w26.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 492;
		this.DefaultHeight = 556;
		this.GtkScrolledWindow.Hide();
		this.frameTotalScore.Hide();
		this.textviewFightComment.Hide();
		this.statusbarFooter.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ExitAction1.Activated += new global::System.EventHandler(this.OnExit);
		this.NewScoreCardAction.Activated += new global::System.EventHandler(this.OnNewScoreCardActionActivated);
		this.DeleteScoreCardAction.Activated += new global::System.EventHandler(this.OnDeleteScoreCardActionActivated);
	}
}
