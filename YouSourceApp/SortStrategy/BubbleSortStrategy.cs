using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSourceApp.SortStrategy
{
    internal class BubbleSortStrategy : ISortStrategy
    {
        public string SortMethod(string InputText)
        {
            string[] inputTextArray = InputText.ToCharArray().Select(x => x.ToString()).ToArray();
            for (int j = 0; j <= inputTextArray.Length - 2; j++)
            {
                for (int i = 0; i <= inputTextArray.Length - 2; i++)
                {
                    if (inputTextArray[i].CompareTo(inputTextArray[i + 1]) > 0)
                    {
                        var container = inputTextArray[i + 1];
                        inputTextArray[i + 1] = inputTextArray[i];
                        inputTextArray[i] = container;
                    }
                }
            }
            string output = "";
            foreach(string inputText in inputTextArray)
            {
                output += inputText;
            }
            return output;
        }
    }
}
