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
            playButton = new Button();
            tutorialPage = new TabPage();
            loadingPage = new TabPage();
            auctionPurchasePage = new TabPage();
            aucRepPage = new TabPage();
            aucSalePage = new TabPage();
            leaderboardPage = new TabPage();
            tutorialButton = new Button();
            exitOpenPage = new Button();
            auctionFront = new Label();
            backButtonTutorial = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            auctionTabs.SuspendLayout();
            mainMenu.SuspendLayout();
            tutorialPage.SuspendLayout();
            auctionPurchasePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // auctionTabs
            // 
            auctionTabs.Controls.Add(mainMenu);
            auctionTabs.Controls.Add(tutorialPage);
            auctionTabs.Controls.Add(loadingPage);
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
            mainMenu.Controls.Add(auctionFront);
            mainMenu.Controls.Add(exitOpenPage);
            mainMenu.Controls.Add(tutorialButton);
            mainMenu.Controls.Add(playButton);
            mainMenu.Location = new Point(4, 24);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(3);
            mainMenu.Size = new Size(1148, 608);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "MainMenu";
            mainMenu.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            playButton.Location = new Point(383, 159);
            playButton.Name = "playButton";
            playButton.Size = new Size(382, 105);
            playButton.TabIndex = 0;
            playButton.Text = "PLAY";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += button1_Click_1;
            // 
            // tutorialPage
            // 
            tutorialPage.Controls.Add(backButtonTutorial);
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
            // auctionPurchasePage
            // 
            auctionPurchasePage.Controls.Add(numericUpDown1);
            auctionPurchasePage.Controls.Add(button1);
            auctionPurchasePage.Controls.Add(listBox1);
            auctionPurchasePage.Controls.Add(pictureBox1);
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
            // tutorialButton
            // 
            tutorialButton.Location = new Point(383, 270);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(382, 105);
            tutorialButton.TabIndex = 1;
            tutorialButton.Text = "TUTORIAL";
            tutorialButton.UseVisualStyleBackColor = true;
            // 
            // exitOpenPage
            // 
            exitOpenPage.Location = new Point(383, 381);
            exitOpenPage.Name = "exitOpenPage";
            exitOpenPage.Size = new Size(382, 105);
            exitOpenPage.TabIndex = 2;
            exitOpenPage.Text = "EXIT";
            exitOpenPage.UseVisualStyleBackColor = true;
            // 
            // auctionFront
            // 
            auctionFront.AutoSize = true;
            auctionFront.Font = new Font("Stencil", 40F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            auctionFront.Location = new Point(383, 89);
            auctionFront.Name = "auctionFront";
            auctionFront.Size = new Size(382, 64);
            auctionFront.TabIndex = 3;
            auctionFront.Text = "The Auction";
            // 
            // backButtonTutorial
            // 
            backButtonTutorial.Location = new Point(889, 517);
            backButtonTutorial.Name = "backButtonTutorial";
            backButtonTutorial.Size = new Size(250, 82);
            backButtonTutorial.TabIndex = 0;
            backButtonTutorial.Text = "BACK";
            backButtonTutorial.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(302, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 349);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 349);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(6, 361);
            button1.Name = "button1";
            button1.Size = new Size(290, 96);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(635, 447);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(338, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // Game
            // 
            ClientSize = new Size(1154, 635);
            Controls.Add(auctionTabs);
            Name = "Game";
            auctionTabs.ResumeLayout(false);
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            tutorialPage.ResumeLayout(false);
            auctionPurchasePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TabPage auctionPurchasePage;
        private TabPage aucRepPage;
        private TabPage aucSalePage;
        private TabPage leaderboardPage;
        private Button playButton;
        private Label auctionFront;
        private Button exitOpenPage;
        private Button tutorialButton;
        private Button backButtonTutorial;
        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
    }
}
