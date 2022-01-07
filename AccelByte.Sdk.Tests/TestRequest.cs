using System.Collections.Generic;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests
{
    public class TestRequest : Model
    {
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public double Weight { get; set; }

        public Dictionary<string, double>? Dimensions { get; set; }
    }
}