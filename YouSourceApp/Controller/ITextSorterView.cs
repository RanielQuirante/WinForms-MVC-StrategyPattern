using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSourceApp.Controller
{
    public interface ITextSorterView
    {
        void SetController(TextSorterController controller);

        string InputText { get; set; }

        string OutputText { get; set; }

    }
}
