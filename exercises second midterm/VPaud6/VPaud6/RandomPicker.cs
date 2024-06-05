using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VPaud6
{
    public class RandomPicker
    {
        private readonly string[] words =
        {
            "Canada",
            "Japan",
            "Brazil",
            "Germany",
            "Australia",
            "India",
            "South Africa",
            "France",
            "Argentina",
            "Italy",
        };
        private Random random;
        public RandomPicker()
        {
            random = new Random();
        }
        public string pick()
        {
            return words[random.Next(words.Length)];
        }
    }
}
