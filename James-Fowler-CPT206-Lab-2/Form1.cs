using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace James_Fowler_CPT206_Lab_2
{
    
    public partial class Form1 : Form
    {

        private List<StateData> statesData;

        public Form1()
        {
            InitializeComponent();
            InitalizeStatesComboBox();
        }


            private void InitalizeStatesComboBox()
            {
                statesData = GetStatesData();

                comboBox.Items.Clear();
                comboBox.DisplayMember = "State";

            foreach(StateData state in statesData)
                    {
                    comboBox.Items.Add(state);

                    }
            }


        private List<StateData> GetStatesData()
        {
            return new List<StateData>

            {
                new StateData("Alaska", "AK", "Juneau", 733391, "Forget Me Not", "Wilow ptarmigan", "The Last Frontier",
                  "Anchorage", "Juneau", "Fairbanks", 78236, 500, 329900, 0.15,
                  "The flag consists of a crimson St. Andrew's cross on a white background, with the state's coat of arms in the center."),

                new StateData("Alabama", "AL", "Montgomery", 5024279, "Oak-leaf hydrangea", "YellowHammer", "Yellowhammer State",
                  "Birmingham", "Huntsville", "Montgomery", 57243, 2390, 2169200, 0.11,
                  "The flag features the Big Dipper and the North Star on a blue background. The blue field represents the sky, the sea, and mountain lakes."),

                new StateData("Arkansas", "AR", "Little Rock", 3011524, "Apple blossom", "Mockingbird", "The Natural State",
                  "Little Rock", "Fayetteville", "Fort Smith", 53148, 2090, 1362600, 0.15,
                  "The state flag has 13 rays of red and gold on the top half, representing the original 13 colonies, and the copper star in the center represents Arizona's copper industry."),

                new StateData("Arizona", "AZ", "Phoenix", 7151502, "Saguaro cactus blossom", "Cactus Wren", "The Grand Canyon State",
              "Phoenix", "Tucson", "Mesa", 70220, 2550, 3189300, 0.08,
              "The flag consists of a diamond shape containing 25 white stars on a blue field, with a blue-bordered white diamond in the center."),

                new StateData("California", "CA", "Sacramento", 39538223, "Golden Poppy", "California Valley Quail", "Golden State",
              "Los Angeles", "San Diego", "San Jose", 81278, 19050, 18180700, 0.10,
              "The flag features a white field with a red five-pointed star, a red stripe along the bottom, and a horizontal bar of blue on the top."),

                new StateData("Colorado", "CO", "Denver", 5773714, "Rocky Mountain columbine", "Lark bunting", "Centennial State",
              "Denver", "Colorado Springs", "Aurora", 87689, 2140, 2914000, 0.07,
              "The flag consists of three horizontal stripes of equal width: blue on top, white in the middle, and gold on the bottom. The state's red C is in the center of the white stripe."),

                new StateData("Connecticut", "CT", "Hartford", 3565287, "Mountain laurel", "American Robin", "Constitution State",
              "Bridgeport", "New Haven", "Stamford", 78444, 640, 1805200, 0.04,
              "The flag consists of a white shield with three grapevines, each bearing three bunches of purple grapes, on a field of azure blue."),

                new StateData("Delaware", "DE", "Dover", 973764, "Peach blossom", "Delaware Blue Hen", "First State",
              "Wilmington", "Dover", "Newark", 73111, 630, 689700, 0.09,
              "The flag consists of a buff-colored diamond on a field of colonial blue, with the coat of arms of the state of Delaware inside the diamond."),

                new StateData("Florida", "FL", "Tallahassee", 21477737, "Orange blossom", "Northern Mockingbird", "Sunshine State",
              "Jacksonville", "Miami", "Tampa", 59793, 2670, 9021300, 0.03,
              "The flag consists of a red saltire on a white background, with the seal of Florida in the center."),

                new StateData("Georgia", "GA", "Atlanta", 10617423, "Cherokee Rose", "Brown Thrasher", "Peach State",
              "Atlanta", "Augusta", "Columbus", 61015, 5150, 4998700, 0.10,
              "The flag consists of three red and white stripes, with the state's coat of arms in the top left corner."),

                new StateData("Hawaii", "HI", "Honolulu", 1415872, "Hawaiian Hibiscus", "Nene (Hawaiian Goose)", "Aloha State",
              "Honolulu", "Pearl City", "Hilo", 83312, 1340, 1030300, 0.13,
              "The flag consists of eight alternating horizontal stripes of white, red, and blue, with the Union Jack of the United Kingdom in the top left corner."),

                new StateData("Idaho", "ID", "Boise", 1826156, "Syringa", "Mountain Bluebird", "Gem State",
              "Boise", "Meridian", "Nampa", 63434, 1530, 761600, 0.20,
              "The flag consists of a blue field with the state seal in the center, surrounded by a yellow border."),

                new StateData("Illinois", "IL", "Springfield", 12659682, "Violet", "Northern Cardinal", "Prairie State",
              "Chicago", "Aurora", "Rockford", 69145, 9030, 6678000, 0.14,
              "The flag consists of a white field with the state seal in the center, depicting a bald eagle holding a banner with the state motto."),

                new StateData("Indiana", "IN", "Indianapolis", 6732219, "Peony", "Northern Cardinal", "Hoosier State",
              "Indianapolis", "Fort Wayne", "Evansville", 56987, 3950, 3270100, 0.12,
              "The flag consists of a blue field with 19 gold stars arranged in a circle, symbolizing Indiana's admission as the 19th state."),

                new StateData("Iowa", "IA", "Des Moines", 3155070, "Wild Prairie Rose", "Eastern Goldfinch", "Hawkeye State",
              "Des Moines", "Cedar Rapids", "Davenport", 60523, 2320, 1592400, 0.15,
              "The flag consists of three vertical stripes of blue, white, and red, with the state's name and motto on a blue banner in the center."),

                new StateData("Kansas", "KS", "Topeka", 2913314, "Sunflower", "Western Meadowlark", "Sunflower State",
              "Wichita", "Overland Park", "Kansas City", 60178, 3810, 1465800, 0.26,
              "The flag consists of a dark blue field with the state seal in the center and a sunflower above it."),

                new StateData("Kentucky", "KY", "Frankfort", 4499692, "Goldenrod", "Northern Cardinal", "Bluegrass State",
              "Louisville", "Lexington", "Bowling Green", 54539, 2590, 1926000, 0.13,
              "The flag consists of a blue field with the state seal in the center, depicting two friends embracing over the words \"United We Stand, Divided We Fall.\""),

                new StateData("Louisiana", "LA", "Baton Rouge", 4648794, "Magnolia", "Brown Pelican", "Pelican State",
              "New Orleans", "Baton Rouge", "Shreveport", 49973, 3760, 2015700, 0.19,
              "The flag consists of a blue field with the state seal in the center, depicting a mother pelican feeding her chicks."),

                new StateData("Maine", "ME", "Augusta", 1344212, "White Pine Cone and Tassel", "Black-capped Chickadee", "Pine Tree State",
              "Portland", "Lewiston", "Bangor", 57454, 2380, 646100, 0.37,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a farmer and seaman supporting the shield depicting the North Star."),

                new StateData("Maryland", "MD", "Annapolis", 6045680, "Black-Eyed Susan", "Baltimore Oriole", "Old Line State",
              "Baltimore", "Columbia", "Germantown", 83076, 12410, 3084600, 0.40,
              "The flag consists of the heraldic banner of George Calvert, 1st Baron Baltimore, alternating with the black and gold design of the Calvert family."),

                new StateData("Massachusetts", "MA", "Boston", 6949503, "Mayflower", "Black-capped Chickadee", "Bay State",
              "Boston", "Worcester", "Springfield", 77964, 26780, 4132300, 0.65,
              "The flag consists of a white field with the state coat of arms in the center, featuring a Native American and a colonial broadsword."),

                new StateData("Michigan", "MI", "Lansing", 10045029, "Apple Blossom", "American Robin", "Great Lakes State",
              "Detroit", "Grand Rapids", "Warren", 56526, 22730, 4651600, 0.49,
              "The flag consists of a dark blue field with the state coat of arms in the center, featuring a man standing on a peninsula with one hand raised in a greeting gesture."),

                new StateData("Minnesota", "MN", "St. Paul", 5700671, "Pink and White Lady's Slipper", "Common Loon", "North Star State",
              "Minneapolis", "St. Paul", "Rochester", 70298, 10410, 3230100, 0.32,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a farmer plowing and a Native American riding a horse."),

                new StateData("Mississippi", "MS", "Jackson", 2989260, "Magnolia", "Northern Mockingbird", "Magnolia State",
              "Jackson", "Gulfport", "Southaven", 45005, 1750, 1378900, 0.13,
              "The flag consists of a white field with the state coat of arms in the center, featuring an eagle with spread wings holding a ribbon with the state motto."),

                new StateData("Missouri", "MO", "Jefferson City", 6169270, "Hawthorn", "Eastern Bluebird", "Show Me State",
              "Kansas City", "St. Louis", "Springfield", 59421, 7170, 2930700, 0.24,
              "The flag consists of three horizontal stripes of red, white, and blue, with the state coat of arms in the center."),

                new StateData("Montana", "MT", "Helena", 1084225, "Bitterroot", "Western Meadowlark", "Treasure State",
              "Billings", "Missoula", "Great Falls", 54841, 1670, 484700, 0.35,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a miner's pick and shovel, mountains, and the Great Falls of the Missouri River."),

                new StateData("Nebraska", "NE", "Lincoln", 1952570, "Goldenrod", "Western Meadowlark", "Cornhusker State",
              "Omaha", "Lincoln", "Bellevue", 61968, 2070, 1024700, 0.20,
              "The flag consists of a blue field with the state seal in the center, featuring a steamboat on the Missouri River, a train heading west, and a blacksmith working at his anvil."),

                new StateData("Nevada", "NV", "Carson City", 3139658, "Sagebrush", "Mountain Bluebird", "Silver State",
              "Las Vegas", "Henderson", "Reno", 62543, 5590, 1382900, 0.40,
              "The flag consists of a cobalt blue field with a silver star in the upper left corner and a silver \"Battle Born\" ribbon below the star."),

                new StateData("New Hampshire", "NH", "Concord", 1371246, "Purple Lilac", "Purple Finch", "Granite State",
              "Manchester", "Nashua", "Concord", 78884, 3130, 765400, 0.41,
              "The flag consists of a blue field with the state seal in the center, featuring the frigate USS Raleigh and the motto \"Live Free or Die.\""),

                new StateData("New Jersey", "NJ", "Trenton", 9288994, "Common Meadow Violet", "Eastern Goldfinch", "Garden State",
              "Newark", "Jersey City", "Paterson", 82393, 33140, 4355400, 0.76,
              "The flag consists of a buff-colored field with the state coat of arms in the center, featuring three plows and a horse's head."),

                new StateData("New Mexico", "NM", "Santa Fe", 2117522, "Yucca Flower", "Greater Roadrunner", "Land of Enchantment",
              "Albuquerque", "Las Cruces", "Rio Rancho", 49463, 2360, 1008300, 0.23,
              "The flag consists of a red sun symbol with four groups of rays and a stylized bird, the Zia Pueblo's symbol for the sun."),

                new StateData("New York", "NY", "Albany", 19440469, "Rose", "Eastern Bluebird", "Empire State",
              "New York City", "Buffalo", "Rochester", 71670, 28490, 9722300, 0.29,
              "The flag consists of a dark blue field with the state coat of arms in the center, featuring a ship, a sloop, and a river with mountains in the background."),

                new StateData("North Carolina", "NC", "Raleigh", 10488084, "Dogwood", "Northern Cardinal", "Tar Heel State",
              "Charlotte", "Raleigh", "Greensboro", 54519, 7460, 4819100, 0.15,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a three-part scroll with the dates of the Mecklenburg Declaration of Independence."),

                new StateData("North Dakota", "ND", "Bismarck", 762062, "Wild Prairie Rose", "Western Meadowlark", "Peace Garden State",
              "Fargo", "Bismarck", "Grand Forks", 64657, 1630, 428400, 0.38,
              "The flag consists of a dark blue field with the state coat of arms in the center, featuring a bald eagle, an American Indian on horseback, and a crest with a sheaf of wheat and a plow."),

                new StateData("Ohio", "OH", "Columbus", 11747694, "Scarlet Carnation", "Northern Cardinal", "Buckeye State",
              "Columbus", "Cleveland", "Cincinnati", 59676, 15740, 5679900, 0.28,
              "The flag consists of a red and white bicolor with a blue triangle extending from the hoist, featuring 17 stars and a circle of stars surrounding the Ohio burgee."),

                new StateData("Oklahoma", "OK", "Oklahoma City", 3959353, "Mistletoe", "Scissor-tailed Flycatcher", "Sooner State",
              "Oklahoma City", "Tulsa", "Norman", 54932, 3210, 1887500, 0.17,
              "The flag consists of a blue field with an Osage warrior's circular buckskin shield and seven eagle feathers on a sky blue field."),

                new StateData("Oregon", "OR", "Salem", 4217737, "Oregon Grape", "Western Meadowlark", "Beaver State",
              "Portland", "Salem", "Eugene", 67376, 6830, 2162100, 0.32,
              "The flag consists of a field of navy blue with design elements from the state seal in gold on the obverse side and navy on the reverse side."),

                new StateData("Pennsylvania", "PA", "Harrisburg", 12820878, "Mountain Laurel", "Ruffed Grouse", "Keystone State",
              "Philadelphia", "Pittsburgh", "Allentown", 63098, 29670, 6732200, 0.44,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a shield with a plow, ship, sheaves of wheat, and a bald eagle."),

                new StateData("Rhode Island", "RI", "Providence", 1097379, "Violet", "Rhode Island Red", "Ocean State",
              "Providence", "Warwick", "Cranston", 62571, 3560, 661600, 0.54,
              "The flag consists of a white field with a gold anchor in the center surrounded by 13 gold stars representing the original colonies."),

                new StateData("South Carolina", "SC", "Columbia", 5148714, "Yellow Jessamine", "Carolina Wren", "Palmetto State",
              "Charleston", "Columbia", "North Charleston", 54851, 5360, 2374300, 0.23,
              "The flag consists of a white field with a blue canton containing a white palmetto tree and crescent moon."),

                new StateData("South Dakota", "SD", "Pierre", 884659, "Pasque Flower", "Ring-necked Pheasant", "Mount Rushmore State",
              "Sioux Falls", "Rapid City", "Aberdeen", 57067, 770, 452500, 0.17,
              "The flag consists of a sky-blue field with a state seal in the center, featuring the Great Seal of South Dakota surrounded by the words \"State of South Dakota.\""),

                new StateData("Tennessee", "TN", "Nashville", 6833174, "Iris", "Northern Mockingbird", "Volunteer State",
              "Nashville", "Memphis", "Knoxville", 56905, 10530, 4542900, 0.23,
              "The flag consists of a field of red with a blue circle in the center, containing three white five-pointed stars, representing the three Grand Divisions of the state."),

                new StateData("Texas", "TX", "Austin", 28995881, "Bluebonnet", "Northern Mockingbird", "Lone Star State",
              "Houston", "San Antonio", "Dallas", 61705, 30390, 13132400, 0.23,
              "The flag consists of a vertical blue stripe on the left with a horizontal stripe of white and red on the right, containing one white star."),

                new StateData("Utah", "UT", "Salt Lake City", 3205958, "Sego Lily", "California Gull", "Beehive State",
              "Salt Lake City", "West Valley City", "Provo", 74912, 5760, 1653500, 0.35,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a beehive, a sego lily, and the state motto \"Industry.\""),

                new StateData("Vermont", "VT", "Montpelier", 623347, "Red Clover", "Hermit Thrush", "Green Mountain State",
              "Burlington", "South Burlington", "Rutland", 60076, 3250, 342200, 0.95,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a pine tree, a cow, sheaves of wheat, and the Green Mountains."),

                new StateData("Virginia", "VA", "Richmond", 8626207, "American Dogwood", "Northern Cardinal", "Old Dominion",
              "Virginia Beach", "Norfolk", "Chesapeake", 71535, 25150, 4745300, 0.53,
              "The flag consists of a blue field with the state coat of arms in the center, featuring a woman representing the Roman virtue of virtue, a man representing the Roman virtue of valor, and the state motto \"Sic Semper Tyrannis.\""),

                new StateData("Washington", "WA", "Olympia", 7693612, "Coast Rhododendron", "Willow Goldfinch", "Evergreen State",
              "Seattle", "Spokane", "Tacoma", 76169, 19680, 3989400, 0.49,
              "The flag consists of a dark green field with the state coat of arms in the center, featuring George Washington, a shield with a scene of mountains, a body of water, and a setting sun, with the words \"The Seal of the State of Washington 1889.\""),

                new StateData("West Virginia", "WV", "Charleston", 1778070, "Rhododendron", "Northern Cardinal", "Mountain State",
              "Charleston", "Huntington", "Parkersburg", 51674, 2490, 748500, 0.33,
              "The flag consists of a white field with a navy blue border, featuring the state coat of arms in the center and a wreath of Rhododendron maximum, the state flower."),

                new StateData("Wisconsin", "WI", "Madison", 5851754, "Wood Violet", "American Robin", "Badger State",
              "Milwaukee", "Madison", "Green Bay", 61757, 15340, 3120400, 0.49,
              "The flag consists of a dark blue field with the state coat of arms in the center, featuring a sailor and a miner supporting a shield with a badger."),

                new StateData("Wyoming", "WY", "Cheyenne", 567025, "Indian Paintbrush", "Western Meadowlark", "Equality State",
              "Cheyenne", "Casper", "Laramie", 63529, 1170, 302700, 0.39,
              "The flag consists of a field of white with a blue border, featuring the state seal in the center, depicting a rancher and a miner supporting the state banner.")
            };
        }



        

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateData selectedStateData = comboBox.SelectedItem as StateData;
            if (selectedStateData != null)
            {
                PopulateStateInfo(selectedStateData);

            }

            // Use the utility method to get the corresponding StateData instance
            
        }

        private void PopulateStateInfo(StateData stateData)
        {
            if (stateData != null)
            {
                txtAbbreviation.Text = stateData.Abbreviation;
                txtCapital.Text = stateData.Capitol;
                txtFlagDescription.Text = stateData.FlagDescription;
                txtLargestCity.Text = stateData.LargestCity;
                txtMedianIncome.Text = stateData.MedianIncome.ToString();
                txtPercentageJobs.Text = stateData.PercentageOfProgrammingJobs.ToString();
                txtPopulation.Text = stateData.Population.ToString();
                txtSecondCity.Text = stateData.SecondLargestCity;
                txtStateBird.Text = stateData.StateBird;
                txtStateFlower.Text = stateData.StateFlower;
                txtStateNickname.Text = stateData.StateNickname;
                txtThirdCity.Text = stateData.ThirdLargestCity;
                txtTotalJobs.Text = stateData.TotalEmployment.ToString();
                txtProgrammingJobs.Text = stateData.ProgrammingJobs.ToString();

            }

            else
            {
                MessageBox.Show("State information is null");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox.SelectedItem != null)
            {
                
                StateData selectedStateData = comboBox.SelectedItem as StateData;
                if (selectedStateData != null)
                {
                    dataform showDataForm = new dataform(selectedStateData);
                    showDataForm.ShowDialog();
                }

                
            }
            else
            {
                MessageBox.Show("Please select a state.");
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

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
    internal class Utility
    {
        public static class StateDataUtility
        {
            //  a method to populate a ComboBox with state names
            public static void PopulateStatesComboBox(ComboBox comboBox, List<StateData> statesData)
            {
                comboBox.Items.Clear(); // Clear existing items

                foreach (StateData state in statesData)
                {
                    comboBox.Items.Add(state.State);
                }
            }

            //  a method to get the selected StateData based on the selected state name
            public static StateData GetSelectedStateData(string selectedStateName, List<StateData> statesData)
            {
                return statesData.FirstOrDefault(state => state.State == selectedStateName);
            }
        }

    }

}

    

