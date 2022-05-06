using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakladniAuto
{
    /// <summary>
    /// Reprezentuje činnosti nákladního auta
    /// </summary>
    internal class Ukony
    {
        /// <summary>
        /// Hmotnost nákladu
        /// </summary>
        public int nalozeno = 0;
        /// <summary>
        /// Nosnost
        /// </summary>
        public int nosnost = 3000;

        /// <summary>
        /// Pokusí se naložit náklad o dané hmotnosti
        /// </summary>
        /// <param name="nakladano">Hmotnost nakládaného nákladu</param>
        public void Naloz(int nakladano)
        {
            if (nalozeno + nakladano <= nosnost)
                nalozeno += nakladano;
        }
        /// <summary>
        /// Pokusí se vyložit náklad o dané hmotnosti
        /// </summary>
        /// <param name="hmotnost">Hmotnost vykládaného nákladu</param>
        public void Vyloz(int nakladano)
        {
            if (nalozeno - nakladano > 0)
                nalozeno -= nakladano;
        }
        /// <summary>
        /// Vypíše kolik je naloženo
        /// </summary>
        public void VypisNalozeni()
        {
            Console.WriteLine("V nákladním autě je naloženo {0} kg", nalozeno);
        }
    }
}