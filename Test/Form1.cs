using System;
using System.Windows.Forms;
using Tests;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string ServiceURL = "http://localhost:8747/api/Bot/";
        //string ServiceURL = "http://testapp.nasl-no.com/api/Site/";
        //string ServiceURL = "http://78.158.180.142:8888/api/Test/";
        //string ServiceURL = "http://78.158.180.142:5656/api/Site/";
        //  string ServiceURL = "http://App.TeleSport.ir/api/Site/";
        // string ServiceURL = "http://App.TeleSport.ir/api/test/";
        // string ServiceURL = "http://ws.nasl-no.ir/api/test/";
        // string ServiceURL = "http://app.cloudsport.ir/api/test/";
        //  string ServiceURL = "http://78.158.180.142:8040/api/test/";
        // string ServiceURL = "http://192.168.1.2:8040/api/test/";
        //  string ServiceURL = "http://192.168.1.2:7777/api/test/";

        
        private void button24_Click(object sender, EventArgs e)
        {
            const string function = "GetActiveFields";
            HttpClientHelper.PostJsonData<string>(ServiceURL + function , null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string function = "GetActiveFields";
            HttpClientHelper.PostJsonData<string>(ServiceURL + function, null);
            //string function = "getAllCategories";
            //catJson DevID = new catJson();
            //DevID.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //DevID.CategoryType = 2;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, DevID);
            //richTextBox1.Text = response;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string function = "http://localhost:6625/api/authenticatedvideo/getfilebyvideoid/1/2242";
            //fileJson file = new fileJson();
            //file.userId = 1;
            //file.videoId = 2242;
            //var response = HttpClientHelper.GetJson<string>(function, null);
            //richTextBox1.Text = response;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string function = "webfirstPage";
            //frstJson DevID = new frstJson();
            ////     DevID.deviceGUID = "6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //DevID.deviceGUID = "7B5DBFFE-4505-4A92-8405-8FBD15F04115";
            //DevID.isGuest = true;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, DevID);
            //richTextBox1.Text = response;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string function = "getAllServices";
            //GetServiceJson inputparam = new GetServiceJson();
            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.isGuest = true;
            //inputparam.categoryId = 29;
            //inputparam.justSubscribe = true;
            //inputparam.isFree = true;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string function = "getCategoryInfo";
            //GetServiceJson inputparam = new GetServiceJson();
            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.categoryId = 5;
            //inputparam.isFree = true;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ServiceURL = "http://localhost:6625/api/Cache/";
            ServiceURL = "http://78.158.180.142:5656/api/Cache/";
            ServiceURL = "http://app.telesport.ir/api/Cache/";
            string function = "ClearCache";
            var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string function = "getServiceInfo";
            //ServiceInfoJson inputparam = new ServiceInfoJson();
            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.serviceId = 90;
            //inputparam.isGuest = false;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //string function = "GetVideoInfo";
            //VideoInfoJson inputparam = new VideoInfoJson();
            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.videoId = 1;
            //inputparam.isGuest = false;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //string function = "setRate";
            //rateJson inputparam = new rateJson();
            //inputparam.deviceGUID = "AD9196B8-8B07-4972-B2E1-D953FC37BAF7";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.videoId = 1010;
            //inputparam.rate = 2;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //string function = "bookmarkVideo";
            //bookmarkJson inputparam = new bookmarkJson();
            //inputparam.deviceGUID = "CF506C45-DF00-4373-AA6D-DDAC7A66A689";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.videoId = 1034;
            //inputparam.bookmark = false;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //string function = "GetUserbookmark";
            //getbookmarkJson inputparam = new getbookmarkJson();
            //inputparam.deviceGUID = "AD9196B8-8B07-4972-B2E1-D953FC37BAF7";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //// inputparam.videoId = 394;
            ////inputparam.bookmark = true;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //string function = "Subscribe";
            //SubscriberJson inputparam = new SubscriberJson();
            //inputparam.brand = "1";
            //inputparam.device = "1";
            //inputparam.IMEI = "1";
            //inputparam.model = "1";
            //inputparam.name = "1";
            //inputparam.product = "1";
            //inputparam.release = "1";
            //inputparam.sdk = "1";
            //inputparam.incremental = "1";
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //string function = "CheckVersion";
            //CheckverJson inputparam = new CheckverJson();
            //inputparam.version = (float)0.51;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //string function = "SearchVideo";
            //searchJson inputparam = new searchJson();

            //inputparam.deviceGUID = "2359C88A-5C97-4521-A7E2-BA0AA6ACA1E3";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.KeyWord = "Your";
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //string function = "SearchService";
            //searchJson inputparam = new searchJson();

            //inputparam.deviceGUID = "2359C88A-5C97-4521-A7E2-BA0AA6ACA1E3";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.KeyWord = "دستی‌";
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //string function = "registerUser";
            //clientJson inputparam = new clientJson();

            //inputparam.IMEI = "1";
            //inputparam.Brand = "1";
            //inputparam.BulildID = "1";
            //inputparam.Device = "1";
            //inputparam.Incrimental = "1";
            //inputparam.Model = "1";
            //inputparam.Product = "1";
            //inputparam.Realease = "1";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //string function = "TestGCM";
            //bookmarkJson inputparam = new bookmarkJson();

            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string function = "TestAppShortCode";
            var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, null);
            richTextBox1.Text = response;

        }


        private void button19_Click(object sender, EventArgs e)
        {
            //string function = "LoginUser";
            //Login inputparam = new Login();

            //inputparam.UserName = "09122510930";
            //inputparam.Password = "64241364";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //string function = "GetPackages";
            //bookmarkJson inputparam = new bookmarkJson();
            //// inputparam.deviceGUID = "84A80492-0547-4995-A767-AEFD463F945A";
            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //// inputparam.deviceGUID = "693E55A3-BD6F-4404-9E20-94CDA78DFB9D";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //string function = "GetSiteMap";
            //SiteMapJson inputparam = new SiteMapJson();

            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";


            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void btnServiceComment_Click(object sender, EventArgs e)
        {
            //string function = "SetServiceComment";
            //CommentJson inputparam = new CommentJson();
            //inputparam.deviceGUID = "2359C88A-5C97-4521-A7E2-BA0AA6ACA1E3";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";
            //inputparam.serviceId = 55;
            //inputparam.parentId = 0;
            //inputparam.comment = "my comment from service test2222222222222222";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void btnGetComment_Click(object sender, EventArgs e)
        {
            //string function = "GetServiceComment";
            //CommentJson inputparam = new CommentJson();
            //inputparam.serviceId = 55;
            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //string function = "searchServiceByCat";
            //SearchServiceJson inputparam = new SearchServiceJson();
            //inputparam.CatIds = "54,62,77,72";
            //inputparam.CatTypeIds = "1,2";
            //inputparam.deviceGUID = "2359C88A-5C97-4521-A7E2-BA0AA6ACA1E3";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //string function = "thirdPage";
            //ServiceInfoByUserJson inputparam = new ServiceInfoByUserJson();
            //inputparam.serviceId = long.Parse("54");
            //inputparam.isGuest = bool.Parse("false");
            //inputparam.userId = int.Parse("712257");
            //inputparam.CatId = 54;
            //inputparam.deviceGUID = "3605EDFB-0BA1-4AD9-9BFD-E66DE445E299";//"6ED39A1D-0662-42CC-8102-CF2228B42AD0";

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //string function = "GetAppShortCode";
            //ServiceInfoByUserJson inputparam = new ServiceInfoByUserJson();


            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button26_Click(object sender, EventArgs e)
        {

            //string function = "GetSingleBuyVideos";
            //SingleBuyJson inputparam = new SingleBuyJson();
            //inputparam.deviceGUID = "2359C88A-5C97-4521-A7E2-BA0AA6ACA1E3";
            //inputparam.isGuest = false;

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //string function = "GetSingleBuyServices";
            //SingleBuyJson inputparam = new SingleBuyJson();
            //inputparam.deviceGUID = "2359C88A-5C97-4521-A7E2-BA0AA6ACA1E3";
            //inputparam.isGuest = false;

            //var response = HttpClientHelper.PostJsonData<string>(ServiceURL + function, inputparam);
            //richTextBox1.Text = response;
        }

    }
}

