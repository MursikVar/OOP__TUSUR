namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет предмет с уникальным идентификатором, именем, информацией и стоимостью.
    /// </summary>
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Получает уникальный идентификатор предмета.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Получает или задает имя предмета.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Получает или задает информацию о предмете.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Получает или задает стоимость предмета.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стоимость не может быть отрицательной.");
                }
                if (value > 100000)
                {
                    throw new ArgumentException("Стоимость не может превышать 100000.");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с указанными параметрами.
        /// </summary>
        /// <param name="name">Имя предмета.</param>
        /// <param name="info">Информация о предмете.</param>
        /// <param name="cost">Стоимость предмета.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = Idgenerator.GetNextId();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> без параметров.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Возвращает строковое представление предмета.
        /// </summary>
        /// <returns>Имя предмета.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
