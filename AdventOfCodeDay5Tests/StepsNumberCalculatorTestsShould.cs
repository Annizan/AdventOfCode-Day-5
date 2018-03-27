using System;
using System.Collections.Generic;
using AdventOfCodeDay5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;

namespace AdventOfCodeDay5Tests
{
    public class UnitTest1
    {
        [Test]
        public void Create_A_Dictionnary_With_The_List_Of_Inputs()
        {
            List<double> inputs = new List<double>
                                {
                                    0,
                                    3,
                                    0,
                                    1,
                                    -3
                                };
            StepsNumberCalculator stepsNumberCalculator = StepsNumberCalculator.Create(inputs);
            Check.That(stepsNumberCalculator.Puzzle.Count()).IsEqualTo(5);
        }
        
        [Test]
        public void Rename()
        {
            List<double> inputs = new List<double>
                                {
                                    0,
                                    3,
                                    0,
                                    1,
                                    -3
                                };

            var stepsNumberCalculator = StepsNumberCalculator.Create(inputs);
            Check.That(stepsNumberCalculator.Calculate()).IsEqualTo(5);
        }

        [Test]
        public void Rename2()
        {
            List<double> inputs = new List<double>
                                {
                                    1,
                                    0,
                                    0,
                                    1,
                                    -1
                                };

            var stepsNumberCalculator = StepsNumberCalculator.Create(inputs);
            Check.That(stepsNumberCalculator.Calculate()).IsEqualTo(8);
        }
    }
}
