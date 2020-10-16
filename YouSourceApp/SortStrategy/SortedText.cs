using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSourceApp.SortStrategy
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class SortedText
    {
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public string Sort(string inputText)
        {
            return _sortstrategy.Sort(inputText);
        }


    }
}
