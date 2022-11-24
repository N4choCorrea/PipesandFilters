using System;
namespace CompAndDel.Filters
{
    public interface IFilterCondition : IFilter
    {
        bool EffectFilter { get; }
    }
    
}

