using DrinksRepositoryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DrinksRepositoryLibTests
{
    [TestClass]
    public class DrinksRepositoryListTests
    {
        [TestMethod]
        public void AddDrink_ShouldAddDrinkToRepository()
        {
            // Arrange
            var repository = new DrinksRepository();
            var newDrink = new Drink
            {
                Name = "Test Drink",
                Type = "Soda",
                YearOfProduction = 2022
            };

            // Act
            var addedDrink = repository.Add(newDrink);

            // Assert
            Assert.IsNotNull(addedDrink);
            Assert.AreNotEqual(0, addedDrink.Id);
            var retrievedDrink = repository.GetById(addedDrink.Id);
            Assert.IsNotNull(retrievedDrink);
            Assert.AreEqual(addedDrink.Id, retrievedDrink.Id);
        }

        [TestMethod]
        public void RemoveDrink_ShouldRemoveDrinkFromRepository()
        {
            // Arrange
            var repository = new DrinksRepository();
            var newDrink = new Drink
            {
                Name = "Test Drink",
                Type = "Soda",
                YearOfProduction = 2022
            };
            var addedDrink = repository.Add(newDrink);

            // Act
            var removedDrink = repository.Remove(addedDrink.Id);

            // Assert
            Assert.IsNotNull(removedDrink);
            var retrievedDrink = repository.GetById(removedDrink.Id);
            Assert.IsNull(retrievedDrink);
        }

        [TestMethod]
        public void UpdateDrink_ShouldUpdateDrinkInRepository()
        {
            // Arrange
            var repository = new DrinksRepository();
            var newDrink = new Drink
            {
                Name = "Test Drink",
                Type = "Soda",
                YearOfProduction = 2022
            };
            var addedDrink = repository.Add(newDrink);

            var updatedDrink = new Drink
            {
                Id = addedDrink.Id,
                Name = "Updated Drink",
                Type = "New Type",
                YearOfProduction = 2023
            };

            // Act
            var result = repository.Update(updatedDrink.Id, updatedDrink);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(updatedDrink.Id, result.Id);
            var retrievedDrink = repository.GetById(updatedDrink.Id);
            Assert.IsNotNull(retrievedDrink);
            Assert.AreEqual(updatedDrink.Name, retrievedDrink.Name);
        }
    }
}
