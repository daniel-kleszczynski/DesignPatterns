using System;

namespace ThirdPartyLibrary
{
    public sealed class Component : IComponent
    {
        public int GetValue()
        {
            const int BASE_VALUE = 21;

            Console.WriteLine($"In {nameof(Component)} Value: {BASE_VALUE}");
            return BASE_VALUE;
        }
    }
}
