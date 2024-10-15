using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfC_.Design_Patterns
{
    internal class FactoryPattern
    {
        public IElement MakeElement(string elementName)
        {
            switch (elementName)
            {
                case nameof(SodioumElement):
                    return new SodioumElement();
                case nameof(HydrogenElement):
                    return new HydrogenElement();
                default:
                    throw new ArgumentException();
            }
        }
    }

    public interface IElement
    {
        string Name { get; }
    }

    public class SodioumElement : IElement
    {
        public string Name => "SodioumElement";
    }

    public class HydrogenElement : IElement
    {
        public string Name => "HydrogenElement";
    }



}
