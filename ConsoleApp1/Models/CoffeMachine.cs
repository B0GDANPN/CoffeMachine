using System.Collections.Generic;
using ConsoleApp1.Exceptions;
namespace ConsoleApp1.Models
{
    public class CoffeeMachine
    {
        private Dictionary<RecipeName, Recipe> _recipes=new Dictionary<RecipeName, Recipe>()
        {
            { RecipeName.espresso, new Recipe(10,15,6)},
            { RecipeName.filtered, new Recipe(12,10,9)},
            { RecipeName.cappuccino, new Recipe(13,15,15)}

        };
        private GrinderUnit _grinderUnit=new GrinderUnit();
        private BrewingUnit _brewingUnit=new BrewingUnit();
        private Container _waterContainer=new Container(500);
        private Container _milkContainer = new Container(500);
        private Container _beansContainer = new Container(500);
        public int GetWaterLevel() => _waterContainer.GetValue();
        public int GetMilkLevel() => _milkContainer.GetValue();
        public int GetBeansLevel() => _beansContainer.GetValue();
        public void LoadWater(int value)
        {
            _waterContainer.LoadResource(value);
        }
        public void LoadMilk(int value)
        {
            _milkContainer.LoadResource(value);
        }
        public void LoadBeans(int value)
        {
            _beansContainer.LoadResource(value);
        }
        public Coffe Brew(RecipeName recipe)
        {
            Recipe currentRecipe = _recipes[recipe];
            int valueBeans=_beansContainer.GetResource(currentRecipe._beans,"beans");
            int valueWater=_waterContainer.GetResource(currentRecipe._water,"water");
            int valueMilk= _milkContainer.GetResource(currentRecipe._milk,"milk");
            GroundCoffe grindedBeans = _grinderUnit.Grind(valueBeans);
            return _brewingUnit.Brew(grindedBeans);

        }
    }
}