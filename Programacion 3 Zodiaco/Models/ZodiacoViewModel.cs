using System.Security.Cryptography;

namespace Programacion_3_Zodiaco.Models
{
    public static class ZodiacoViewModel
    {
        public static string Signo(DateTime date)
        {
            string signo = string.Empty;

            if ((date.Day >= 21 && date.Month == 3) || (date.Day <= 19 && date.Month == 4))
                signo = "Aries";
            if ((date.Day >= 20 && date.Month == 4) || (date.Day <= 20 && date.Month == 5))
                signo = "Tauro";
            if ((date.Day >= 21 && date.Month == 5) || (date.Day <= 20 && date.Month == 6))
                signo = "Geminis";
            if ((date.Day >= 21 && date.Month == 6) || (date.Day <= 22 && date.Month == 7))
                signo = "Cancer";
            if ((date.Day >= 23 && date.Month == 7) || (date.Day <= 22 && date.Month == 8))
                signo = "Leo";
            if ((date.Day >= 23 && date.Month == 8) || (date.Day <= 22 && date.Month == 9))
                signo = "Virgo";
            if ((date.Day >= 23 && date.Month == 9) || (date.Day <= 22 && date.Month == 10))
                signo = "Libra";
            if ((date.Day >= 23 && date.Month == 10) || (date.Day <= 21 && date.Month == 11))
                signo = "Escorpio";
            if ((date.Day >= 22 && date.Month == 11) || (date.Day <= 21 && date.Month == 12))
                signo = "Sagitario";
            if ((date.Day >= 22 && date.Month == 12) || (date.Day <= 19 && date.Month == 1))
                signo = "Capricornio";
            if ((date.Day >= 20 && date.Month == 1) || (date.Day <= 18 && date.Month == 2))
                signo = "Acuario";
            if ((date.Day >= 19 && date.Month == 2) || (date.Day <= 20 && date.Month == 3))
                signo = "Piscis";

            return signo;

        }
    }
}
