using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        public void start_simulation()
        {
            //SimulationTable = new List<SimulationCase>();
            simulate();
            //PerformanceMeasures = new PerformanceMeasures();
            this.PerformanceMeasures.calculate_PM(SimulationTable);
        }
        public void simulate()
        {
            int O_Quantity = 0;
            int temp_shortage = 0;
            SimulationCase temp = new SimulationCase();
            temp.Day = 1;
            temp.Cycle = 1;
            temp.DayWithinCycle = 1;
            temp.BeginningInventory = StartInventoryQuantity;
            temp.demand(DemandDistribution);
            temp.EndingInventory = temp.BeginningInventory - temp.Demand;
            temp.Daytillarr = StartLeadDays - 1;
            if (temp.EndingInventory < 0)
            {
                temp.ShortageQuantity = -1 * temp.EndingInventory;
                temp.EndingInventory = 0;
            }
            SimulationTable.Add(temp);
            O_Quantity = StartOrderQuantity;

            temp = new SimulationCase();
            SimulationTable.Add(temp);
            for (int i = 1; i < NumberOfDays; i++)
            {
                //SimulationTable[i].RandomLeadDays = 1;//solves the exception 
                temp_shortage = SimulationTable[i - 1].ShortageQuantity;
                SimulationTable[i].Day = SimulationTable[i - 1].Day + 1;
                SimulationTable[i].BeginningInventory = SimulationTable[i - 1].EndingInventory;

                if (SimulationTable[i - 1].DayWithinCycle == 5)
                {
                    SimulationTable[i].Cycle = SimulationTable[i - 1].Cycle + 1;
                    SimulationTable[i].DayWithinCycle = 1;
                }
                else
                {
                    SimulationTable[i].Cycle = SimulationTable[i - 1].Cycle;
                    SimulationTable[i].DayWithinCycle = SimulationTable[i - 1].DayWithinCycle + 1;
                }

                SimulationTable[i].demand(DemandDistribution);
                SimulationTable[i].EndingInventory = SimulationTable[i].BeginningInventory - SimulationTable[i].Demand;

                if (SimulationTable[i - 1].Daytillarr > 0)
                {
                    SimulationTable[i].Daytillarr = SimulationTable[i - 1].Daytillarr - 1;
                }
                else
                {
                    if (SimulationTable[i - 1].Daytillarr == 0 && SimulationTable[i - 2].Daytillarr == 1)
                    {
                        SimulationTable[i].BeginningInventory += O_Quantity;
                        SimulationTable[i].demand(DemandDistribution);
                        SimulationTable[i].EndingInventory = SimulationTable[i].BeginningInventory - SimulationTable[i].Demand - SimulationTable[i - 1].ShortageQuantity;
                        temp_shortage = 0;
                    }
                }

                if (SimulationTable[i].EndingInventory < 0)
                {
                    SimulationTable[i].ShortageQuantity = -1 * SimulationTable[i].EndingInventory + temp_shortage;
                    SimulationTable[i].EndingInventory = 0;
                }
                else if (SimulationTable[i].EndingInventory == 0)
                    SimulationTable[i].ShortageQuantity = SimulationTable[i - 1].ShortageQuantity;

                if (SimulationTable[i].DayWithinCycle == ReviewPeriod) //&& i != NumberOfDays - 1)
                {
                    SimulationTable[i].order(LeadDaysDistribution, OrderUpTo);
                    O_Quantity = SimulationTable[i].OrderQuantity;
                    //temp = new SimulationCase();
                    //SimulationTable.Add(temp);   

                }
                else
                {
                    //nothing 
                }
                if (i != NumberOfDays - 1)
                {
                    temp = new SimulationCase();
                    SimulationTable.Add(temp);
                }


            }


        }
        public void generate_cumulative_range(List<Distribution> dist)
        {
            int size = dist.Count;

            //fill Cumulative column
            dist[0].CummProbability = dist[0].Probability;
            for (int i = 1; i < size; i++)
            {
                dist[i].CummProbability = dist[i - 1].CummProbability + dist[i].Probability;
            }
            //fill MinRange , MaxRange
            dist[0].MinRange = 1;
            dist[size - 1].MaxRange = 0;
            for (int i = 0; i < size; i++)
            {
                dist[i].MaxRange = Convert.ToInt32(dist[i].CummProbability * 100);
            }
            //dist[0].range = Convert.ToString(dist[0].MinRange) + " - " + Convert.ToString(dist[0].MaxRange);
            for (int i = 1; i < size; i++)
            {
                dist[i].MinRange = dist[i - 1].MaxRange + 1;
                //dist[i].range = Convert.ToString(dist[i].MinRange) + " - " + Convert.ToString(dist[i].MaxRange);

            }
        }
        public void ReadInput(string filepath)
        {
            string str;
            FileStream fs = new FileStream(filepath, FileMode.Open);
            StreamReader SR = new StreamReader(fs);
            //    char s = (char)SR.Read();
            while (SR.Peek() != -1)
            {
                str = SR.ReadLine();
                if (str == "OrderUpTo")
                {
                    OrderUpTo = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "ReviewPeriod")
                {
                    ReviewPeriod = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "StartLeadDays")
                {
                    StartLeadDays = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "StartInventoryQuantity")
                {
                    StartInventoryQuantity = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "StartOrderQuantity")
                {
                    StartOrderQuantity = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "NumberOfDays")
                {
                    NumberOfDays = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "DemandDistribution")
                {
                    str = SR.ReadLine();
                    while (str != "")
                    {
                        string[] substrings = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        Distribution DD = new Distribution();
                        DD.Value = int.Parse(substrings[0]);
                        DD.Probability = decimal.Parse(substrings[1]);
                        str = SR.ReadLine();
                        DemandDistribution.Add(DD);
                    }
                    generate_cumulative_range(DemandDistribution);
                    continue;
                }
                else if (str == "LeadDaysDistribution")
                {
                    str = SR.ReadLine();
                    while (str != "" && str != null)
                    {
                        string[] substrings = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        Distribution LTD = new Distribution();
                        LTD.Value = int.Parse(substrings[0]);
                        LTD.Probability = decimal.Parse(substrings[1]);
                        str = SR.ReadLine();
                        LeadDaysDistribution.Add(LTD);
                    }
                    generate_cumulative_range(LeadDaysDistribution);
                    continue;
                }
            }
            SR.Close();

        }
    }
}
