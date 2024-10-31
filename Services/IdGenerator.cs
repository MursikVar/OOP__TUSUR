
namespace ObjectOrientedPractics
{
    /// <summary>
    /// Класс для генерации уникальных идентификаторов.
    /// </summary>
    internal static class Idgenerator
    {
        // Статическая переменная для хранения текущего значения идентификатора
        private static int _id = 0;

        /// <summary>
        /// Получает следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Следующий уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            // Возвращаем текущее значение идентификатора и увеличиваем его на 1
            return _id++;
        }
    }
}
