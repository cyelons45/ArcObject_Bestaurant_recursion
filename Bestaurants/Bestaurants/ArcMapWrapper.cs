using ESRI.ArcGIS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestaurants
{
    class ArcMapWrapper: IWin32Window
    {
        private IApplication _arcMapApplication;

        public ArcMapWrapper(IApplication m_application)
        {
            _arcMapApplication = m_application;
        }

        public IntPtr Handle
        {
            get { return new IntPtr(_arcMapApplication.hWnd); }

        }
    }
}



