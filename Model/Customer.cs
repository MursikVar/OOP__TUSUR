using System.Xml.Linq;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет клиента с уникальным идентификатором, полным именем и адресом.
    /// </summary>
    internal class Customer
    {
        private readonly int _id; // Уникальный идентификатор клиента
        private string _fullname; // Полное имя клиента
        private string _address; // Адрес клиента

        /// <summary>
        /// Получает уникальный идентификатор клиента.
        public int Id { get { return _id; } }

        /// <summary>
        /// Получает или задает полное имя клиента.
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Получает или задает адрес клиента.
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Adress");
                _address = value;
            }
        }

        private List<Customer> _Customers = new(); // Список клиентов
        private Customer _currentCustomer; // Текущий клиент

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с указанным полным именем и адресом.
        /// </summary>
        /// <param name="name">Полное имя клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string name, string address)
        {
            Fullname = name; // Устанавливаем полное имя
            Address = address; // Устанавливаем адрес
            _id = Idgenerator.GetNextId(); // Генерируем уникальный идентификатор
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> без параметров.
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Возвращает строку, представляющую текущего клиента.
        /// </summary>
        /// <returns>Полное имя клиента.</returns>
        public override string ToString()
        {
            return Fullname; // Возвращаем полное имя клиента
        }
    }
}
