namespace GroupProject
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            auctionTabs = new TabControl();
            mainMenu = new TabPage();
            button1 = new Button();
            tutorialPage = new TabPage();
            loadingPage = new TabPage();
            infoPage = new TabPage();
            auctionPurchasePage = new TabPage();
            aucRepPage = new TabPage();
            aucSalePage = new TabPage();
            leaderboardPage = new TabPage();
            LabelName = new Label();
            auctionTabs.SuspendLayout();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // auctionTabs
            // 
            auctionTabs.Controls.Add(mainMenu);
            auctionTabs.Controls.Add(tutorialPage);
            auctionTabs.Controls.Add(loadingPage);
            auctionTabs.Controls.Add(infoPage);
            auctionTabs.Controls.Add(auctionPurchasePage);
            auctionTabs.Controls.Add(aucRepPage);
            auctionTabs.Controls.Add(aucSalePage);
            auctionTabs.Controls.Add(leaderboardPage);
            auctionTabs.Location = new Point(-1, 0);
            auctionTabs.Name = "auctionTabs";
            auctionTabs.SelectedIndex = 0;
            auctionTabs.Size = new Size(1156, 636);
            auctionTabs.TabIndex = 0;
            // 
            // mainMenu
            // 
            mainMenu.Controls.Add(LabelName);
            mainMenu.Controls.Add(button1);
            mainMenu.Location = new Point(4, 24);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(3);
            mainMenu.Size = new Size(1148, 608);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "MainMenu";
            mainMenu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(782, 300);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // tutorialPage
            // 
            tutorialPage.Location = new Point(4, 24);
            tutorialPage.Name = "tutorialPage";
            tutorialPage.Padding = new Padding(3);
            tutorialPage.Size = new Size(1148, 608);
            tutorialPage.TabIndex = 1;
            tutorialPage.Text = "TutorialPage";
            tutorialPage.UseVisualStyleBackColor = true;
            // 
            // loadingPage
            // 
            loadingPage.Location = new Point(4, 24);
            loadingPage.Name = "loadingPage";
            loadingPage.Padding = new Padding(3);
            loadingPage.Size = new Size(1148, 608);
            loadingPage.TabIndex = 2;
            loadingPage.Text = "LoadingPage";
            loadingPage.UseVisualStyleBackColor = true;
            // 
            // infoPage
            // 
            infoPage.Location = new Point(4, 24);
            infoPage.Name = "infoPage";
            infoPage.Padding = new Padding(3);
            infoPage.Size = new Size(1148, 608);
            infoPage.TabIndex = 3;
            infoPage.Text = "InfoPage";
            infoPage.UseVisualStyleBackColor = true;
            // 
            // auctionPurchasePage
            // 
            auctionPurchasePage.Location = new Point(4, 24);
            auctionPurchasePage.Name = "auctionPurchasePage";
            auctionPurchasePage.Padding = new Padding(3);
            auctionPurchasePage.Size = new Size(1148, 608);
            auctionPurchasePage.TabIndex = 4;
            auctionPurchasePage.Text = "AucPurchPage";
            auctionPurchasePage.UseVisualStyleBackColor = true;
            // 
            // aucRepPage
            // 
            aucRepPage.Location = new Point(4, 24);
            aucRepPage.Name = "aucRepPage";
            aucRepPage.Padding = new Padding(3);
            aucRepPage.Size = new Size(1148, 608);
            aucRepPage.TabIndex = 5;
            aucRepPage.Text = "AucRepPage";
            aucRepPage.UseVisualStyleBackColor = true;
            // 
            // aucSalePage
            // 
            aucSalePage.Location = new Point(4, 24);
            aucSalePage.Name = "aucSalePage";
            aucSalePage.Padding = new Padding(3);
            aucSalePage.Size = new Size(1148, 608);
            aucSalePage.TabIndex = 6;
            aucSalePage.Text = "AucSalePage";
            aucSalePage.UseVisualStyleBackColor = true;
            // 
            // leaderboardPage
            // 
            leaderboardPage.Location = new Point(4, 24);
            leaderboardPage.Name = "leaderboardPage";
            leaderboardPage.Padding = new Padding(3);
            leaderboardPage.Size = new Size(1148, 608);
            leaderboardPage.TabIndex = 7;
            leaderboardPage.Text = "LeaderboardPage";
            leaderboardPage.UseVisualStyleBackColor = true;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(36, 23);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(79, 15);
            LabelName.TabIndex = 1;
            LabelName.Text = "Vehicle Name";
            // 
            // Game
            // 
            ClientSize = new Size(1154, 635);
            Controls.Add(auctionTabs);
            Name = "Game";
            auctionTabs.ResumeLayout(false);
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            // 
            // button1
            // 

        }

        #endregion

        private TabControl auctionTabs;
        private TabPage mainMenu;
        private TabPage tutorialPage;
        private TabPage loadingPage;
        private TabPage infoPage;
        private TabPage auctionPurchasePage;
        private TabPage aucRepPage;
        private TabPage aucSalePage;
        private TabPage leaderboardPage;
        private Button button1;
        private Label LabelName;
    }
}
