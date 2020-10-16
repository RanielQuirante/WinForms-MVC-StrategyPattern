using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YSUnitTest
{
    [TestClass]
    public class Sorting
    {
        [TestMethod]
        public void BubbleSort()
        {
            var textBuilder = new StringBuilder();
            // 4-Letters lower case   
            textBuilder.Append(RandomString(4, true));  
  
            // 4-Digits between 1000 and 9999  
            textBuilder.Append(RandomNumber(1000, 9999));  

            string inputText = textBuilder.ToString();
            string[] inputTextArray = inputText.ToCharArray().Select(x => x.ToString()).ToArray();
            string[] expected = inputText.ToCharArray().Select(x => x.ToString()).ToArray();
            Array.Sort(expected);
            string container;

            for (int j = 0; j <= inputTextArray.Length - 2; j++)
            {
                for (int i = 0; i <= inputTextArray.Length - 2; i++)
                {
                    if (inputTextArray[i].CompareTo(inputTextArray[i + 1]) > 0)
                    {
                        container = inputTextArray[i + 1];
                        inputTextArray[i + 1] = inputTextArray[i];
                        inputTextArray[i] = container;
                    }
                }
            }

            Trace.Write("Sorted:");
            foreach (string output in inputTextArray)
            Trace.Write(output);
            Trace.WriteLine("");

            CollectionAssert.AreEqual(expected, inputTextArray);
        }

        [TestMethod]
        public void QuickSort()
        {
            var textBuilder = new StringBuilder();
            // 4-Letters lower case   
            textBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            textBuilder.Append(RandomNumber(1000, 9999));

            string inputText = "bfsd123";
            string[] actual = inputText.ToCharArray().Select(x => x.ToString()).ToArray();
            string[] expected = inputText.ToCharArray().Select(x => x.ToString()).ToArray();
            Array.Sort(expected);

            void quicksort(string[] inputTextArray, int minIndex, int maxIndex)
            {
                if (minIndex < maxIndex)
                {
                    int pivot = partition(inputTextArray, minIndex, maxIndex);
                    quicksort(inputTextArray, minIndex, pivot - 1);
                    quicksort(inputTextArray, pivot + 1, maxIndex);
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

            quicksort(actual, 0, actual.Length - 1);

            Trace.Write("Sorted:");
            foreach (string output in actual)
                Trace.Write(output);
            Trace.WriteLine("");

            CollectionAssert.AreEqual(expected, actual);
        }

        // Instantiate random number generator.  
        // It is better to keep a single Random instance 
        // and keep using Next on the same instance.  
        private readonly Random _random = new Random();

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
