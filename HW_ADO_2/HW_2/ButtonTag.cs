using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2
{
    public class ButtonTag
    {
        public Label label;
        public TextBox textBox;
        public ProgressBar progressBar;
        public string SQLQuery;

        public ButtonTag(Label lb, TextBox tb, ProgressBar pb, string Query)
        {
            label = lb;
            textBox = tb;
            progressBar = pb;
            SQLQuery = Query;
        }


    }
}
