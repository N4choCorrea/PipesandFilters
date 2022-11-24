using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using CompAndDel.Filters;

namespace CompAndDel.Pipes
{
    public class PipeConditional : IPipe
    {
        private IPipe pipeTrue;
        private IPipe pipeFalse;
        private IFilterCondition filter;

        public PipeConditionals(IFilterCondition filter, IPipe pipeTrue, IPipe pipeFalse)
        {
            this.pipeTrue = pipeTrue;
            this.pipeFalse = pipeFalse;
            this.filter = filter;
        }

        public IPicture Send(IPicture picture)
        {
            IPicture result = filterCondition.EffectFilter(picture);
            if (this.filterCondition.EffectFilter == true)
            {
                result = this.pipeTrue.Send(result);
            }
            else
            {
                result = this.pipeFalse.Send(result);
            }
            return result;
        }
    }
}
