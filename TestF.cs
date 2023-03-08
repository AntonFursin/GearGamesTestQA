using NUnit.Framework;
using Altom.AltDriver;

public class TestF
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void TestStartButtonLoadsMainScene()
    {
        altDriver.LoadScene("Main");
        altDriver.FindObject(By.NAME, "StartButton").Click();
       
    }

    [Test]
    public void TestStoreButton()
    {
        altDriver.LoadScene("Main");
        altDriver.FindObject(By.NAME, "StoreButton").Click();

    }

    [Test]
    public void TestPauseGame()
    {
        altDriver.LoadScene("Main");
        altDriver.FindObject(By.NAME, "StartButton").Click();
        altDriver.SetDelayAfterCommand(5);
        altDriver.FindObject(By.NAME, "pauseButton").Click();
    }


    [Test]
    public void TestMoveRightLeft()
    {
        altDriver.LoadScene("Main");
        altDriver.FindObject(By.NAME, "StartButton").Click();
        altDriver.SetDelayAfterCommand(5);
        altDriver.PressKey(AltKeyCode.UpArrow, 0.1f);
        altDriver.KeyDown(AltKeyCode.LeftArrow);
        altDriver.KeyUp(AltKeyCode.LeftArrow);
    }

}