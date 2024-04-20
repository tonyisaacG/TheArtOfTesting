using TheArtOfTesting.Classes;

namespace TheArtOfTesting.Testing;

public class SimpleParserTests
{
    public static void TestReturnsZeroWhenEmptyString()
    {
        try
        {
            SimpleParser obj = new SimpleParser();
            var result = obj.ParseAndSum(string.Empty);
            if( result != 0 )
            {
                Console.WriteLine(@"***SimpleParserTests.TestReturnsZeroWhenEmptyString: -------Parse and sum should have returned 0 on an empty string");
            }
        }
        catch( Exception ex )
        {
            Console.WriteLine(ex.ToString());
        }
    }
}