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
            auctionFront = new Label();
            exitOpenPage = new Button();
            tutorialButton = new Button();
            playButton = new Button();
            tutorialPage = new TabPage();
            tutorialBackButton = new Button();
            loadingPage = new TabPage();
            loadingImage = new PictureBox();
            loadingBar = new ProgressBar();
            aucPurPage = new TabPage();
            vehcileTitle = new TextBox();
            playerData = new RichTextBox();
            vehcileData = new ListBox();
            positiveAttributes = new RichTextBox();
            negativeAttributes = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            skipBidButton = new Button();
            currentMoney = new TextBox();
            timeLimit = new ProgressBar();
            raisePriceButton = new Button();
            tutExitButton = new Button();
            priceHistory = new ListBox();
            vehcilePictureBox = new PictureBox();
            aucRepPage = new TabPage();
            aucSalePage = new TabPage();
            leaderboardPage = new TabPage();
            auctionTabs.SuspendLayout();
            mainMenu.SuspendLayout();
            tutorialPage.SuspendLayout();
            loadingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingImage).BeginInit();
            aucPurPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehcilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // auctionTabs
            // 
            auctionTabs.Controls.Add(mainMenu);
            auctionTabs.Controls.Add(tutorialPage);
            auctionTabs.Controls.Add(loadingPage);
            auctionTabs.Controls.Add(aucPurPage);
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
            // auctionFront
            // 
            auctionFront.AutoSize = true;
            auctionFront.Font = new Font("Stencil", 40F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            auctionFront.Location = new Point(383, 89);
            auctionFront.Name = "auctionFront";
            auctionFront.Size = new Size(382, 64);
            auctionFront.TabIndex = 3;
            auctionFront.Text = "The Auction";
            auctionFront.Click += auctionFront_Click;
            // 
            // exitOpenPage
            // 
            exitOpenPage.Location = new Point(383, 381);
            exitOpenPage.Name = "exitOpenPage";
            exitOpenPage.Size = new Size(382, 105);
            exitOpenPage.TabIndex = 2;
            exitOpenPage.Text = "EXIT";
            exitOpenPage.UseVisualStyleBackColor = true;
            exitOpenPage.Click += exitClick;
            // 
            // tutorialButton
            // 
            tutorialButton.Location = new Point(383, 270);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(382, 105);
            tutorialButton.TabIndex = 1;
            tutorialButton.Text = "TUTORIAL";
            tutorialButton.UseVisualStyleBackColor = true;
            tutorialButton.Click += tutorialClick;
            // 
            // playButton
            // 
            playButton.Location = new Point(383, 159);
            playButton.Name = "playButton";
            playButton.Size = new Size(382, 105);
            playButton.TabIndex = 0;
            playButton.Text = "PLAY";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += clickPlay;
            // 
            // tutorialPage
            // 
            tutorialPage.Controls.Add(tutorialBackButton);
            tutorialPage.Location = new Point(4, 24);
            tutorialPage.Name = "tutorialPage";
            tutorialPage.Padding = new Padding(3);
            tutorialPage.Size = new Size(1148, 608);
            tutorialPage.TabIndex = 1;
            tutorialPage.Text = "TutorialPage";
            tutorialPage.UseVisualStyleBackColor = true;
            // 
            // tutorialBackButton
            // 
            tutorialBackButton.Location = new Point(3, 509);
            tutorialBackButton.Name = "tutorialBackButton";
            tutorialBackButton.Size = new Size(290, 96);
            tutorialBackButton.TabIndex = 3;
            tutorialBackButton.Text = "Tutorial / EXIT";
            tutorialBackButton.UseVisualStyleBackColor = true;
            tutorialBackButton.Click += button1_Click_3;
            // 
            // loadingPage
            // 
            loadingPage.Controls.Add(loadingImage);
            loadingPage.Controls.Add(loadingBar);
            loadingPage.Location = new Point(4, 24);
            loadingPage.Name = "loadingPage";
            loadingPage.Padding = new Padding(3);
            loadingPage.Size = new Size(1148, 608);
            loadingPage.TabIndex = 2;
            loadingPage.Text = "LoadingPage";
            loadingPage.UseVisualStyleBackColor = true;
            // 
            // loadingImage
            // 
            loadingImage.Location = new Point(0, 0);
            loadingImage.Name = "loadingImage";
            loadingImage.Size = new Size(1142, 585);
            loadingImage.TabIndex = 1;
            loadingImage.TabStop = false;
            // 
            // loadingBar
            // 
            loadingBar.Location = new Point(0, 585);
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(1148, 23);
            loadingBar.TabIndex = 0;
            // 
            // aucPurPage
            // 
            aucPurPage.Controls.Add(vehcileTitle);
            aucPurPage.Controls.Add(playerData);
            aucPurPage.Controls.Add(vehcileData);
            aucPurPage.Controls.Add(positiveAttributes);
            aucPurPage.Controls.Add(negativeAttributes);
            aucPurPage.Controls.Add(numericUpDown1);
            aucPurPage.Controls.Add(skipBidButton);
            aucPurPage.Controls.Add(currentMoney);
            aucPurPage.Controls.Add(timeLimit);
            aucPurPage.Controls.Add(raisePriceButton);
            aucPurPage.Controls.Add(tutExitButton);
            aucPurPage.Controls.Add(priceHistory);
            aucPurPage.Controls.Add(vehcilePictureBox);
            aucPurPage.Location = new Point(4, 24);
            aucPurPage.Name = "aucPurPage";
            aucPurPage.Padding = new Padding(3);
            aucPurPage.Size = new Size(1148, 608);
            aucPurPage.TabIndex = 4;
            aucPurPage.Text = "AucPurchPage";
            aucPurPage.UseVisualStyleBackColor = true;
            // 
            // vehcileTitle
            // 
            vehcileTitle.Location = new Point(302, 6);
            vehcileTitle.Name = "vehcileTitle";
            vehcileTitle.Size = new Size(547, 23);
            vehcileTitle.TabIndex = 15;
            // 
            // playerData
            // 
            playerData.Location = new Point(6, 358);
            playerData.Name = "playerData";
            playerData.Size = new Size(290, 142);
            playerData.TabIndex = 14;
            playerData.Text = "";
            playerData.TextChanged += richTextBox3_TextChanged;
            // 
            // vehcileData
            // 
            vehcileData.FormattingEnabled = true;
            vehcileData.Location = new Point(6, 6);
            vehcileData.Name = "vehcileData";
            vehcileData.Size = new Size(290, 349);
            vehcileData.TabIndex = 13;
            // 
            // positiveAttributes
            // 
            positiveAttributes.Location = new Point(579, 358);
            positiveAttributes.Name = "positiveAttributes";
            positiveAttributes.Size = new Size(270, 244);
            positiveAttributes.TabIndex = 12;
            positiveAttributes.Text = "";
            // 
            // negativeAttributes
            // 
            negativeAttributes.Location = new Point(302, 358);
            negativeAttributes.Name = "negativeAttributes";
            negativeAttributes.Size = new Size(270, 244);
            negativeAttributes.TabIndex = 11;
            negativeAttributes.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(855, 460);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(290, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // skipBidButton
            // 
            skipBidButton.Location = new Point(855, 506);
            skipBidButton.Name = "skipBidButton";
            skipBidButton.Size = new Size(290, 96);
            skipBidButton.TabIndex = 7;
            skipBidButton.Text = "SKIP";
            skipBidButton.UseVisualStyleBackColor = true;
            // 
            // currentMoney
            // 
            currentMoney.Location = new Point(855, 35);
            currentMoney.Name = "currentMoney";
            currentMoney.Size = new Size(290, 23);
            currentMoney.TabIndex = 6;
            // 
            // timeLimit
            // 
            timeLimit.ForeColor = SystemColors.InactiveCaption;
            timeLimit.Location = new Point(855, 6);
            timeLimit.Name = "timeLimit";
            timeLimit.Size = new Size(290, 23);
            timeLimit.TabIndex = 5;
            // 
            // raisePriceButton
            // 
            raisePriceButton.Location = new Point(855, 358);
            raisePriceButton.Name = "raisePriceButton";
            raisePriceButton.Size = new Size(290, 96);
            raisePriceButton.TabIndex = 3;
            raisePriceButton.Text = "Raise";
            raisePriceButton.UseVisualStyleBackColor = true;
            // 
            // tutExitButton
            // 
            tutExitButton.Location = new Point(6, 506);
            tutExitButton.Name = "tutExitButton";
            tutExitButton.Size = new Size(290, 96);
            tutExitButton.TabIndex = 2;
            tutExitButton.Text = "Tutorial / EXIT";
            tutExitButton.UseVisualStyleBackColor = true;
            tutExitButton.Click += button1_Click_2;
            // 
            // priceHistory
            // 
            priceHistory.FormattingEnabled = true;
            priceHistory.Location = new Point(855, 66);
            priceHistory.Name = "priceHistory";
            priceHistory.Size = new Size(290, 289);
            priceHistory.TabIndex = 1;
            priceHistory.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // vehcilePictureBox
            // 
            vehcilePictureBox.Location = new Point(302, 35);
            vehcilePictureBox.Name = "vehcilePictureBox";
            vehcilePictureBox.Size = new Size(547, 320);
            vehcilePictureBox.TabIndex = 0;
            vehcilePictureBox.TabStop = false;
            vehcilePictureBox.Click += pictureBox1_Click;
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
            // Game
            // 
            ClientSize = new Size(1154, 635);
            Controls.Add(auctionTabs);
            Name = "Game";
            auctionTabs.ResumeLayout(false);
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            tutorialPage.ResumeLayout(false);
            loadingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loadingImage).EndInit();
            aucPurPage.ResumeLayout(false);
            aucPurPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehcilePictureBox).EndInit();
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
        private TabPage aucRepPage;
        private TabPage aucSalePage;
        private TabPage leaderboardPage;
        private Button playButton;
        private Label auctionFront;
        private Button exitOpenPage;
        private Button tutorialButton;
        private TabPage aucPurPage;
        private RichTextBox positiveAttributes;
        private RichTextBox negativeAttributes;
        private NumericUpDown numericUpDown1;
        private Button skipBidButton;
        private TextBox currentMoney;
        private ProgressBar timeLimit;
        private Button raisePriceButton;
        private Button tutExitButton;
        private ListBox priceHistory;
        private PictureBox vehcilePictureBox;
        private RichTextBox playerData;
        private ListBox vehcileData;
        private TextBox vehcileTitle;
        private PictureBox loadingImage;
        private ProgressBar loadingBar;
        private Button tutorialBackButton;
    }
}
