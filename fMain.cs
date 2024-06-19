using OpenQA.Selenium;

namespace AutoClicker
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        ClassNeoBux neoBux;
        string login = "Chubic";
        string password = "lURBE27H1fGbaCz1NIG";
        int adPrize = 0;


        private void btnNeoBux_Click(object sender, EventArgs e)
        {
            bool needCapcha = false;
            neoBux = new ClassNeoBux();
            neoBux.InitBrowser();
            neoBux.GoToWebPage("https://www.neobux.com");
            neoBux.ClickElementByLinkText("Login");
            neoBux.InputLogin(login);
            neoBux.InputPassword(password);

            needCapcha = neoBux.ElementExistId("Kf3");
            if (needCapcha)
            {
                pbCapcha.Image = neoBux.GetCapchaPicture();
            }
            else
            {
                neoBux.ClickElementById("botao_login");
                neoBux.ClickElementByLinkText("View Advertisements");
                ClickAdvertisements();
                int adPrize = neoBux.GetCountFromElementId("ap_hct");
                if (adPrize > 0)
                {
                    GoToAdPrize();
                    ClickAdPrize();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool needCapcha = false;

            neoBux.InputCapcha(txtCapcha.Text);
            neoBux.ClickElementById("botao_login");
            needCapcha = neoBux.ElementExistId("Kf3");
            
            if (needCapcha)
            {
                neoBux.InputLogin(login);
                neoBux.InputPassword(password);
                pbCapcha.Image = neoBux.GetCapchaPicture();
            }
            else 
            {
                //neoBux.ClickElementById("botao_login");
                neoBux.ClickElementByLinkText("View Advertisements");
                ClickAdvertisements();

                adPrize = neoBux.GetCountFromElementId("ap_hct");
                if (adPrize > 0)
                {
                    GoToAdPrize();
                    ClickAdPrize();
                }
                
            }
        }
        private void GoToAdPrize()
        {
            neoBux.ClickElementById("ap_hct");
        }

        private void ClickAdPrize()
        {
            bool next = false;
            neoBux.MoveToTab(1);
            int adPrizeCount = adPrize;
            while (adPrizeCount > 0)
            {
                neoBux.ClickElementById("nxt_bt_a");
                adPrizeCount = neoBux.GetCountFromElementId("rmnDv");
            }
            
            neoBux.ClickElementByLinkText("Close");
            neoBux.MoveToTab(0);
        }
        private void ClickAdvertisements()
        {
            int advCount = neoBux.GetCountFromElementClass("badge");

            for (int i = 1; i <= advCount; i++)
            {
                neoBux.ClickElementById("l0l" + i);
                neoBux.ClickElementById("i" + i);
                neoBux.MoveToTab(1);
                neoBux.ClickElementByLinkText("Close");
                neoBux.MoveToTab(0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            neoBux.ExitProgram();
        }
    }
}
