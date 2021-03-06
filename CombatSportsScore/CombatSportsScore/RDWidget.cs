﻿//
// RDWidget.cs
//
//  Author:
//      Savsanta - @savsantax
//
// Copyright (c) 2020 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
namespace CombatSportsScore
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class RDWidget : Gtk.Bin
    {
        private string roundNumber;


        public RDWidget()
        {
            this.Build();
        }

        public RDWidget(int fscore1, int fscore2, bool iskd, bool isdd, bool issw)
        {
            this.Build();
            this.FighterScore1 = fscore1;
            this.FighterScore2 = fscore2;
            this.IsKnockdown = iskd;
            this.IsDeduction = isdd;
            this.IsSwing = issw;
        }

        public bool IsKnockdown
        {
            get => this.toggleKD.Active;
            set => this.toggleKD.Active = value;
        }

        public bool IsDeduction
        {
            get => this.toggleFoul.Active;
            set => this.toggleFoul.Active = value;
        }

        public bool IsSwing
        {
            get => this.toggleSwing.Active;
            set => this.toggleSwing.Active = value;
        }

        public string RoundNumber
        {
            get { return this.roundNumber; }
            set
            {
                this.roundNumber = value;
                this.labelRound.Text = $"Round {value}";
            }
        }

        public int FighterScore1
        {
            get
            {

                try
                {
                    int result = this.colourbutton1.RoundPoints;
#if DEBUG
                    Console.WriteLine($" Returning Score of '{result}'");
#endif
                    return result;
                }
                catch (FormatException)
                {
#if DEBUG
                    Console.WriteLine($"Exception Occured Returning Zero for '{this.colourbutton1.RoundPoints}'");
#endif
                    return 0;
                }

            }
            set => this.colourbutton1.RoundPoints = value;

        }


        public int FighterScore2
        {
            get
            {

                try
                {
                    int result = this.colourbutton2.RoundPoints;
#if DEBUG
                    Console.WriteLine(result);
#endif
                    return result;
                }
                catch (FormatException)
                {
#if DEBUG
                    Console.WriteLine($" Returning Zero for '{this.colourbutton2.RoundPoints}'");
#endif
                    return 0;
                }

            }
            set => this.colourbutton2.RoundPoints = value;

        }

    }
}
