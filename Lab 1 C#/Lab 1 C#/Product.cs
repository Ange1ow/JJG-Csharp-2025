namespace Lab_1_C_
{
    internal class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            _quantity = quantity;
        }

        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                if(value == null)
                {
                    throw new ArgumentException("Назва не може бути пустою!");
                }
                _name = value; 
            }
        }

        public decimal Price
        {
            get 
            { 
                return _price; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна не може бути від'ємною!");
                }
                _price = value;
            }
        }

        public int Quantity => _quantity;

        public decimal TotalValue => _price * _quantity;

        public void Restock(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Кількість для поповнення має бути додатною!");
            _quantity += amount;
        }

        public void Sell(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Кількість для продажу має бути додатною!");
            if (amount > _quantity)
            {
                Console.WriteLine("Недостатньо товару на складі!");
                return;
            }
            _quantity -= amount;
        }

        public string GetInfo()
        {
            return $"Товар: {_name}, Ціна: {_price} грн, Кількість: {_quantity}, Загальна вартість: {TotalValue} грн";
        }
    }








}

