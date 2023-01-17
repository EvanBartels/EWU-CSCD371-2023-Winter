namespace ClassDemo.Tests;
[TestClass]
public class VehicleTests
{
    [TestMethod]
    public void Model_GivenToyota_ReturnsToyota()
    {
        //Arrange
        Vehicle vehicle = new();
        vehicle.Model = "Toyota";

        //Act
        string actual = vehicle.Model;

        //Assert
        Assert.AreEqual("Toyota", actual);
    }

    [TestMethod]
    public void Model_GivenNull_ThrowsException()
    {
        //Arrange
        Vehicle vehicle = new();

        ArgumentNullException expectedException = null;

        //Act
        try
        {
            vehicle.Model = null;
        }
        catch (ArgumentNullException ex)
        {
            expectedException = ex;
        }
        Assert.IsNotNull(expectedException);
    }
}
