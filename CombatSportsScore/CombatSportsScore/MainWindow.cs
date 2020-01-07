//
//  MainWindow.cs
//
//  Author:
//      Savsanta - @savsantax
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using Gtk;
using System;
using System.IO;
using Newtonsoft.Json;

public partial class MainWindow : Gtk.Window
{

    private CombatSportsScore.ScoreCard main_Card;


    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnExit(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnDeleteScoreCardActionActivated(object sender, EventArgs e)
    {
        DePopulateUI();
    }

    void OnRDWidgetExposureEvent(object o, Gtk.WidgetEventArgs args)
    {
        PopulateTotals();
    }

    protected void OnEntryScoreCardTitleUpdate(object sender, EventArgs args)
    {
        if (this.main_Card != null)
        {
            this.main_Card.ScoreTitle = (sender as Entry).Text;
        }
    }

    protected void OnBufferFightCommentUpdate(object sender, EventArgs args)
    {
        if (this.main_Card != null)
        {
            this.main_Card.FightComment = (sender as TextBuffer).Text;
        }
    }

    protected void OnNewScoreCardActionActivated(object sender, EventArgs e)
    {

        Dialog popupNumRounds = new Gtk.Dialog("New ScoreCard", this, DialogFlags.Modal, Stock.Ok, 200, Stock.Cancel, 400);

        Label enterRounds = new Label("Number of Rounds");
        popupNumRounds.VBox.Add(enterRounds);

        int[] list = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
        #pragma warning disable CS0612 // Type or member is obsolete
        Combo comboNumRounds = new Combo();
        #pragma warning restore CS0612 // Type or member is obsolete
        comboNumRounds.PopdownStrings = Array.ConvertAll(list, ele => ele.ToString());
        comboNumRounds.DisableActivate();
        comboNumRounds.SetValueInList(true, false);
        popupNumRounds.VBox.Add(comboNumRounds);

        popupNumRounds.ShowAll();
        int response_value = popupNumRounds.Run();

        if (response_value == 200)
        {
            {
                Dialog popupFighters = new Gtk.Dialog("Enter Fighters", this, DialogFlags.Modal, Stock.Ok, 200, Stock.Cancel, 400);
                popupFighters.BorderWidth = 4;

                HBox hbox = new HBox(false, 8);
                hbox.BorderWidth = 8;
                popupFighters.VBox.PackStart(hbox, false, false, 0);

                Image stock = new Image(Stock.DialogQuestion, IconSize.Dialog);
                hbox.PackStart(stock, false, false, 0);

                Table table = new Table(2, 2, false);
                table.RowSpacing = 4;
                table.ColumnSpacing = 4;
                hbox.PackStart(table, true, true, 0);

                Label label = new Label("Fighter 1");
                table.Attach(label, 0, 1, 0, 1);
                Entry entryFighter1 = new Entry();
                table.Attach(entryFighter1, 1, 2, 0, 1);

                label = new Label("Fighter 2");
                table.Attach(label, 0, 1, 1, 2);
                Entry entryFighter2 = new Entry();
                table.Attach(entryFighter2, 1, 2, 1, 2);

                entryFighter1.MaxLength = 40;
                entryFighter2.MaxLength = 40;

                hbox.ShowAll();

                int response_value2 = popupFighters.Run();
                if (response_value2 == 200)
                {

                    DePopulateUI();
                    DePopulateRDTable();

                    this.main_Card = new CombatSportsScore.ScoreCard(Convert.ToByte(comboNumRounds.Entry.Text), entryFighter1.Text.Trim(), entryFighter2.Text.Trim());
                    PopulateRDTable(Convert.ToByte(comboNumRounds.Entry.Text));
                    PopulateUI();
                    PopulateTotals();

                }

                popupFighters.Destroy();
            }

        }

        popupNumRounds.Destroy();
    }


    protected void OnSaveScoreCardActionActivated(object sender, EventArgs e)
    {
        string personaldocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        Gtk.FileChooserDialog dirchooser = new Gtk.FileChooserDialog("Choose Save Directory",
            this, FileChooserAction.CreateFolder,
            "Cancel", 400,
            "Open", 200);

        /* TODO - Add Convenience Default Preferred Location Here */

        dirchooser.LocalOnly = true;
        dirchooser.CurrentName = personaldocs;

        /* TODO - Separate this out to it's own class file so I can call infintely on null path returns in Nautilus */

        if (dirchooser.Run() == 200)
        {
            string fpath = dirchooser.Filename;
            if (string.IsNullOrEmpty(fpath))
            {
                fpath = personaldocs;
            }

            this.SaveCard(fpath);

        }

        dirchooser.Destroy();
    }


    public void PopulateUI()
    {
        this.labelScoreCardID.LabelProp = "ID: " + this.main_Card.ScoreID;
        // Sidenote - Investigate changing both sets of <b> to <x-large> breaks a lot of the other labels
        this.lblFighter1Name.LabelProp = "<b>" + this.main_Card.Fighter1.Name + "</b>";
        this.lblFighter2Name.LabelProp = "<b>" + this.main_Card.Fighter2.Name + "</b>";
        this.lblFighter1Name.UseMarkup = true;
        this.lblFighter2Name.UseMarkup = true;

        this.labelDate.LabelProp = this.main_Card.Date.ToShortDateString();
        this.entryScoreCardName.Text = this.main_Card.ScoreTitle;
        this.GtkScrolledWindow.Show();
        this.frameTotalScore.Show();
        this.textviewFightComment.Show();
        this.statusbarFooter.Show();
        this.SaveScoreCardAction.Sensitive = true;
    }

    public void DePopulateUI()
    {
        DePopulateRDTable();
        this.main_Card = new CombatSportsScore.ScoreCard();
        this.labelScoreCardID.LabelProp = "ID: x";
        this.lblFighter1Name.LabelProp = this.main_Card.Fighter1.Name;
        this.lblFighter2Name.LabelProp = this.main_Card.Fighter2.Name;
        this.labelDate.LabelProp = "MM-DD-YYYY";
        this.entryScoreCardName.Text = this.main_Card.ScoreTitle;
        this.GtkScrolledWindow.Hide();
        this.frameTotalScore.Hide();
        this.textviewFightComment.Hide();
        this.statusbarFooter.Hide();
        this.SaveScoreCardAction.Sensitive = false;
    }


    public void PopulateRDTable(byte numofrounds) 
    {
        this.rdtable.Resize(numofrounds, 1);
        this.rdwidget = new CombatSportsScore.RDWidget[numofrounds];

        for (uint i = 0; i < numofrounds; i++)
        {
            this.rdwidget[i] = new CombatSportsScore.RDWidget();
            this.rdwidget[i].Events = ((global::Gdk.EventMask)(256));
            this.rdwidget[i].Name = "rdwidget" + (i + 1);
            this.rdwidget[i].RoundNumber = Convert.ToString(i + 1);
            this.rdtable.Attach(this.rdwidget[i], 0, 1, 0 + i, 1 + i, (AttachOptions)1, (AttachOptions)0 , 0, 0);
            this.rdwidget[i].WidgetEvent += OnRDWidgetExposureEvent;
            rdtable.ShowAll();
        }
    }

    public void DePopulateRDTable()
    {
        try
        {
            foreach (CombatSportsScore.RDWidget i in this.rdwidget)
            {
                this.rdtable.Remove(i);
            }

            this.rdwidget = new CombatSportsScore.RDWidget[1];
            this.rdtable.Resize(1, 1);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"NullReferenceException Occured.\n No Existing ScoreCard to Depopulate \n{ex}");
        }

    }

