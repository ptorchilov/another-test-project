using FirstWebApp.Interfaces;

namespace FirstWebApp.Services
{
    public class NumbersService : INumbers
    {
        public int[] GetNumbers(int count)
        {
            var result = new int[count];

            for (var i = 0; i < count; i++)
            {
                result[i] = i;
            }

            return result;
        }
    }
}