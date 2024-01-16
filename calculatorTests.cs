namespace calculator;

public class CalcTests
{
	[Fact]
	public void TestAddition()
	{
		// given
		Calculator calc = new();
		int a = 5;
		int b = 2;
		int expectedRes = 7;
		
		// when
		int result = calc.Add(a, b);
		
		// then
		Assert.Equal(expectedRes, result);
	}
}