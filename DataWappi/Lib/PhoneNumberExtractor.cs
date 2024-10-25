using System.Text.RegularExpressions;

namespace DataWappi.Lib;

public static class PhoneNumberExtractor
{
    #region "Get All"
    /// <summary>
    /// Este metodo recibe una cadena que contiene numeros telefonicos y caracteres especiales
    /// y los procesa para devolver una lista de cadena de numeros telefonicos con formato
    /// </summary>
    /// <param name="phone">Numeros telefonicos sin formato</param>
    /// <returns>Lista de telefonos con formato</returns>
    public static List<string> GetAll(string phone, string text)
    {
        // Se crea una hashSet almacenara los numeros telefonicos unicos
        HashSet<string> phoneNumbers = new();

        // Obtenemos el array de numeros del texto ingresado
        string[] numbersArray = ExtractNumbers(phone);

        // Interamos
        for(int i = 0; i < numbersArray.Length; i++)
        {
            string currentNumber = numbersArray[i];

            // Los numeros se guardaran en un formato para enviar al Wappi
            if(currentNumber.Length == 9 && currentNumber.StartsWith("9"))
            {
                phoneNumbers.Add(text + ",51" + currentNumber);
            }
            else if(currentNumber.Length > 9)
            {
                // Obtenemos el indice donde empieza el primer 9
                int startIndex = currentNumber.IndexOf('9');

                // Si es -1 significa que no existe un 9
                if(startIndex != -1)                           
                {
                    // Obtenemos un nuevo array donde empieza con 9
                    string extractedNumber = currentNumber[startIndex..];

                    // Si el nuevo array es igual a 9 agregamos el numero
                    if(extractedNumber.Length == 9)
                    {
                        phoneNumbers.Add(text + ",51" + extractedNumber);
                    }
                }
            }
            else if(currentNumber.Length < 9 && i < numbersArray.Length - 1)
            {
                int startIndex = currentNumber.IndexOf('9');

                if(startIndex != -1)
                {
                    string extractedNumber = currentNumber[startIndex..];
                    string combinedNumber = extractedNumber + numbersArray[i + 1];

                    if(combinedNumber.Length == 9 && numbersArray[i + 1].Length > 2)
                    {
                        phoneNumbers.Add(text + ",51" + combinedNumber);
                        i++;
                    }
                }
            }
        }

        // Retorna la lista única
        return phoneNumbers.ToList();
    }
    #endregion

    #region "Extract Numbers"
    /// <summary>
    /// Metodo extraer numeros
    /// </summary>
    /// <param name="phone">Numeros telefonicos sin formato</param>
    /// <returns>Array de números</returns>
    private static string[] ExtractNumbers(string phone)
    {
        string pattern = @"[0-9]+";
        return Regex.Matches(phone, pattern)
                            .Cast<Match>()
                            .Select(m => m.Value)
                            .ToArray();
    }
    #endregion
}
