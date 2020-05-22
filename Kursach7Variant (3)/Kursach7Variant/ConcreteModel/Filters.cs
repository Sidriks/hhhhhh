using System;

namespace ConcreteModel
{
    //Класс фильтров для фильтрации входных данных с полей.
    // суть одна и та же, если какой-то символ в строке не проходит проверку, то результат выдает true
    // и выдает меседж бокс в форме о том, что поле имеет не правильный формат
    public static class Filters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="param">нужен для оповещение того, в каких полях ошибка</param>
        /// <returns></returns>
        public static bool FilterByFIO(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsNumber(item))
                    result = true;
                else if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
            }
            param = "FIO";
            return result;
        }

        public static bool FilterByCost(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsLetter(item))
                    result = true;
            }
            param = "Cost";
            return result;
        }

        public static bool FilterByAccountNumber(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsLetter(item))
                    result = true;
            }
            param = "Account Number";
            return result;
        }

        public static bool FilterByDebt(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsLetter(item))
                    result = true;
            }
            param = "Debt";
            return result;
        }
    }
}
