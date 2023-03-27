using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestaurants.Forms
{
    public partial class frmRestaurantViewer : Form
    {
        public IApplication _application { get; set; }
    
        public frmRestaurantViewer()
        {
            InitializeComponent();
        }

        private void frmRestaurantViewer_Load(object sender, EventArgs e)
        {
            PopulateCategories();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(this.comboBox1.SelectedItem.ToString());
            pLayer.Visible = false;
            IMxDocument mxDoc = (IMxDocument)_application.Document;
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(this.comboBox1.SelectedItem.ToString());
            pLayer.Visible = true;
            IMxDocument mxDoc = (IMxDocument)_application.Document;
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();


        }

        private void cmdRest_Click(object sender, EventArgs e)
        {
           
        }


        private void setDefinitionquery(Int32 cat_code)
        {
            setDefinitionquery("CATEGORY =" + cat_code.ToString());

          
        }

        private void setDefinitionquery(String whereclause)
        {
            ILayer pLayer = BestaurantApplication.getInstance().getFoodLayer();
            IFeatureLayerDefinition layerDef = (IFeatureLayerDefinition)pLayer;
            layerDef.DefinitionExpression = whereclause;
            IMxDocument mxDoc = (IMxDocument)_application.Document;
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();
        }

        private void cmdClick_Click(object sender, EventArgs e)
        {
            var cat_code = (System.Windows.Forms.Button)sender;
            setDefinitionquery(int.Parse(cat_code.Tag.ToString()));
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(this.categorycomboBox2.SelectedItem.ToString());
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IQueryFilter pfilter = new QueryFilter();
            pfilter.WhereClause = "CATEGORY =" + cat_code.Tag.ToString();
            IFeatureCursor pFeaturecursor = pFeatureclass.Search(pfilter, false);
            subPopulateVenues(pFeaturecursor);

        }

        private void subPopulateVenues(IFeatureCursor fcursor)
        {
            
            IFeature pFeature = fcursor.NextFeature();
           
            this.venuescomboBox2.Items.Clear();
            while (pFeature != null)

            {
                Restaurant restaurant = new Restaurant(pFeature);
            
                this.venuescomboBox2.Items.Add(restaurant);
                pFeature = fcursor.NextFeature();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(this.categorycomboBox2.SelectedItem.ToString());
            IFeatureLayer pFeatureLayer =(IFeatureLayer) pLayer;
            IFeatureClass pFeatureclass=pFeatureLayer.FeatureClass;
            IFeatureCursor pFeaturecursor=pFeatureclass.Search(null,false);
            subPopulateVenues(pFeaturecursor);
        }

        private void PopulateCategories()
        {
           
            int code;
            ILayer layer= BestaurantApplication.getInstance().getFoodLayer();
            IFeatureLayer pfeatureLayer =(IFeatureLayer)layer;
            ISubtypes pFeatureclassSubtype =(ISubtypes)pfeatureLayer.FeatureClass;
            IEnumSubtype subtypes=pFeatureclassSubtype.Subtypes;
            subtypes.Reset();
            

            var subtypeText=subtypes.Next(out code);
            this.categorycomboBox2.Items.Clear();
            while (subtypeText!=null)
            {
                var pCategory = new Category();
                pCategory._categorycode = code;
                pCategory._categoryname = subtypeText;
                categorycomboBox2.Items.Add(pCategory);
                subtypeText = subtypes.Next(out code);
            }

        }

        private void categorycomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            venuescomboBox2.Items.Clear();
            Category pSelectedCategory = (Category)categorycomboBox2.SelectedItem;
            setDefinitionquery(int.Parse(pSelectedCategory._categorycode.ToString()));
            ILayer pLayer = BestaurantApplication.getInstance().getFoodLayer();
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IQueryFilter pfilter = new QueryFilter();
            pfilter.WhereClause = "CATEGORY =" + pSelectedCategory._categorycode.ToString();
            IFeatureCursor pFeaturecursor = pFeatureclass.Search(pfilter, false);
            subPopulateVenues(pFeaturecursor);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void venuescomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurant pRestaurant = (Restaurant)venuescomboBox2.SelectedItem;
            if (pRestaurant == null)
            {
                return;
            }
            this.descriptionlabel4.Text = pRestaurant.description;
            this.websitelabel5.Text = pRestaurant.website;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Restaurant pRestaurant = (Restaurant)venuescomboBox2.SelectedItem;
            if (pRestaurant == null)
            {
                return;
            }
            ILayer pLayer = BestaurantApplication.getInstance().getFoodLayer();
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IFeature pFeature=pFeatureclass.GetFeature(pRestaurant.objectId);


            IMxDocument mxDoc = (IMxDocument)_application.Document;
            IMap pMap = mxDoc.ActiveView.FocusMap;
            pMap.ClearSelection();
            pMap.SelectFeature(pLayer, pFeature);
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Restaurant pRestaurant = (Restaurant)venuescomboBox2.SelectedItem;
            if (pRestaurant==null)
            {
                return;
            }
            ILayer pLayer = BestaurantApplication.getInstance().getFoodLayer();

            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IFeature pFeature = pFeatureclass.GetFeature(pRestaurant.objectId);

            IMxDocument mxDoc = (IMxDocument)_application.Document;
            IActiveView activeView = mxDoc.ActiveView;
            IMap pMap = activeView.FocusMap;
            var display = activeView.ScreenDisplay;

            display.StartDrawing(display.hDC, Convert.ToInt16(ESRI.ArcGIS.Display.esriScreenCache.esriNoScreenCache));

            IGeometry point = pFeature.Shape;
            ISimpleMarkerSymbol markersymbol = new SimpleMarkerSymbol();
            markersymbol.Size = 10;

            RgbColor colorn = new RgbColor();
            colorn.Red = 255;
            colorn.Green = 15;
            colorn.Blue = 255;



            markersymbol.Color = colorn;

            var pen = (ISymbol)markersymbol;
            pen.ROP2 = esriRasterOpCode.esriROPNotXOrPen;

            display.SetSymbol((ISymbol)markersymbol);
            display.DrawPoint(point);
            Thread.Sleep(300);
            display.DrawPoint(point);
            Thread.Sleep(300);
            display.DrawPoint(point);
            Thread.Sleep(300);
            display.DrawPoint(point);
            Thread.Sleep(300);
            display.DrawPoint(point);
            Thread.Sleep(300);
            display.DrawPoint(point);
            Thread.Sleep(300);
            display.DrawPoint(point);
            Thread.Sleep(300);

            display.DrawPoint(point);
            display.FinishDrawing();
            //mxDoc.UpdateContents();
            //mxDoc.ActiveView.Refresh();
        }

        private void searchbutton5_Click(object sender, EventArgs e)
        {
      
            ILayer pLayer = BestaurantApplication.getInstance().getFoodLayer();
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IQueryFilter pfilter = new QueryFilter();
            var text_input = searchtextBox1.Text.Replace("'", "''");
            text_input = text_input.ToUpper();
            var querystring = string.Format("UPPER(NAME) LIKE '%{0}%'", text_input);
            pfilter.WhereClause = querystring;
            IFeatureCursor pFeaturecursor = pFeatureclass.Search(pfilter, false);
            subPopulateVenues(pFeaturecursor);

        }

        private void searchtextBox1_TextChanged(object sender, EventArgs e)
        {
            ILayer pLayer = BestaurantApplication.getInstance().getFoodLayer();
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IQueryFilter pfilter = new QueryFilter();
            var text_input = searchtextBox1.Text.Replace("'", "''");
            text_input = text_input.ToUpper();
            var querystring = string.Format("UPPER(NAME) LIKE '%{0}%'", text_input);
            pfilter.WhereClause = querystring;
            IFeatureCursor pFeaturecursor = pFeatureclass.Search(pfilter, false);
            subPopulateVenues(pFeaturecursor);

            setDefinitionquery(pfilter.WhereClause = querystring);
        }
    }
}
