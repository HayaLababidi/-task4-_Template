using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {

        }
        public int Day { get; set; }
        public int Cycle { get; set; }
        public int DayWithinCycle { get; set; }
        public int BeginningInventory { get; set; }
        public int RandomDemand { get; set; }
        public int Demand { get; set; }
        public int EndingInventory { get; set; }
        public int ShortageQuantity { get; set; }
        public int OrderQuantity { get; set; }
        public int RandomLeadDays { get; set; }
        public int LeadDays { get; set; }

        public int Daytillarr { get; set; }

        

        public void demand(List<Distribution> DemandDistribution)
        {
            Random rand = new Random();
            RandomDemand = rand.Next(1, 101);
            System.Threading.Thread.Sleep(10);
            for(int i=0;i<DemandDistribution.Count;i++)
            {
                if(RandomDemand >= DemandDistribution[i].MinRange && RandomDemand <= DemandDistribution[i].MaxRange)
                {
                    Demand = DemandDistribution[i].Value;
                    break;
                }
            }
        }

        public void order(List<Distribution> LeadDaysDistribution, int OrderUpTo)
        {
            Random rand = new Random();
            RandomLeadDays = rand.Next(1, 101);
            System.Threading.Thread.Sleep(10);
            for(int i = 0; i<LeadDaysDistribution.Count; i++)
            {
                if(RandomLeadDays >= LeadDaysDistribution[i].MinRange && RandomLeadDays <= LeadDaysDistribution[i].MaxRange)
                {
                    LeadDays = LeadDaysDistribution[i].Value;
                    break;
                }
            }
            OrderQuantity = OrderUpTo - EndingInventory + ShortageQuantity;
            Daytillarr = LeadDays;
        }
    } 
}
