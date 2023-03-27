using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestaurants
{
     sealed class BestaurantApplication
    {
      
        private string FOOD_AND_DRINKS = "Food_And_Drinks";
        private  IApplication _application { get; set; }
        private static BestaurantApplication _bestaurantApplication { get; set; }
      



        public static void CreateInstance(IApplication application)
        {  
            _bestaurantApplication = new BestaurantApplication();
            _bestaurantApplication._application = application;
        }


        public static BestaurantApplication getInstance()
        {
            if (_bestaurantApplication==null)
            {
                _bestaurantApplication= new BestaurantApplication();
            }
            return _bestaurantApplication;
        }


        public ILayer getFoodLayer()
        {

            return getLayerByName(FOOD_AND_DRINKS);
            
        }

        private ILayer getLayerByName(string sLayerName, ILayer pLayer)
        {
            if (pLayer is IFeatureLayer)
            {
                IFeatureLayer pFLayer = (IFeatureLayer)pLayer;
                IDataset pDataset = (IDataset)pFLayer.FeatureClass;
                if (pDataset.Name.ToUpper() == sLayerName.ToUpper())
                {
                    return pFLayer;
                }
                else
                {
                    return null;
                }
            }

            if (pLayer is IGroupLayer)
            {
                ICompositeLayer pGroupLayers = (ICompositeLayer)pLayer;
                for (int j = 0; j < pGroupLayers.Count; j++)
                {
                    ILayer subLayer = pGroupLayers.Layer[j];
                    return getLayerByName(sLayerName, subLayer);
                }
               
            }

            return null;
        }
        

        public ILayer getLayerByName(string sLayerName)
        {
            IMxDocument mxDoc = (IMxDocument)_application.Document;
            IMap pMap = mxDoc.ActiveView.FocusMap;
            

            var numLayer = pMap.LayerCount;
            for (int i = 0; i < numLayer; i++)
            {
                var pLayer = pMap.Layer[i];
                ILayer pFoundLayer = getLayerByName(sLayerName,pLayer);
                if (pFoundLayer!=null)
                {
                    return pFoundLayer;
                }
            }
            return null;
        }






    }

    
}
