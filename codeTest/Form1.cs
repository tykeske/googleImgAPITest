using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Collections;
using System.IO;
using GoogleApi;
using GoogleSearchApi;
using HtmlAgilityPack;
using System.Net.Http;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace codeTest
{
    public partial class powerPointHelper : Form
    {
        // In production, make sure you're pulling the subscription key from secured storage.
        static string _subscriptionKey = "f1e7440fe61148bcbef8814ff82d114d";

        static string _baseUri = "https://api.bing.microsoft.com/v7.0/images/search";
        // The user's search string.
        
        // To page through the images, you'll need the next offset that Bing returns.
        // To get additional insights about the image, you'll need the image's
        // insights token (see Visual Search API).
        // Bing uses the X-MSEdge-ClientID header to provide users with consistent
        // behavior across Bing API calls. See the reference documentation
        // for usage.
        static string _clientIdHeader = null;
        const string QUERY_PARAMETER = "?q=";  // Required
        const string MKT_PARAMETER = "&mkt=";  // Strongly suggested


        ArrayList sl = new ArrayList();
        GoogleImagesSearcher test = new GoogleImagesSearcher();

        public powerPointHelper()
        {
            InitializeComponent();
        }

        public static void ImageSearch(string ImageQuery)
        {
            


        }

        

        

        private async void searchButton_Click(object sender, EventArgs e)
        {
            await RunAsync();
             async Task RunAsync()
            {
                try
                {
                    string searchString = titleTextBox.Text + ' ' + textBox1.Text;


                    // Remember to encode the q query parameter.
                    var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString);
                    queryString += MKT_PARAMETER + "en-us";
                    HttpResponseMessage response = await MakeRequestAsync(queryString);
                    _clientIdHeader = response.Headers.GetValues("X-MSEdge-ClientID").FirstOrDefault();
                    // This example uses dictionaries instead of objects to access the response data.
                    var contentString = await response.Content.ReadAsStringAsync();
                    Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
                    if (response.IsSuccessStatusCode)
                    {
                        PrintImages(searchResponse);
                        
                    }

                }
                catch (Exception)
                {
                }

                async Task<HttpResponseMessage> MakeRequestAsync(string queryString)
                {
                    string count = "1";
                    string offset = "0";

                    var client = new HttpClient();
                    // Request headers. The subscription key is the only required header but you should
                    // include User-Agent (especially for mobile), X-MSEdge-ClientID, X-Search-Location
                    // and X-MSEdge-ClientIP (especially for local aware queries).
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);
                    return await client.GetAsync(string.Format("{0}q={1}&count={1}", _baseUri + queryString, count, offset));
                }


                void PrintImages(Dictionary<string, object> response)
                {
                    // This example prints the first page of images but if you want to page
                    // through the images, you need to capture the next offset that Bing returns.
                    var images = response["value"] as Newtonsoft.Json.Linq.JToken;
                    foreach (Newtonsoft.Json.Linq.JToken image in images)
                    {
                        string imageURL = (image["contentUrl"]).ToString();
                        searchBox.Text = imageURL;
                        optionOnePicture.ImageLocation = imageURL;
                        // If you want to get additional insights about the image, capture the
                        // image token that you use when calling Visual Search API.       
                    }

                }
            }

            if (titleTextBox.Text == "" || slideTextBox.Text == "")
            {
                errorProvider1.SetError(this.titleTextBox, "Title is required!");
                errorProvider2.SetError(this.slideTextBox, "Slide text is required!");
            }
            else
            {
                ImageSearch(titleTextBox.Text + " " + textBox1.Text);
                optionOneCheckBox.Visible = true;
                optionOnePicture.Visible = true;
                optionTwoCheckBox.Visible = true;
                optionTwoPicture.Visible = true;
                optionThreeCheckBox.Visible = true;
                optionThreePicture.Visible = true;
            }


        }
        private void titleTextBox_Validated(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            return;
        }

        private void slideTextBox_TextChanged(object sender, EventArgs e)
        {
           
            
            errorProvider2.Clear();
            return;
        }

        private void powerPointHelper_Load(object sender, EventArgs e)
        {
            searchBox.Visible = true;
            optionOneCheckBox.Visible = false;
            optionOnePicture.Visible = false;

            optionTwoCheckBox.Visible = false;
            optionTwoPicture.Visible = false;

            optionThreeCheckBox.Visible = false;
            optionThreePicture.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = null;
            slideTextBox.Text = null;
            sl.Clear();

            optionOneCheckBox.Visible = false;
            optionOnePicture.Visible = false;

            optionTwoCheckBox.Visible = false;
            optionTwoPicture.Visible = false;

            optionThreeCheckBox.Visible = false;
            optionThreePicture.Visible = false;

            
        }

        private void titleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            sl.Add(slideTextBox.SelectedText + " ");
            slideTextBox.SelectionFont = new Font(slideTextBox.Font, FontStyle.Bold);

            string temp = string.Empty;

            foreach (String var in sl)
            {
                temp = temp + var.ToString();

            }
            searchBox.Text = temp;
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            
            //make highlighted text bold
            slideTextBox.SelectionFont = new Font(slideTextBox.Font, FontStyle.Bold);

            //add highlighted text to array list
            sl.Add(slideTextBox.SelectedText + " ");

            //convert array list into string so that it can be used in the search
            string temp = string.Empty;
            foreach (String var in sl)
            {
                temp = temp + var.ToString();

            }
            textBox1.Text = temp;

            Refresh();
            
        }
    }
}
