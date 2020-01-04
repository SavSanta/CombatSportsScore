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
using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

   
    private CombatSportsScore.ScoreCard main_Card;
    private CombatSportsScore.Round[] main_Rounds;


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
                //popupFighters.SetResponseSensitive((ResponseType) 200, false);

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
                    this.main_Card = new CombatSportsScore.ScoreCard(Convert.ToByte(comboNumRounds.Entry.Text), entryFighter1.Text.Trim(), entryFighter2.Text.Trim());
                    PopulateUI();
                }

                popupFighters.Destroy();
            }

        }

        popupNumRounds.Destroy();
    }


    public void PopulateUI()
    {
        this.labelScoreCardID.LabelProp = "ID: " + this.main_Card.ScoreID;
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
        //Re-Enable Save Option In the Menu
    }

    public void DePopulateUI()
    {
        this.main_Card = new CombatSportsScore.ScoreCard();
        this.labelScoreCardID.LabelProp += this.main_Card.ScoreID;
        this.lblFighter1Name.LabelProp = this.main_Card.Fighter1.Name;
        this.lblFighter2Name.LabelProp = this.main_Card.Fighter2.Name;
        this.labelDate.LabelProp = "MM-DD-YYYY";
        this.entryScoreCardName.Text = this.main_Card.ScoreTitle;
        this.GtkScrolledWindow.Hide();
        this.frameTotalScore.Hide();
        this.textviewFightComment.Hide();
        this.statusbarFooter.Hide();
        //De-Enable Save Option In the Menu
    }

}
