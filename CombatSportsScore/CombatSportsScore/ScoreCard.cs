//
//  ScoreCard.cs
//
//  Author:
//      Savsanta - @savsantax
//
//  Copyright (c) 2020
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
using System.Linq;
using static System.Console;

namespace CombatSportsScore
{

    public class ScoreCard
    {
        protected static int currentScoreID;
         
        private int scoreID;
        private string scoreTitle;
        private DateTime date;
        private ushort[] scoreTotal; 
        private Round[] rounds;
        Fighter fighter1;
        Fighter fighter2;
        private string fightComment;


        public ScoreCard() 
        {
            this.Fighter1 = new Fighter("");
            this.Fighter2 = new Fighter("");

        }

        public ScoreCard(byte numofrds, string fighter1, string fighter2)
        {
            this.ScoreID = ScoreCard.GetNextScoreCardID(this);
            // Create array and initialize each element, since Array of Custom Classes default to "null".
            this.Rounds = Enumerable.Range(0, numofrds).Select(i => new Round()).ToArray();
            this.Fighter1 = new Fighter(fighter1);
            this.Fighter2 = new Fighter(fighter2);
            this.Date = DateTime.Now;
            this.ScoreTitle = $"{Fighter1.Name} vs {Fighter2.Name}";
        }

        protected static int GetNextScoreCardID(ScoreCard instance) => ++ScoreCard.currentScoreID;
        public DateTime Date { get => date; set => date = value; }
        public ushort[] ScoreTotal { get => scoreTotal; set => scoreTotal = value; }
        public Round[] Rounds { get => rounds; set => rounds = value; }
        public string ScoreTitle { get => scoreTitle; set => scoreTitle = value; }
        public Fighter Fighter1 { get => fighter1; set => fighter1 = value; }
        public Fighter Fighter2 { get => fighter2; set => fighter2 = value; }
        public int ScoreID { get => scoreID; set => scoreID = value; }
        public string FightComment { get => fightComment; set => fightComment = value; }

        public void TallyScoreCard() 
        {

            if ( this.Rounds != null || this.Rounds.Length != 0 )
            {
                ushort tally1 = 0;
                ushort tally2 = 0;

                for (int i = 0; i < this.Rounds.Length; i++)
                {
                    tally1 += this.Rounds[i].Score1;
                    tally2 += this.Rounds[i].Score2;
                }

                this.ScoreTotal = new ushort[] { tally1, tally2 };
                WriteLine("Score is {}: {} to {}: {}", this.Fighter1, this.ScoreTotal[0], this.Fighter2, this.ScoreTotal[1]);

            }

        }

    }
}
