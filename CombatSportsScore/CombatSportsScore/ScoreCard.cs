//
//  ScoreCard.cs
//
//  Author:
//      Savsanta - @savsantax
//
//  Copyright (c) 2019 
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:

//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.

//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.

using System;
using static System.Console;

namespace CombatSportsScore
{
    public class ScoreCard
    {
        private static int currentScoreID;

        private int scoreID;
        private string scoreTitle;
        private DateTime date;
        private ushort[] scoreTotal; 
        private Round[] rounds;
        Fighter fighter1;
        Fighter fighter2;


        public ScoreCard(byte numofrds, string fighter1, string fighter2)
        {
            this.scoreID = GetNextScoreCardID();
            this.rounds = new Round[numofrds];
            this.fighter1 = new Fighter(fighter1);
            this.fighter2 = new Fighter(fighter1);
        }

        public void TallyScoreCard() 
        {

            if ( !(this.rounds is null) || this.rounds.Length != 0 )
            {
                ushort tally1 = 0;
                ushort tally2 = 0;

                for (int i = 0; i < this.rounds.Length; i++)
                {
                    tally1 += this.rounds[i].Score1;
                    tally2 += this.rounds[i].Score2;
                }

                this.scoreTotal = new ushort[] { tally1, tally2 };
                WriteLine("Score is {}: {} to {}: {}", this.fighter1, this.scoreTotal[0], this.fighter2,this.scoreTotal[1]);

            }

        }

        protected int GetNextScoreCardID()
        {
            return ++currentScoreID;
        }




    }
}
