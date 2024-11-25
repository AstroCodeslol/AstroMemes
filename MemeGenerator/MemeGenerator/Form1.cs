using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MemeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string memeData;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void nextmeme_btn_Click(object sender, EventArgs e)
        {
            string subredditUrl = "https://www.reddit.com/r/memes/random/.json";

            try
            {
                // Fetch the meme JSON data
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "MemeFetcherApp");
                    string jsonResponse = await client.GetStringAsync(subredditUrl);

                    // Parse the JSON to extract the meme URL
                    JArray jsonArray = JArray.Parse(jsonResponse);
                    string memeUrl = jsonArray[0]["data"]["children"][0]["data"]["url"].ToString();
                    memeData = memeUrl;

                    // Set the PictureBox image
                    memeBox.Load(memeUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void memeBox_Click(object sender, EventArgs e)
        {

        }

        private void savememe_btn_Click(object sender, EventArgs e)
        {
            int saveCount = 0;
            string filePath = $"C:\\Users\\Lenovo\\Downloads\\Meme ({saveCount}).png";

            memeBox.Image.Save(filePath);

        }
    }
}