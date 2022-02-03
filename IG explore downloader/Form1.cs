using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using System.Net;
using OpenQA.Selenium.Interactions;

namespace IG_explore_downloader
{
    public partial class Form1 : Form
    {
        Source Source = new Source();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(explore);
            thread.Start();
            //thread.Start(Source.Start(usernameTxtBox, passwordTxtBox, postCountNum, listBox1, progressBar1));
            //Source.Start();
        }
        public void explore()
        {
            Source.ExploreDownload(usernameTxtBox, passwordTxtBox, postCountNum, console, progressBar1);
        }
        
    }
}
class Source
{
    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
    OpenQA.Selenium.Chrome.ChromeOptions chromeoptions = new ChromeOptions();
    public void ExploreDownload(TextBox userNameTxtBox, TextBox passwordTxtBox, NumericUpDown postCountNum, ListBox lst1, ProgressBar progressBar)
    {
        try
        {
            //Configs
            //chromeoptions.AddArguments("headless", "disable-gpu");
            service.HideCommandPromptWindow = true;
            IWebDriver web = new ChromeDriver(service);
            int rowCount = 1;
            int postCount = (int)postCountNum.Value;
            progressBar.Maximum = postCount;
            string userName = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;
            string URL = "https://instagram.com";
            //Configs

            lst1.Items.Add("Configs are loaded");

            //Login
            web.Navigate().GoToUrl(URL); //OpenURL
            Thread.Sleep(2500);
            IWebElement userNameElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[1]/div/label/input"));
            IWebElement passwordElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[2]/div/label/input"));
            userNameElement.SendKeys(userName);//Enter account informations
            passwordElement.SendKeys(password);
            IWebElement loginBtnElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[3]/button/div"));
            loginBtnElement.Click(); //Login Button click
            Thread.Sleep(7000);
            IWebElement exploreBtnElement = web.FindElement(By.XPath("/html/body/div[1]/section/nav/div[2]/div/div/div[3]/div/div[4]/a"));
            exploreBtnElement.Click(); //Explore Button click
            //Login

            lst1.Items.Add("Login successful");

            //Create Folder to Desktop
            string dateSt = DateTime.Now.ToLongDateString(); //Get Date to String
            string clockSt = DateTime.Now.ToLongTimeString(); //Get Clock to String
            string combineDates = dateSt + " " + clockSt; //Combine Date and Clock Strings
            string combineDatesReplaced = combineDates.Replace(":", "."); //You cant folder name in ":" char
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + combineDatesReplaced; //Final path
            System.IO.Directory.CreateDirectory(folderPath); //Create Folder
            //MessageBox.Show(folderPath + " Folder Created"); //Debug (Not Important)
            //Create Folder to Desktop

            lst1.Items.Add("Folder successfully created");
            lst1.Items.Add("Downloading Posts");

            //Download Posts
            Thread.Sleep(4000);
            for (int i = 1; i <= postCount; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    Thread.Sleep(50);
                    IWebElement postXPath = web.FindElement(By.XPath("/html/body/div[1]/section/main/div/div[1]/div/div[" + rowCount + "]/div[" + y + "]/div/a/div/div[1]/img"));
                    var x = postXPath.GetAttribute("src");
                    Thread.Sleep(50);
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(x), folderPath + "/" + i + ".png");
                    }
                    i++;
                    progressBar.Value ++;
                    Thread.Sleep(50);
                    lst1.Items.Add("Downloaded: " + postCount + "/" + i);
                    if (y == 3)
                    {
                        rowCount++;
                        y = 1;
                    }
                    if (rowCount == 7)
                    {
                        web.Navigate().Refresh();
                        Thread.Sleep(6000);
                        rowCount = 1;
                    }
                    if (i == postCount)
                    {
                        progressBar.Value = progressBar.Maximum;
                        web.Close();
                        break;
                    }
                }
            }
            //Download Posts
            lst1.Items.Add("Posts successfully downloaded");
        }
        catch (Exception)
        {
            lst1.Items.Add("Error, Please restart progress");
            return;
        }
    }
}