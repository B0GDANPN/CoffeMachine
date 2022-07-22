using ConsoleApp1.Exceptions;
namespace ConsoleApp1.Models
{
    public class Container
    {
        private int _capacity;
        private int _value;
        public Container(int capacity)
        {
            _capacity = capacity;
            _value = 0;
        }
        public void LoadResource(int value)
        {
            if (value<0)
                throw new NotEnoughValueException("Введите неотрицательное число");
            if (value>3000)
                throw new NotEnoughValueException("Каждое значение загружаемого ресурса должно быть меньше 3000");
            _value += value;
        }
        public int GetResource(int value, string nameResource)
        {
            if (_value<value)
                throw new NotEnoughValueException($"Недостаточно {nameResource}");
            _value -= value;
            return value;
        }
        public int GetCapacity()=>_capacity;
        public int GetValue()=>_value;

    }
}