namespace Test;
using Hello;

public class TestHello
{
	[Test]
	public void ReturnsHelloWorld()
	{
		Assert.That(Hello.World(), Is.EqualTo("Hello world!"));
	}
}