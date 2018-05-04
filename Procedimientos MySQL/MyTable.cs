using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos_MySQL
{
    class MyTable: Form
    {
        public FlowLayoutPanel mainform;
        public FrmModelo frtabla = new FrmModelo();
        public MyTable(FlowLayoutPanel mf)
        {
            mainform = mf;

            this.Controls.Add(frtabla);
        }

    }
}
