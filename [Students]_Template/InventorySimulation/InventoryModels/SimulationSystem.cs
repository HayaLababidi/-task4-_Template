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

        public void start_simulation() { }
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
