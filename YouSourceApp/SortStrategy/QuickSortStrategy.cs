using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSourceApp.SortStrategy
{
    class QuickSortStrategy : SortStrategy
    {
        public override string Sort(string InputText)
        {
            string[] inputText = InputText.ToCharArray().Select(x => x.ToString()).ToArray();

            void quickSort(string[] inputTextArray, int minIndex, int maxIndex)
            {
                if (minIndex < maxIndex)
                {
                    int pivot = partition(inputTextArray, minIndex, maxIndex);
                    quickSort(inputTextArray, minIndex, pivot - 1);
                    quickSort(inputTextArray, pivot + 1, maxIndex);
                }
            }

            int partition(string[] inputTextArray, int minIndex, int maxIndex)
            {
                int i = minIndex;
                string pivot = inputTextArray[maxIndex];
                string temp;
                for (int j = minIndex; j <= maxIndex; j++)
                {
                    if (inputTextArray[j].CompareTo(pivot) < 0)
                    {
                        temp = inputTextArray[i];
                        inputTextArray[i] = inputTextArray[j];
                        inputTextArray[j] = temp;
                        i++;
                    }
                }
                temp = inputTextArray[maxIndex];
                inputTextArray[maxIndex] = inputTextArray[i];
                inputTextArray[i] = temp;
                return i;
            }

            quickSort(inputText, 0, inputText.Length - 1);

            string output = "";
            foreach (string text in inputText)
            {
                output += text;
            }
            return output;
        }
    }
}
