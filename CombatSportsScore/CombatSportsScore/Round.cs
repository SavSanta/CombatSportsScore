//
// Round.cs
//
//  Author:
//      Savsanta - @savsantax
//
// Copyright (c) 2019 
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
    public class Round
    {
        private byte score1;
        private byte score2;
        bool isSwing;
        bool isKnockdown;
        bool isDeduction;
        private string roundcomment;



        public Round()
        {
        }

        public Round(byte red, byte blue)
        {
            this.score1 = red;
            this.score2 = blue;
        }

        public Round(byte red, byte blue, string comment)
        {
            this.score1 = red;
            this.score2 = blue;
            this.roundcomment = comment;
        }

        public byte Score1 
        {
            get { return this.score1; }
            set { this.score1 = value; }
        }

        public byte Score2
        {
            get { return this.score2; }
            set { this.score2 = value; }
        }


    }
}
