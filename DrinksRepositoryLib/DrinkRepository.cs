using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinksRepositoryLib
{

    public class DrinksRepository
    {


        private int _nextId = 1;
        private readonly List<Drink> _drinks = new List<Drink>(); // list of drinks

        public DrinksRepository() // this is the constructor that adds drinks to the list
        {
            _drinks.Add(new Drink { Id = _nextId++, Name = "Coca Cola", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Fanta", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Sprite", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Pepsi", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "7up", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Mountain Dew", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Dr Pepper", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Coca Cola Zero", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Fanta Zero", Type = "Soda", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Vodka", Type = "Alcohol", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Whiskey", Type = "Alcohol", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Rum", Type = "Alcohol", YearOfProduction = 2019 });
            _drinks.Add(new Drink { Id = _nextId++, Name = "Gin", Type = "Alcohol", YearOfProduction = 2019 });
           
        }


        public IEnumerable<Drink> GetAll(string? drinkType = null)  // this is the method that returns the list of drinks Get()
        {
            IEnumerable<Drink> drinks = new List<Drink>(_drinks);

            switch (drinkType)
            {
                case null:
                    return drinks;
                    break;

                case "Soda":
                    drinks = drinks.Where(d => d.Type == "Soda");
                    break;
            }
            return _drinks;
        }

        public Drink? GetById(int id) // this is the method that returns a drink by id
        {
            return _drinks.FirstOrDefault(d => d.Id == id);
        }

        public Drink Add(Drink drink) // this is the method that adds a drink to the list
        {
            drink.Id = _nextId++;
            _drinks.Add(drink);
            return drink;
        }

        public Drink? Remove(int id) // this is the method that removes a drink from the list by id
        {
            Drink? drink = GetById(id);
            if (drink == null)
            {
                return null;
            }
            _drinks.Remove(drink);
            return drink;
        }

        public Drink? Update(int id, Drink drink) // this is the method that updates a drink in the list by id
        {
            Drink? oldDrink = GetById(id);
            if (oldDrink == null)
            {
                return null;
            }
            oldDrink.Name = drink.Name;
            oldDrink.Type = drink.Type;
            oldDrink.YearOfProduction = drink.YearOfProduction;
            return oldDrink;
        }



    }
}














