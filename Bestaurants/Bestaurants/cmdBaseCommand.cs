using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Catalog;

namespace Bestaurants
{
    /// <summary>
    /// Summary description for cmdBaseCommand.
    /// </summary>
    [Guid("3465de06-ec1e-4583-aa49-66415499a522")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Bestaurants.cmdBaseCommand")]
    public sealed class cmdBaseCommand : BaseCommand
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
        public cmdBaseCommand()
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = "Bestaurant_Tools"; //localizable text
            base.m_caption = "Load Data";  //localizable text
            base.m_message = "Load Data into ArcMap from external files";  //localizable text 
            base.m_toolTip = "Load Data";  //localizable text 
            base.m_name = "Bestaurant_Tools_LoadData";   //unique id, non-localizable (e.g. "MyCategory_ArcMapCommand")

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
            // TODO: Add cmdBaseCommand.OnClick implementation
            IWorkspaceFactory pWorkspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace pWorkspace=pWorkspaceFactory.OpenFromFile("C:\\ArcObjects\\starter2\\Bestaurants.gdb", m_application.hWnd);
            IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
            IFeatureClass pFoodanddrinks = pFeatureWorkspace.OpenFeatureClass("Food_and_Drinks");
            IFeatureClass pLandbase = pFeatureWorkspace.OpenFeatureClass("Belize_Landbase");


            IGxLayer gxLayer = new GxLayerClass();
            IGxFile gxFile = (IGxFile)gxLayer;
            gxFile.Path = "C:\\ArcObjects\\starter2\\Food_And_Drinks.lyr";

            IGxLayer gbLayer = new GxLayerClass();
            IGxFile gbFile = (IGxFile)gbLayer;
            gbFile.Path = "C:\\ArcObjects\\starter2\\Belize_Landbase.lyr";
            IMxDocument mxDoc = (IMxDocument)m_application.Document;
            mxDoc.ActiveView.FocusMap.ClearLayers();

            ILayer bLayer = gbLayer.Layer;
            ILayer pLayer=gxLayer.Layer;

            if (!(bLayer == null))
            {
           
                if (bLayer is IFeatureLayer)
                {
                    IFeatureLayer pFeaturelayer = (IFeatureLayer)bLayer;
                    pFeaturelayer.FeatureClass = pLandbase;
                    pFeaturelayer.Name = pLandbase.AliasName;

                    mxDoc.ActiveView.FocusMap.AddLayer(pFeaturelayer);
                }
               

               
            }

            if (!(pLayer == null))
            {
                if (pLayer is IFeatureLayer)
                {
                    IFeatureLayer pFeaturelayer = (IFeatureLayer)pLayer;
                    pFeaturelayer.FeatureClass = pFoodanddrinks;
                    pFeaturelayer.Name = pFoodanddrinks.AliasName;
                 
                    mxDoc.ActiveView.FocusMap.AddLayer(pFeaturelayer);
                }
              
              
              
            }


    
            //IFeatureLayer pFeatureLayer = new FeatureLayer();

            //IFeatureLayer fLandbase = new FeatureLayer();
            //pFeatureLayer.Name = "Food_and_Drinks";
            //fLandbase.Name = "Belize_Landbase";
            //fLandbase.FeatureClass = pLandbase;
            //pFeatureLayer.FeatureClass = pFoodanddrinks;
            //IMxDocument mxDoc = (IMxDocument)m_application.Document;

            //mxDoc.ActiveView.FocusMap.AddLayer(fLandbase);
            //mxDoc.ActiveView.FocusMap.AddLayer(pFeatureLayer);





            //var pFeaturecount=pFoodanddrinks.FeatureCount(null);
            //IQueryFilter pFilter = new QueryFilter();
            //pFilter.WhereClause = "CATEGORY=2";
            //pFoodanddrinks.Search(pFilter, false);







            MessageBox.Show("Layer has been added");
        }

        #endregion
    }
}