    public void PopulateTotals()
    {
        int total1 = 0;
        int total2 = 0;

        int count = 0;
        for (var widge = this.rdwidget.GetEnumerator(); widge.MoveNext(); count++)
        {
            CombatSportsScore.RDWidget item = (CombatSportsScore.RDWidget) widge.Current;

            // Update the Backend - Round Specific Members
            main_Card.Rounds[count].Score1 = (byte) item.FighterScore1;
            main_Card.Rounds[count].Score2 = (byte) item.FighterScore2;
            main_Card.Rounds[count].IsKnockdown = item.IsKnockdown;
            main_Card.Rounds[count].IsDeduction = item.IsDeduction;
            main_Card.Rounds[count].IsSwing = item.IsSwing;

            // Update the Frontend - GUI Total Scores frame
            total1 += item.FighterScore1;
            total2 += item.FighterScore2;

        }
        
        this.labelTotalScore1.Markup = "<span fgcolor='red' size='x-large' weight='heavy'>" + total1.ToString() +  "</span>";
        this.labelTotalScore2.Markup = "<span fgcolor='blue' size='x-large' weight='heavy'>" + total2.ToString() + "</span>";

    }


    private void SaveCard(string savepath)
    {
        if (this.main_Card != null)
        {
            string dataobj;
            string savefilename = this.main_Card.ScoreTitle;
            var invalids = System.IO.Path.GetInvalidFileNameChars();

            dataobj = JsonConvert.SerializeObject(this.main_Card);
            savefilename = savefilename.Trim();

            // Sanitize filename for the OS
            savefilename = savefilename.Replace(' ', '_');
            savefilename = string.Join("_", savefilename.Split(invalids, StringSplitOptions.RemoveEmptyEntries));

            // Want/should serialize program version but I dont really expect major changes while not databased yet 
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(savepath, savefilename)))
            {
                outputFile.WriteLine(dataobj);
            }


        }
    }


}

