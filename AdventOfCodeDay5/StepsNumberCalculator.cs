using System;
using System.Collections.Generic;

namespace AdventOfCodeDay5
{
    public class StepsNumberCalculator
    {
        private Dictionary<double, double> puzzle;
        private double actualFocus;

        public Dictionary<double, double> Puzzle { get => puzzle; set => puzzle = value; }

        private StepsNumberCalculator(Dictionary<double, double> puzzle)
        {
            this.Puzzle = puzzle;
            this.actualFocus = 1;
        }


        #region Factory
        public static StepsNumberCalculator Create(List<double> inputs)
        {
            Dictionary<double, double> puzzle = new Dictionary<double, double>();
            int i = 1;
            foreach (var input in inputs)
            {
                puzzle.Add(i, input);
                i++;
            }

            return new StepsNumberCalculator(puzzle);
        }
        #endregion



        private void MoveToNextKey(double actualFocusKey)
        {
            this.actualFocus += puzzle[actualFocusKey];
            ModifyCurrentKey(actualFocusKey);
        }

        private void ModifyCurrentKey(double actualFocusKey)
        {
            if (puzzle[actualFocusKey] >= 3)
                puzzle[actualFocusKey] -= 1;
            else
            {
                puzzle[actualFocusKey] += 1;
            }
        }


        //private void ModifyCurrentKey(double actualFocusKey)
        //{
        //    puzzle[actualFocusKey] += 1;
        //}

        internal double GetFocus()
        {
            return actualFocus;
        }

        public double Calculate()
        {
            double result = 0;
            while(puzzle.ContainsKey(actualFocus))
            {
                MoveToNextKey(actualFocus);
                result += 1;
            }

            return result;
        }
    }
}
