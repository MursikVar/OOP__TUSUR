
namespace ObjectOrientedPractics
{
    /// <summary>
    /// Класс для валидации значений.
    /// </summary>
    internal static  class ValueValidator
    {
        // Метод для проверки длины строки
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            // Проверяем, превышает ли длина строки максимальную длину
            if (value.Length > maxLength)
            {
                // Если превышает, показываем сообщение об ошибке пользователю
                MessageBox.Show($"{propertyName} должен быть меньше {maxLength} символов.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // И выбрасываем исключение с соответствующим сообщением
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} этих символов");
            }
            // Проверяем, является ли строка пустой или null
            else if (string.IsNullOrEmpty(value))
            {
                // Если строка пустая, показываем сообщение об ошибке пользователю
                MessageBox.Show($"{propertyName} должен быть больше 0 символов.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // И выбрасываем исключение с соответствующим сообщением
                throw new ArgumentException($"{propertyName} не может быть пустой.");
            }
        }
    }
}
