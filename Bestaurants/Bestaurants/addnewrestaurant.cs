using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using System.Windows.Forms;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;

namespace Bestaurants
{
    /// <summary>
    /// Summary description for addnewrestaurant.
    /// </summary>
    [Guid("8c01b0f5-8641-4d11-835a-59dae6be07a0")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Bestaurants.addnewrestaurant")]
    public sealed class addnewrestaurant : BaseTool
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
        //public int MyProperty { get; set; }
        Forms.InputForm inputform;
        public string FOOD_AND_DRINKS = "Food_And_Drinks";
        public addnewrestaurant()
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = "Bestaurant_Tools"; //localizable text
            base.m_caption = "Add a new restaurant";  //localizable text
            base.m_message = "Click on the map to add a new restaurant and populate its iformation";  //localizable text 
            base.m_toolTip = "Restaurant Viewer";  //localizable text 
            base.m_name = "Bestaurant_Tools_Add_a_new_restaurant";   //unique id, non-localizable (e.g. "MyCategory_ArcMapCommand")



            try
            {
                //
                // TODO: change resource name if necessary
                //
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
                base.m_cursor = new System.Windows.Forms.Cursor(GetType(), GetType().Name + ".cur");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this tool is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {
            m_application = hook as IApplication;

            //Disable if it is not ArcMap
            if (hook is IMxApplication)
                base.m_enabled = true;
            else
                base.m_enabled = false;

            // TODO:  Add other initialization code
            BestaurantApplication.CreateInstance(m_application);
        }

        /// <summary>
        /// Occurs when this tool is clicked
        /// </summary>
        public override void OnClick()
        {
            // TODO: Add addnewrestaurant.OnClick implementation
        }

        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add addnewrestaurant.OnMouseDown implementation
        }

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add addnewrestaurant.OnMouseMove implementation
        }




        private void PopulateCategories()
        {

            int code;
            var inputform = new Forms.InputForm();
            ILayer layer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pfeatureLayer = (IFeatureLayer)layer;
            ISubtypes pFeatureclassSubtype = (ISubtypes)pfeatureLayer.FeatureClass;
            IEnumSubtype subtypes = pFeatureclassSubtype.Subtypes;
            subtypes.Reset();


            var subtypeText = subtypes.Next(out code);
            inputform.categorycomboBox2.Items.Clear();
            while (subtypeText != null)
            {
                var pCategory = new Category();
                pCategory._categorycode = code;
                pCategory._categoryname = subtypeText;
                inputform.categorycomboBox2.Items.Add(pCategory);
                subtypeText = subtypes.Next(out code);
            }

        }


        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add addnewrestaurant.OnMouseUp implementation
             var wrapper = new ArcMapWrapper(m_application);
        

            IMxDocument mxDoc = (IMxDocument)m_application.Document;
            IActiveView activeView = mxDoc.ActiveView;
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();

            IScreenDisplay screenDisplay = activeView.ScreenDisplay;
            IDisplayTransformation displayTransformation = screenDisplay.DisplayTransformation;
            IPoint mapPoint = displayTransformation.ToMapPoint((System.Int32)X, (System.Int32)Y);

          
            if (inputform == null || inputform.IsDisposed)
            {
                inputform = new Forms.InputForm();
                inputform.mapPoint = mapPoint;
                if (!inputform.Visible)
                {
                    
                    inputform.m_application = m_application;
                    inputform.Show(wrapper);
                }
              
            }
           



        }
        #endregion
    }
}
