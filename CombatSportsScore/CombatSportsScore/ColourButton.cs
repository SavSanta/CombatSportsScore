//
// ColourButton.cs
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
using Gtk;
using System;
using System.Drawing;

namespace CombatSportsScore
{
    [System.ComponentModel.ToolboxItem(true)]
    public class ColourButton : Gtk.Bin
    {

        string[] points = new string[] { "10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "-" };
        private Gtk.HBox box;
        private Gtk.Label lblpoints;
        private Gtk.Button button;


        public ColourButton() : base ()
        {
            Build();
        }

        protected override void OnSizeAllocated(Gdk.Rectangle allocation)
        {
            if (this.Child != null)
            {
                this.Child.Allocation = allocation;
            }
        }

        protected override void OnSizeRequested(ref Requisition requisition)
        {
            if (this.Child != null)
            {
                requisition = this.Child.SizeRequest();
            }
        }

        static Widget color_label_box(string label_text)
        {
            // Create box to hold label
            HBox box = new HBox(false, 0);
            box.BorderWidth = 2;

            // Create label
            Label label = new Label(label_text);

            return (Widget)null;
        }

        private void Build() 
        {
            box = new HBox(false, 0);
            box.SetSizeRequest(40, 40);
            box.BorderWidth = 2;

            button = new Button();

            lblpoints = new Label();
            lblpoints.Text = points[0];

            button.Add(lblpoints);
            button.ShowAll();

            box.Add(this.button);
            box.ShowAll();

            this.Add(box);


        }


    }
}
