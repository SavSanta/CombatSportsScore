//
//  Fighter.cs
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
namespace CombatSportsScore
{
    public class Fighter
    {
        private string name;
        private string stance;
        private string height;
        private byte reach;
        private byte weight;
        private byte age;
        private byte[] rounds = new byte[1];
        private ushort score;


        public Fighter()
        {
            this.name = "A Fighter";

        }

        public Fighter(string name)
        {
            this.name = name;
        }

        public Fighter(string name, byte numofrds)
        {
            this.name = name;
            this.rounds = new byte[numofrds];
        }


        public ushort Score
        {
            set
            {
                if (!(this.rounds is null) || this.rounds.Length != 0)
                {
                    ushort sum = 0;

                    for (int i = 0; i < this.rounds.Length; i++)
                    {
                        sum += this.rounds[i];
                    }

                    this.score = sum;
                }

            }

            get { return this.score; }
        }


    }

}
