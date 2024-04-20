using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfTesting.UnitTest_C_Y_khalid
{
    public interface IWeightCalcRepository
    {
        public IEnumerable<WeightCalc> GetDataWeight();
    }
}
