using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfTesting.UnitTest_C_Y_khalid
{
    public class WeightCalc
    {
        public string Sex { get; set; }
        public double Height { get; set; }
        public double ClacWeight()
        {
            switch(Sex.ToLower())
            {
                case "w":
                    return ( Height - 100 ) - ( ( Height - 150 ) / 2 );

                case "m":
                    return ( Height - 100 ) - ( ( Height - 150 ) / 4 );
                default:
                    return 0;
            }
        }
        public IEnumerable<double> GetIdealWeight(IWeightCalcRepository weightCalcRepository)
        {
            List<double> idealWeight = new List<double>();
            var data = weightCalcRepository.GetDataWeight();
            foreach ( var item in data )
            {
                idealWeight.Add(item.ClacWeight());
            }
            return idealWeight;
        }
        public IEnumerable<double> GetIdealWeight()
        {
            List<double> idealWeight = new List<double>();
            var repo = new WeightCalcRepository();
            var data = repo.GetDataWeight();
            foreach( var item in data )
            {
                idealWeight.Add(item.ClacWeight());
            }
            return idealWeight;
        }
    }
}
