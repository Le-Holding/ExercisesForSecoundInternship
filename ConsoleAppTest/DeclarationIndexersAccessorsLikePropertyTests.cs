using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleAppTest
{
  [TestClass]
  public class DeclarationIndexersAccessorsLikePropertyTests
  {
    [TestMethod]
    public void TheMusicAppTest()
    {
      // Arrange
      // - nothing to arrange

      // Act
      var result = new DeclarationIndexersAccessorsLikeProperty().TheMusicApp();

      // Assert
      Assert.AreEqual(result[0], "Following: Bluse");
      Assert.AreEqual(result[1], "Following: Rock");
      Assert.AreEqual(result[2], "Following: Hip Hop");
      Assert.AreEqual(result[3], "Following: Contry");
      Assert.AreEqual(result[4], "Following: Soul");
    }
  }
}
