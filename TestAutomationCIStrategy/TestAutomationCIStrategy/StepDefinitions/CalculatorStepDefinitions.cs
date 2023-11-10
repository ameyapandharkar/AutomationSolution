namespace TestAutomationCIStrategy.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public int sum;
        public int Num1;
        public int Num2;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Num1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Num2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = Num1 + Num2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Console.WriteLine(sum);
        }
    }
}