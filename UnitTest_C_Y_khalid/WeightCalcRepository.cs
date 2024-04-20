using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfTesting.UnitTest_C_Y_khalid
{
    public class WeightCalcRepository : IWeightCalcRepository
    {
        private IEnumerable<WeightCalc> data;
        public WeightCalcRepository()
        {
            data = new List<WeightCalc>()
            {
                new WeightCalc() {Sex="w",Height=160},
                new WeightCalc() {Sex="w",Height=150},
                new WeightCalc() {Sex="m",Height=180},
                new WeightCalc() {Sex="m",Height=170},
                new WeightCalc() {Sex="m",Height=130},
                new WeightCalc() {Sex="m",Height=160},
                new WeightCalc() {Sex="m",Height=155},
            };
        }
        public IEnumerable<WeightCalc> GetDataWeight()
        {
            return data;
        }
    }
}
