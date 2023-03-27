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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestaurants.Forms
{

    public partial class InputForm : Form
    {
        //internal IApplication m_application;
        public IApplication m_application { get; set; }
        public IPoint mapPoint { get; set; }
        public string FOOD_AND_DRINKS = "Food_And_Drinks";
        int ObjectId;

        public InputForm()
        {
            InitializeComponent();
        }


        private void PopulateCategories()
        {

            int code;
            ILayer layer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pfeatureLayer = (IFeatureLayer)layer;
            ISubtypes pFeatureclassSubtype = (ISubtypes)pfeatureLayer.FeatureClass;
            IEnumSubtype subtypes = pFeatureclassSubtype.Subtypes;
            subtypes.Reset();


            var subtypeText = subtypes.Next(out code);
            this.categorycomboBox2.Items.Clear();
            while (subtypeText != null)
            {
                var pCategory = new Category();
                pCategory._categorycode = code;
                pCategory._categoryname = subtypeText;
                categorycomboBox2.Items.Add(pCategory);
                subtypeText = subtypes.Next(out code);
            }

        }




        private void InputForm_Load(object sender, EventArgs e)
        {


            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IDataset pDataset = (IDataset)pFeatureclass;
            IWorkspace pWorkspace = pDataset.Workspace;
         


            ITopologicalOperator pPoint = (ITopologicalOperator)mapPoint;
            IGeometry pBuffer = pPoint.Buffer(32);
            DrawBufferGeometry(pBuffer);
            ISpatialFilter sFilter = new SpatialFilter();
            sFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
            sFilter.Geometry = pBuffer;
            IFeatureCursor fCursor = pFeatureclass.Search(sFilter, false);
            IFeature selectedFeature = fCursor.NextFeature();

            if (selectedFeature != null)
            {
                PopulateCategories();
                this.editbutton1.Visible = true;
                this.savebutton1.Visible = false;
                this.deletebutton1.Visible = true;
                this.ObjectId = selectedFeature.OID;
                var nameField = selectedFeature.Value[selectedFeature.Fields.FindField("NAME")].ToString();
                var pCategory = selectedFeature.Value[selectedFeature.Fields.FindField("CATEGORY")].ToString();

                var descriptionField = selectedFeature.Value[selectedFeature.Fields.FindField("DESCRIPTION")].ToString();
                var websiteField = selectedFeature.Value[selectedFeature.Fields.FindField("WEBSITE")].ToString();

                this.searchtextBox1.Text = nameField;
                this.descriptiontextBox1.Text = descriptionField;
                this.websitetextBox1.Text = websiteField;
                this.categorycomboBox2.SelectedIndex = Int32.Parse(pCategory);

                IFeatureWorkspace fWorkspace = (IFeatureWorkspace)pWorkspace;
                ITable reviewsTable = fWorkspace.OpenTable("VENUES_REVIEW");
                IQueryFilter filter = new QueryFilter();
                filter.WhereClause = "VENUE_OBJECTID=" + this.ObjectId;
                ICursor tCursor=reviewsTable.Search(filter,true);

                IRow pRow=tCursor.NextRow();
                Double IRating = 0;
                int TotalReviews = 0;
                while (pRow!=null)
                {
                    TotalReviews += 1;
                    IRating = IRating +Int32.Parse(pRow.Value[pRow.Fields.FindField("RATING")].ToString());
                   pRow = tCursor.NextRow();
                }
                if (TotalReviews>0)
                {
                    Double IAverageRating =IRating / TotalReviews;
                    this.lblRating.Text = Math.Round(IAverageRating,1).ToString();
                    this.number_of_reviewslabel6.Text = "based on " + TotalReviews + " review(s)";
                    this.starRating1.SetRating(IAverageRating);
                }
                else
                {
                    this.lblRating.Text = "No Reviews";
                    this.number_of_reviewslabel6.Text = "";
                }
               

            }
            else
            {
                PopulateCategories();
                this.editbutton1.Visible = false;
                this.deletebutton1.Visible = false;
                this.savebutton1.Visible = true;
                this.lblRating.Text = "No Reviews";
            }

           
           
        }

        private void categorycomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void savebutton1_Click(object sender, EventArgs e)
        {

            if (this.searchtextBox1.Text==""|| this.websitetextBox1.Text==""|| this.descriptiontextBox1.Text=="")
            {
                MessageBox.Show("Invalid Empty Field");
                return;
            }
            var wrapper = new ArcMapWrapper(m_application);



            IMxDocument mxDoc = (IMxDocument)m_application.Document;
            IActiveView activeView = mxDoc.ActiveView;
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;



            IDataset pDataset = (IDataset)pFeatureclass;
            var pWorkspace = (IWorkspaceEdit)pDataset.Workspace;
            pWorkspace.StartEditOperation();
            pWorkspace.StartEditing(true);

    
            IFeature feature = pFeatureclass.CreateFeature();
            feature.Shape = mapPoint;
            feature.Value[feature.Fields.FindField("NAME")] = this.searchtextBox1.Text;

            Category pCategory = (Category)this.categorycomboBox2.SelectedItem;
            feature.Value[feature.Fields.FindField("CATEGORY")] = pCategory._categorycode;
            feature.Value[feature.Fields.FindField("DESCRIPTION")] = this.descriptiontextBox1.Text;
            feature.Value[feature.Fields.FindField("WEBSITE")] = this.websitetextBox1.Text;
            feature.Store();

            pWorkspace.StopEditing(true);
            pWorkspace.StopEditOperation();
            this.Close();
            this.Dispose();
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();

        }

        private void DrawBufferGeometry(IGeometry geometry)
        {
           

            IMxDocument mxDoc = (IMxDocument)m_application.Document;
  
            IActiveView activeView = mxDoc.ActiveView;
            IMap pMap = activeView.FocusMap;
            
            var display = activeView.ScreenDisplay;

            display.StartDrawing(display.hDC, Convert.ToInt16(ESRI.ArcGIS.Display.esriScreenCache.esriNoScreenCache));
            ISimpleFillSymbol markersymbol = new SimpleFillSymbol();
            markersymbol.Style = esriSimpleFillStyle.esriSFSDiagonalCross;
             RgbColor colorn = new RgbColor();
            colorn.Red = 255;
            colorn.Green = 15;
            colorn.Blue = 255;
            markersymbol.Color = colorn;


            display.SetSymbol((ISymbol)markersymbol);
 
            display.DrawPolygon(geometry);
            display.FinishDrawing();
           
        }

        private void editbutton1_Click(object sender, EventArgs e)
        {

            IMxDocument mxDoc = (IMxDocument)m_application.Document;
            IActiveView activeView = mxDoc.ActiveView;
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            var feature = pFeatureclass.GetFeature(this.ObjectId);
            IDataset pDataset = (IDataset)pFeatureclass;
            IWorkspace pWorkspace=pDataset.Workspace;
           IWorkspaceEdit pWorkspaceEdit =(IWorkspaceEdit) pWorkspace;
            pWorkspaceEdit.StartEditing(true);
            pWorkspaceEdit.StartEditOperation();

           
            feature.Value[feature.Fields.FindField("NAME")] = this.searchtextBox1.Text;

            Category pCategory = (Category)this.categorycomboBox2.SelectedItem;
            feature.Value[feature.Fields.FindField("CATEGORY")] =Int32.Parse(pCategory._categorycode.ToString());
            feature.Value[feature.Fields.FindField("DESCRIPTION")] = this.descriptiontextBox1.Text;
            feature.Value[feature.Fields.FindField("WEBSITE")] = this.websitetextBox1.Text;
            feature.Store();

            pWorkspaceEdit.StopEditOperation();
            pWorkspaceEdit.StopEditing(true);
            this.Close();
            this.Dispose();
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();

        }

        private void deletebutton1_Click(object sender, EventArgs e)
        {
            IMxDocument mxDoc = (IMxDocument)m_application.Document;
            IActiveView activeView = mxDoc.ActiveView;
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            var feature = pFeatureclass.GetFeature(this.ObjectId);
            IDataset pDataset = (IDataset)pFeatureclass;
            IWorkspace pWorkspace = pDataset.Workspace;
            IWorkspaceEdit pWorkspaceEdit = (IWorkspaceEdit)pWorkspace;
            pWorkspaceEdit.StartEditing(true);
            pWorkspaceEdit.StartEditOperation();


            feature.Delete();

            pWorkspaceEdit.StopEditOperation();
            pWorkspaceEdit.StopEditing(true);
            this.Close();
            this.Dispose();
            mxDoc.UpdateContents();
            mxDoc.ActiveView.Refresh();

        }

        private void number_of_reviewslabel6_Click(object sender, EventArgs e)
        {

            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IDataset pDataset = (IDataset)pFeatureclass;
            IWorkspace pWorkspace = pDataset.Workspace;

            IFeatureWorkspace fWorkspace = (IFeatureWorkspace)pWorkspace;
            ITable reviewsTable = fWorkspace.OpenTable("VENUES_REVIEW");
            IQueryFilter filter = new QueryFilter();
            filter.WhereClause = "VENUE_OBJECTID=" + this.ObjectId;
            ICursor tCursor = reviewsTable.Search(filter, true);
            IRow pRow = tCursor.NextRow();
            Double IRating = 0;
            int TotalReviews = 0;
            var reviewString = "";
            while (pRow != null)
            {
                TotalReviews += 1;
                IRating = IRating + Int32.Parse(pRow.Value[pRow.Fields.FindField("RATING")].ToString());
                var user = pRow.Value[pRow.Fields.FindField("USER")].ToString();
                var review = pRow.Value[pRow.Fields.FindField("REVIEW")].ToString();
                var date = pRow.Value[pRow.Fields.FindField("REVIEW_DATE")].ToString();
                reviewString = reviewString + Environment.NewLine + "Reviewed by " + user + "(" + IRating.ToString() + ") on" + date + " " + review + Environment.NewLine + "----------------------------";

                pRow = tCursor.NextRow();
            }

            MessageBox.Show(reviewString,"REVIEWS");
           
        }

        private void submitreview_button1_Click(object sender, EventArgs e)
        {

    
            ILayer pLayer = BestaurantApplication.getInstance().getLayerByName(FOOD_AND_DRINKS);
            IFeatureLayer pFeatureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureclass = pFeatureLayer.FeatureClass;
            IDataset pDataset = (IDataset)pFeatureclass;
            IWorkspace pWorkspace = pDataset.Workspace;
            IFeatureWorkspace fWorkspace = (IFeatureWorkspace)pWorkspace;
            ITable reviewsTable = fWorkspace.OpenTable("VENUES_REVIEW");

            var pWorkspaceEdit = (IWorkspaceEdit)pDataset.Workspace;
            pWorkspaceEdit.StartEditing(true);
            IRow pNewRow=reviewsTable.CreateRow();
            pNewRow.Value[pNewRow.Fields.FindField("VENUE_OBJECTID")] = this.ObjectId;
            pNewRow.Value[pNewRow.Fields.FindField("USER")] = this.user_textBox1.Text;
            pNewRow.Value[pNewRow.Fields.FindField("RATING")] = this.rating_comboBox1.SelectedIndex;
            pNewRow.Value[pNewRow.Fields.FindField("REVIEW")] = this.review_textBox3.Text;
            pNewRow.Value[pNewRow.Fields.FindField("REVIEW_DATE")] = DateTime.Now;
            pNewRow.Store();
            this.Close();
            this.Dispose();
            pWorkspaceEdit.StopEditOperation();
            pWorkspaceEdit.StopEditing(true);
           
        }
    }
}
