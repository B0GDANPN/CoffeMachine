namespace ConsoleApp1.Models
{
    public class Recipe
    {
        public readonly int _water;
        public readonly int _milk;
        public readonly int _beans;
        public Recipe(int water, int milk, int beans)
        {
            _water = water;
            _milk = milk;
            _beans = beans;
        }
    }
}