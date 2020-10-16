using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouSourceApp.Controller;
using YouSourceApp.Model;

namespace YouSourceApp
{
    public partial class TextSorterView : Form, ITextSorterView
    {

        public TextSorterView()
        {
            InitializeComponent();
        }

        TextSorterController _textSorterController;

        public void SetController(TextSorterController controller)
        {
            _textSorterController = controller;
        }


        private void btnSortText_Click(object sender, EventArgs e)
        {
            _textSorterController.SortText(this.cbSortStrategy.SelectedIndex + 1);
        }

        public string InputText
        {
            get { return this.tbInputText.Text; } 
            set { this.tbInputText.Text = value; } 
        }

        public string OutputText
        {
            get { return this.lblOutput.Text; }
            set { this.lblOutput.Text = value; }
        }

        private void TextSorterView_Load(object sender, EventArgs e)
        {
            this.cbSortStrategy.DataSource = _textSorterController.SortingMethod();
            this.cbSortStrategy.DisplayMember = "Name";
            this.cbSortStrategy.ValueMember = "Value";
        }
    }
}
