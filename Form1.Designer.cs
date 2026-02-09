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
            listBoxPositives = new ListBox();
            listBoxIssues = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonRefresh = new Button();
            startButton = new Button();
            vehcileTitle = new TextBox();
            playerData = new RichTextBox();
            vehcileData = new ListBox();
            numericUpDownBid = new NumericUpDown();
            skipBidButton = new Button();
            currentMoney = new TextBox();
            timeLimit = new ProgressBar();
            raisePriceButton = new Button();
            tutExitButton = new Button();
            listBoxPriceHistory = new ListBox();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownBid).BeginInit();
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
            aucPurPage.Controls.Add(listBoxPositives);
            aucPurPage.Controls.Add(listBoxIssues);
            aucPurPage.Controls.Add(label3);
            aucPurPage.Controls.Add(label2);
            aucPurPage.Controls.Add(label1);
            aucPurPage.Controls.Add(buttonRefresh);
            aucPurPage.Controls.Add(startButton);
            aucPurPage.Controls.Add(vehcileTitle);
            aucPurPage.Controls.Add(playerData);
            aucPurPage.Controls.Add(vehcileData);
            aucPurPage.Controls.Add(numericUpDownBid);
            aucPurPage.Controls.Add(skipBidButton);
            aucPurPage.Controls.Add(currentMoney);
            aucPurPage.Controls.Add(timeLimit);
            aucPurPage.Controls.Add(raisePriceButton);
            aucPurPage.Controls.Add(tutExitButton);
            aucPurPage.Controls.Add(listBoxPriceHistory);
            aucPurPage.Controls.Add(vehcilePictureBox);
            aucPurPage.Location = new Point(4, 24);
            aucPurPage.Name = "aucPurPage";
            aucPurPage.Padding = new Padding(3);
            aucPurPage.Size = new Size(1148, 608);
            aucPurPage.TabIndex = 4;
            aucPurPage.Text = "AucPurchPage";
            aucPurPage.UseVisualStyleBackColor = true;
            // 
            // listBoxPositives
            // 
            listBoxPositives.FormattingEnabled = true;
            listBoxPositives.Location = new Point(579, 389);
            listBoxPositives.Name = "listBoxPositives";
            listBoxPositives.Size = new Size(264, 199);
            listBoxPositives.TabIndex = 21;
            // 
            // listBoxIssues
            // 
            listBoxIssues.FormattingEnabled = true;
            listBoxIssues.Location = new Point(302, 389);
            listBoxIssues.Name = "listBoxIssues";
            listBoxIssues.Size = new Size(264, 199);
            listBoxIssues.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(579, 364);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 19;
            label3.Text = "Positives";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 41);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 18;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 364);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 17;
            label1.Text = "Issues";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(150, 506);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(146, 96);
            buttonRefresh.TabIndex = 16;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Stencil", 40F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            startButton.Location = new Point(383, 138);
            startButton.Name = "startButton";
            startButton.Size = new Size(386, 190);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // vehcileTitle
            // 
            vehcileTitle.Location = new Point(377, 41);
            vehcileTitle.Name = "vehcileTitle";
            vehcileTitle.Size = new Size(466, 23);
            vehcileTitle.TabIndex = 15;
            vehcileTitle.TextChanged += vehcileTitle_TextChanged;
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
            vehcileData.Location = new Point(6, 33);
            vehcileData.Name = "vehcileData";
            vehcileData.Size = new Size(290, 319);
            vehcileData.TabIndex = 13;
            // 
            // numericUpDownBid
            // 
            numericUpDownBid.Location = new Point(855, 460);
            numericUpDownBid.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownBid.Name = "numericUpDownBid";
            numericUpDownBid.Size = new Size(290, 23);
            numericUpDownBid.TabIndex = 8;
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
            raisePriceButton.Click += raisePriceButton_Click;
            // 
            // tutExitButton
            // 
            tutExitButton.Location = new Point(6, 506);
            tutExitButton.Name = "tutExitButton";
            tutExitButton.Size = new Size(138, 96);
            tutExitButton.TabIndex = 2;
            tutExitButton.Text = "Tutorial / EXIT";
            tutExitButton.UseVisualStyleBackColor = true;
            tutExitButton.Click += button1_Click_2;
            // 
            // listBoxPriceHistory
            // 
            listBoxPriceHistory.FormattingEnabled = true;
            listBoxPriceHistory.Location = new Point(855, 66);
            listBoxPriceHistory.Name = "listBoxPriceHistory";
            listBoxPriceHistory.Size = new Size(290, 274);
            listBoxPriceHistory.TabIndex = 1;
            listBoxPriceHistory.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // vehcilePictureBox
            // 
            vehcilePictureBox.Location = new Point(302, 35);
            vehcilePictureBox.Name = "vehcilePictureBox";
            vehcilePictureBox.Size = new Size(547, 320);
            vehcilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownBid).EndInit();
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
        private NumericUpDown numericUpDownBid;
        private Button skipBidButton;
        private TextBox currentMoney;
        private ProgressBar timeLimit;
        private Button raisePriceButton;
        private Button tutExitButton;
        private ListBox listBoxPriceHistory;
        private PictureBox vehcilePictureBox;
        private RichTextBox playerData;
        private ListBox vehcileData;
        private TextBox vehcileTitle;
        private PictureBox loadingImage;
        private ProgressBar loadingBar;
        private Button tutorialBackButton;
        private Button startButton;
        private Button buttonRefresh;
        private Label label1;
        private Label label2;
        private ListBox listBoxPositives;
        private ListBox listBoxIssues;
        private Label label3;
    }
}
