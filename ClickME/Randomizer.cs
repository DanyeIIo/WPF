using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickME
{
    /// <summary>
    /// Shuffle collections and string works like a library
    /// </summary>
    public class Randomizer
    {
        private Randomizer() { }

        /// <summary>
        /// method to shuffle collections
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">Collection (taking shuffled collection)</param>
        /// <param name="percentage">Percent to shuffle</param>
        public static void Randomize<T>(ref T[] items, int percentage)
        {
            if (items is null || items.Length == 0)
            {
                throw new ArgumentNullException($"{nameof(items)} can not be null or can't be contains empty", nameof(items));
            }

            if (percentage <= 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage));
            }

            Random rand = new Random();

            for (uint i = 0; i < percentage; i++)
            {
                int left = rand.Next(0, items.Length);
                int right = rand.Next(0, items.Length);

                (items[left], items[right]) = (items[right], items[left]);
            }
        }

        /// <summary>
        /// method to string shuffle
        /// </summary>
        /// <param name="items"></param>
        /// <param name="percentage">Percent to shuffle</param>
        /// <returns>shuffled string result</returns>
        public static string Randomize(string items, int percentage)
        {
            if (string.IsNullOrEmpty(items))
            {
                throw new ArgumentException($"'{nameof(items)}' cannot be null or empty.", nameof(items));
            }

            if (percentage <= 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage));
            }

            Random rand = new Random();

            var res = items.ToCharArray();

            for (uint i = 0; i < percentage; i++)
            {
                int left = rand.Next(0, res.Length);
                int right = rand.Next(res.Length / 2, res.Length);

                (res[left], res[right]) = (res[right], res[left]);
            }

            return new string(res);
        }
    }
}
