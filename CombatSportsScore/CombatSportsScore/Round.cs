//
// Round.cs
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
    public class Round
    {
        private byte score1;
        private byte score2;
        private bool isKnockdown;
        private bool isDeduction;
        private bool isSwing;


        public Round()
        {
        }

        public Round(byte red, byte blue)
        {
            this.score1 = red;
            this.score2 = blue;
        }

        public Round(byte red, byte blue, bool isKnockdown, bool isDeduction, bool isSwing)
        {
            this.score1 = red;
            this.score2 = blue;
            this.IsKnockdown = isKnockdown;
            this.IsDeduction = isDeduction;
            this.IsSwing = isSwing;
        }


        public byte Score1 { get => score1; set => score1 = value; }
        public byte Score2 { get => score2; set => score2 = value; }
        public bool IsKnockdown { get => isKnockdown; set => isKnockdown = value; }
        public bool IsDeduction { get => isDeduction; set => isDeduction = value; }
        public bool IsSwing { get => isSwing; set => isSwing = value; }
    }
}
