using Microsoft.Playwright;

namespace PlaywrightEndToEndTests;

public class Tests : PageTest
{
    //The webapp will have to be launched separately
    [SetUp]
    public async Task SetUp()
    {
        //check that the page is loaded
        await Page.GotoAsync("http://localhost:5116/");
    }

    [Test]
    public async Task CalculatorUI_CalculatorTitle_isCalculator()
    //preq-E2E-TEST-5
    {

        await Expect(Page).ToHaveTitleAsync("Calculator");
    }

    [Test]
    public async Task CalculatorUI_AdditionProvidesUI_SumProperlyShown()
    //preq-E2E-TEST-6
    {
        //Fill input boxes
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxA" }).FillAsync("5");
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxB" }).FillAsync("5");
        //Click the add operation
        await Page.GetByRole(AriaRole.Button, new() { NameString = "A + B" }).ClickAsync();

        //check that the proper output is displayed
        await Expect(Page.GetByText("10")).ToBeVisibleAsync();
    }

    [Test]
    public async Task CalculatorUI_DivisionByZero_NotANumberDisplayed()
    //preq-E2E-TEST-7
    {
        //Fill input boxes
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxA" }).FillAsync("5");
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxB" }).FillAsync("0");
        //Click the division operation
        await Page.GetByRole(AriaRole.Button, new() { NameString = "A / B" }).ClickAsync();

        //check that the proper output is displayed
        await Expect(Page.GetByText("Not a Number")).ToBeVisibleAsync();
    }

    [Test]
    public async Task CalculatorUI_StringInputGiven_InvalidInputDisplayed()
    //preq-E2E-TEST-8
    {
        //Fill input boxes
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxA" }).FillAsync("5");
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxB" }).FillAsync("five");
        //Click the add operation
        await Page.GetByRole(AriaRole.Button, new() { NameString = "A + B" }).ClickAsync();

        //check that the proper output is displayed
        await Expect(Page.GetByText("Invalid Input: Numbers Only")).ToBeVisibleAsync();
    }
    
    [Test]
    public async Task CalculatorUI_ClearButtonAfterFunctionCall_DefaultStateDisplayed()
    //preq-E2E-TEST-9
    {
        //Fill input boxes
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxA" }).FillAsync("5");
        await Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxB" }).FillAsync("5");
        //Click the add operation
        await Page.GetByRole(AriaRole.Button, new() { NameString = "A + B" }).ClickAsync();

        //Clear the previous operation
        await Page.GetByRole(AriaRole.Button, new () { NameString = "Clear" }).ClickAsync();
        
        //check that the proper output is displayed
        await Expect(Page.GetByText("Enter values(s) below and select an operation.")).ToBeVisibleAsync();
        await Expect(Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxA" })).ToHaveTextAsync("");
        await Expect(Page.GetByRole(AriaRole.Textbox, new() { NameString = "inputBoxB" })).ToHaveTextAsync("");
    }

}