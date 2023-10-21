using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrinksRepositoryLib;

namespace DrinksRepositoryLib.Tests
{
    [TestClass]
    public class DrinkTests
    {
        [TestMethod]
        public void ValidateName_WithValidName_ShouldNotThrowException()
        {
            // Arrange
            var drink = new Drink
            {
                Name = "Valid Name",
                Type = "Soda",
                YearOfProduction = 2022
            };

            // Act and Assert
            try
            {
                drink.ValidateName();
            }
            catch (Exception)
            {
                Assert.Fail("An exception was thrown, but it shouldn't have.");
            }
        }

        [TestMethod]
        public void ValidateName_WithNullName_ShouldThrowArgumentNullException()
        {
            // Arrange
            var drink = new Drink
            {
                Name = null,
                Type = "Soda",
                YearOfProduction = 2022
            };

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => drink.ValidateName());
        }

        [TestMethod]
        public void ValidateName_WithShortName_ShouldThrowArgumentException()
        {
            // Arrange
            var drink = new Drink
            {
                Name = "A",
                Type = "Soda",
                YearOfProduction = 2022
            };

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => drink.ValidateName());
        }
    }
}