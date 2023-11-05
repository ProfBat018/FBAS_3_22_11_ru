using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Maps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string BingMapsKey = "ArpP9nFPyA0rRifGUHr3ODwINte9GHhcAjF0WJhjB7Eoi0bD42ZK7Nc0fbUo0Api";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Geocode an address and return a latitude and longitude
        public XmlDocument Geocode(string addressQuery)
        {
            //Create REST Services geocode request using Locations API
            string geocodeRequest = "http://dev.virtualearth.net/REST/v1/Locations/" + addressQuery + "?o=xml&key=" + BingMapsKey;

            //Make the request and get the response
            XmlDocument geocodeResponse = GetXmlResponse(geocodeRequest);

            return (geocodeResponse);
        }


        // Submit a REST Services or Spatial Data Services request and return the response
        private XmlDocument GetXmlResponse(string requestUrl)
        {
            System.Diagnostics.Trace.WriteLine("Request URL (XML): " + requestUrl);
            HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format("Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                return xmlDoc;
            }
        }

        //Search for POI near a point
        private void FindandDisplayNearbyPOI(XmlDocument xmlDoc)
        {
            //Get location information from geocode response 

            //Create namespace manager
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("rest", "http://schemas.microsoft.com/search/local/ws/rest/v1");

            //Get all geocode locations in the response 
            XmlNodeList locationElements = xmlDoc.SelectNodes("//rest:Location", nsmgr);
            if (locationElements.Count == 0)
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Content = "The location you entered could not be geocoded.";
            }
            else
            {
                //Get the geocode location points that are used for display (UsageType=Display)
                XmlNodeList displayGeocodePoints =
                        locationElements[0].SelectNodes(".//rest:GeocodePoint/rest:UsageType[.='Display']/parent::node()", nsmgr);
                string latitude = displayGeocodePoints[0].SelectSingleNode(".//rest:Latitude", nsmgr).InnerText;
                string longitude = displayGeocodePoints[0].SelectSingleNode(".//rest:Longitude", nsmgr).InnerText;
                ComboBoxItem entityTypeID = (ComboBoxItem)EntityType.SelectedItem;
                ComboBoxItem distance = (ComboBoxItem)Distance.SelectedItem;

                //Create the Bing Spatial Data Services request to get the user-specified POI entity type near the selected point  
                string findNearbyPOIRequest = "http://spatial.virtualearth.net/REST/v1/data/f22876ec257b474b82fe2ffcb8393150/NavteqNA/NavteqPOIs?spatialfilter=nearby("
                + latitude + "," + longitude + "," + distance.Content + ")"
                + "&$filter=EntityTypeID%20EQ%20'" + entityTypeID.Tag + "'&$select=EntityID,DisplayName,__Distance,Latitude,Longitude,AddressLine,Locality,AdminDistrict,PostalCode&$top=10"
                + "&key=" + BingMapsKey;

                //Submit the Bing Spatial Data Services request and retrieve the response
                XmlDocument nearbyPOI = GetXmlResponse(findNearbyPOIRequest);

                //Center the map at the geocoded location and display the results
                myMap.Center = new Location(Convert.ToDouble(latitude), Convert.ToDouble(longitude));
                myMap.ZoomLevel = 12;
                DisplayResults(nearbyPOI);

            }
        }


        //Add label element to application
        private void AddLabel(Panel parent, string labelString)
        {
            Label dname = new Label();
            dname.Content = labelString;
            dname.Style = (Style)FindResource("AddressStyle");
            parent.Children.Add(dname);
        }

        //Add a pushpin with a label to the map
        private void AddPushpinToMap(double latitude, double longitude, string pinLabel)
        {
            Location location = new Location(latitude, longitude);
            Pushpin pushpin = new Pushpin();
            pushpin.Content = pinLabel;
            pushpin.Location = location;
            myMap.Children.Add(pushpin);
        }

        //Show the POI address information and insert pushpins on the map
        private void DisplayResults(XmlDocument nearbyPOI)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(nearbyPOI.NameTable);
            nsmgr.AddNamespace("d", "http://schemas.microsoft.com/ado/2007/08/dataservices");
            nsmgr.AddNamespace("m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");
            nsmgr.AddNamespace("a", "http://www.w3.org/2005/Atom");

            XmlNodeList displayNameList = nearbyPOI.SelectNodes("//d:DisplayName", nsmgr);
            
            if (displayNameList.Count == 0)
            {
                ErrorMessage.Content = "No results were found for this location.";
                ErrorMessage.Visibility = Visibility.Visible;
            }
            else
            {
                XmlNodeList addressLineList = nearbyPOI.SelectNodes("//d:AddressLine", nsmgr);
                XmlNodeList localityList = nearbyPOI.SelectNodes("//d:Locality", nsmgr);
                XmlNodeList adminDistrictList = nearbyPOI.SelectNodes("//d:AdminDistrict", nsmgr);
                XmlNodeList postalCodeList = nearbyPOI.SelectNodes("//d:PostalCode", nsmgr);
                XmlNodeList latitudeList = nearbyPOI.SelectNodes("//d:Latitude", nsmgr);
                XmlNodeList longitudeList = nearbyPOI.SelectNodes("//d:Longitude", nsmgr);
                for (int i = 0; i < displayNameList.Count; i++)
                {
                    AddLabel(AddressList, "[" + Convert.ToString(i + 1) + "] " + displayNameList[i].InnerText);
                    AddLabel(AddressList, addressLineList[i].InnerText);
                    AddLabel(AddressList, localityList[i].InnerText + ", " + adminDistrictList[i].InnerText);
                    AddLabel(AddressList, postalCodeList[i].InnerText);
                    AddLabel(AddressList, "");
                    AddPushpinToMap(Convert.ToDouble(latitudeList[i].InnerText), Convert.ToDouble(longitudeList[i].InnerText), Convert.ToString(i + 1));
                }
                SearchResults.Visibility = Visibility.Visible;
                myMap.Visibility = Visibility.Visible;
                myMapLabel.Visibility = Visibility.Visible;
                myMap.Focus(); //allows '+' and '-' to zoom the map
            }

        }

        //Search for POI elements when the Search button is clicked
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //Clear prior search
            myMap.Visibility = Visibility.Hidden;
            myMapLabel.Visibility = Visibility.Collapsed;
            myMap.Children.Clear();
            SearchResults.Visibility = Visibility.Collapsed;
            AddressList.Children.Clear();
            ErrorMessage.Visibility = Visibility.Collapsed;


            //Get latitude and longitude coordinates for specified location
            XmlDocument searchResponse = Geocode(SearchNearby.Text);


            //FindandDisplayNearbyPOI(searchResponse);
        }
    }
}
