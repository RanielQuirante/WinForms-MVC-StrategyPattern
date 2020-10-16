using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceApp.Model;
using YouSourceApp.SortStrategy;

namespace YouSourceApp.Controller
{ 

    public class TextSorterController
    {
        ITextSorterView _view;
        TextSorter _textSorter;
        List<ComboBox> _comboBox;

        public TextSorterController(ITextSorterView view)
        {
            _view = view;
            _comboBox = new List<ComboBox>();
            view.SetController(this);
        }

        public void SortText(int sortIndex)
        {
            SortedText inputText = new SortedText();

            switch (sortIndex)
            {
                case (int)SortingStrategy.BubbleSort:
                    inputText.SetSortStrategy(new BubbleSortStrategy());
                    this._view.OutputText = inputText.Sort(this._view.InputText);
                    break;

                case (int)SortingStrategy.QuickSort:
                    inputText.SetSortStrategy(new QuickSortStrategy());
                    this._view.OutputText = inputText.Sort(this._view.InputText);
                    break;

                default:
                    this._view.OutputText = "Invalid Sorting Method";
                    break;
            }
          
        }

        public List<ComboBox> SortingMethod()
        {
            _comboBox.Add(new ComboBox { Name = "BubbleSort", Value = "1" });
            _comboBox.Add(new ComboBox { Name = "QuickSort", Value = "2" });
            return _comboBox;
        }

    }
}
