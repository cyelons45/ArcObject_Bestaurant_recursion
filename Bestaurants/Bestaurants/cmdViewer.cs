using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;

namespace Bestaurants
{
    /// <summary>
    /// Summary description for cmdViewer.
    /// </summary>
    [Guid("08630329-8348-488f-8411-242a64331f75")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Bestaurants.cmdViewer")]
    public sealed class cmdViewer : BaseCommand
    {
        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommands.Register(regKey);

        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommands.Unregister(regKey);

        }

        #endregion
        #endregion

        private IApplication m_application;
        public cmdViewer()
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = "Bestaurant_Tools"; //localizable text
            base.m_caption = "Restaurant Viewer";  //localizable text
            base.m_message = "View the restaurants in tabular format and interract with the map";  //localizable text 
            base.m_toolTip = "Restaurant Viewer";  //localizable text 
            base.m_name = "Bestaurant_Tools_RestaurantViewer";   //unique id, non-localizable (e.g. "MyCategory_ArcMapCommand")

            try
            {
                //
                // TODO: change bitmap name if necessary
                //
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this command is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {
            if (hook == null)
                return;

            m_application = hook as IApplication;

            //Disable if it is not ArcMap
            if (hook is IMxApplication)
                base.m_enabled = true;
            else
                base.m_enabled = false;

            // TODO:  Add other initialization code
        }

        /// <summary>
        /// Occurs when this command is clicked
        /// </summary>
        public override void OnClick()
        {
            // TODO: Add cmdViewer.OnClick implementation
            Forms.frmRestaurantViewer viewer=new Forms.frmRestaurantViewer();
            var wrapper = new ArcMapWrapper(m_application);
            viewer._application = m_application;
            IMxDocument mxDoc = (IMxDocument)m_application.Document;
            IMap pMap = mxDoc.ActiveView.FocusMap;
            var numLayer=pMap.LayerCount;

            for (int i = 0; i < numLayer; i++)
            {
                var pLayer = pMap.Layer[i];
                viewer.comboBox1.Items.Add(pLayer.Name);
            }
            viewer.Show(wrapper);
        }

    

        #endregion
    }
}
