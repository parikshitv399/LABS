using System;

namespace Supermarket
{
    [Serializable]
    public class Products
    {
        public string DOM { get; internal set; }
        public string Name { get; internal set; }
    }
}