using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class BetterProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
        {
            foreach(var product in products)
            {
                if(specification.IsSatisfied(product))
                {
                    yield return product;
                }
            }
        }
    }
}