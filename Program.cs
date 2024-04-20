using TheArtOfTesting.Testing;
using TheArtOfTesting.UnitTest_C_Y_khalid;

//try
//{
//    SimpleParserTests.TestReturnsZeroWhenEmptyString();
//}
//catch( Exception e )
//{
//    Console.WriteLine(e);
//}

var calc = new WeightCalc();
foreach(var item in calc.GetIdealWeight() ) { Console.WriteLine(item); }
