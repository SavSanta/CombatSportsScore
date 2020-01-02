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

    protected void OnNewScoreCardActionActivated(object sender, EventArgs e)
    {
        this.Title = global::Mono.Unix.Catalog.GetString("SNappyHoles");

        Dialog popupNumRounds = new Gtk.Dialog("New ScoreCard", this, DialogFlags.Modal, Stock.Ok, 200, Stock.Cancel, 400);

        Label enterRounds = new Label("Number of Rounds");
        popupNumRounds.VBox.Add(enterRounds);

        int[] list = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
        Combo comboNumRounds = new Combo();
        comboNumRounds.PopdownStrings = Array.ConvertAll(list, ele => ele.ToString());
        comboNumRounds.DisableActivate();
        comboNumRounds.SetValueInList(true, false);
        popupNumRounds.VBox.Add(comboNumRounds);


        popupNumRounds.ShowAll();
        int response_value = popupNumRounds.Run();
        popupNumRounds.Destroy();

    }

    protected void OnDeleteScoreCardActionActivated(object sender, EventArgs e)
    {
    }

}

