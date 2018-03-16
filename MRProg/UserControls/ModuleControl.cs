using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MRProg.Module;

namespace MRProg.UserControls
{
    public partial class ModuleControl : UserControl, IModuleControlInerface
    {
        ModuleType _type=ModuleType.KL;
        public ModuleControl()
        {
            InitializeComponent();
        }

        public ModuleType TypeModule
        {
            get { return _type; }
            set { _type = value; }
        }

        public void WriteFile()
        {
            throw new NotImplementedException();
        }
    }
}
