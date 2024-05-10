using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.utils
{
    public static class InputValidator
    {
        public static bool IsStringInputValid(string input)
        {
            // Проверяем, что вводимые данные являются строкой
            return input is string;
        }

        public static bool IsUsernameValid(string username)
        {
            // Проверяем, что имя пользователя не пустое, не содержит недопустимых символов и является строкой
            return IsStringInputValid(username) && !string.IsNullOrEmpty(username) && !username.Contains(" ");
        }

        public static bool IsPasswordValid(string password)
        {
            // Проверяем, что пароль не пустой, его длина больше 6 символов и является строкой
            return IsStringInputValid(password) && !string.IsNullOrEmpty(password) && password.Length > 5;
        }
    }
}
