using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dx2Timer
{
    class AntiFocusedCheckBox : CheckBox
    {
        public AntiFocusedCheckBox() : base()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
