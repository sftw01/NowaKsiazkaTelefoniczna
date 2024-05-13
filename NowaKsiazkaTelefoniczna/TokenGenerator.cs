using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowaKsiazkaTelefoniczna
{
    // klasa abstrakcyjna sluzy tylko do generowania tokena bez tworzenia instancji klasy - roznwojowa


    abstract class TokenGenerator
    {
        private static Random random = new Random();

        public static string GenerateToken()
        {
            // Generowanie czterech pseudolosowych liter
            char[] letters = new char[4];
            for (int i = 0; i < 4; i++)
            {
                letters[i] = (char)('A' + random.Next(0, 26));
            }

            // Generowanie dwóch pseudolosowych cyfr
            int firstDigit = random.Next(0, 10);
            int secondDigit = random.Next(0, 10);

            // Formatowanie tokena
            string token = new string(letters) + "-" + firstDigit.ToString() + secondDigit.ToString();

            return token;
        }
    }
}
