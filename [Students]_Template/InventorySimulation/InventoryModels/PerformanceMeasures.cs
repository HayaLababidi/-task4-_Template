using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {

        }
        public decimal EndingInventoryAverage { get; set; }

        public decimal ShortageQuantityAverage { get; set; }

        public void calculate_PM(List<SimulationCase> simulationTable)
        {
            decimal totalInventory = 0;
            decimal totalQuantity = 0;
            for (int i = 0; i < simulationTable.Count; i++)
            {
                totalInventory += simulationTable[i].EndingInventory;
                totalQuantity += simulationTable[i].ShortageQuantity;
            }
            EndingInventoryAverage = totalInventory / (decimal)simulationTable.Count;
            ShortageQuantityAverage = totalQuantity / (decimal)simulationTable.Count;
        }

    }
}
