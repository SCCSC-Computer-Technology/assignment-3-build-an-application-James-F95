using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace James_Fowler_CPT206_Lab_2
{
    internal class Class1
    {
        public class StateData
        {
            public string State { get; set; }
            public string Abbreviation { get; set; }
            public string Capitol { get; set; }
            public int Population { get; set; }
            public string StateFlower { get; set; }
            public string StateBird { get; set; }
            public string StateNickname { get; set; }
            public string LargestCity { get; set; }
            public string SecondLargestCity { get; set; }
            public string ThirdLargestCity { get; set; }
            public decimal MedianIncome { get; set; }
            public int ProgrammingJobs { get; set; }
            public int TotalEmployment { get; set; }
            public double PercentageOfProgrammingJobs { get; set; }
            public string FlagDescription { get; set; }

            // Constructor
            public StateData(string state, string abbreviation, string capitol, int population,
                             string stateFlower, string stateBird, string stateNickname,
                             string largestCity, string secondLargestCity, string thirdLargestCity,
                             decimal medianIncome, int programmingJobs, int totalEmployment,
                             double percentageOfProgrammingJobs, string flagDescription)
            {
                State = state;
                Abbreviation = abbreviation;
                Capitol = capitol;
                Population = population;
                StateFlower = stateFlower;
                StateBird = stateBird;
                StateNickname = stateNickname;
                LargestCity = largestCity;
                SecondLargestCity = secondLargestCity;
                ThirdLargestCity = thirdLargestCity;
                MedianIncome = medianIncome;
                ProgrammingJobs = programmingJobs;
                TotalEmployment = totalEmployment;
                PercentageOfProgrammingJobs = percentageOfProgrammingJobs;
                FlagDescription = flagDescription;
            }
            
            
            }

        }
    }

