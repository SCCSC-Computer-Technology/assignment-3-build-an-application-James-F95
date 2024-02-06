using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace James_Fowler_CPT206_Lab_2
{
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
