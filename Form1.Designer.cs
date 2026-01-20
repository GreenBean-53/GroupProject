namespace GroupProject
{
    partial class Form1
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
            this.auctionTabs = new TabControl();
            this.mainMenu = new TabPage();
            tutorialPage = new TabPage();
            gameMenu = new TabPage();
            auctionPage = new TabPage();
            repairPage = new TabPage();
            finalPage = new TabPage();
            playButton = new Button();
            titleCard = new Label();
            tutorialButton = new Button();
            exitButton = new Button();
            exitButtonFP = new Button();
            exitButtonGM = new Button();
            exitButtonTP = new Button();
            this.auctionTabs.SuspendLayout();
            this.mainMenu.SuspendLayout();
            tutorialPage.SuspendLayout();
            gameMenu.SuspendLayout();
            finalPage.SuspendLayout();
            SuspendLayout();
            // 
            // auctionTabs
            // 
            this.auctionTabs.AccessibleName = "";
            this.auctionTabs.Controls.Add(this.mainMenu);
            this.auctionTabs.Controls.Add(tutorialPage);
            this.auctionTabs.Controls.Add(gameMenu);
            this.auctionTabs.Controls.Add(auctionPage);
            this.auctionTabs.Controls.Add(repairPage);
            this.auctionTabs.Controls.Add(finalPage);
            this.auctionTabs.Location = new Point(0, -1);
            this.auctionTabs.Name = "auctionTabs";
            this.auctionTabs.SelectedIndex = 0;
            this.auctionTabs.Size = new Size(807, 458);
            this.auctionTabs.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(exitButton);
            this.mainMenu.Controls.Add(tutorialButton);
            this.mainMenu.Controls.Add(titleCard);
            this.mainMenu.Controls.Add(playButton);
            this.mainMenu.Location = new Point(4, 24);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new Padding(3);
            this.mainMenu.Size = new Size(799, 430);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main_Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += this.tabPage1_Click;
            // 
            // tutorialPage
            // 
            tutorialPage.Controls.Add(exitButtonTP);
            tutorialPage.Location = new Point(4, 24);
            tutorialPage.Name = "tutorialPage";
            tutorialPage.Padding = new Padding(3);
            tutorialPage.Size = new Size(799, 430);
            tutorialPage.TabIndex = 1;
            tutorialPage.Text = "Tutorial_Page";
            tutorialPage.UseVisualStyleBackColor = true;
            tutorialPage.Click += tutorialPage_Click;
            // 
            // gameMenu
            // 
            gameMenu.Controls.Add(exitButtonGM);
            gameMenu.Location = new Point(4, 24);
            gameMenu.Name = "gameMenu";
            gameMenu.Padding = new Padding(3);
            gameMenu.Size = new Size(799, 430);
            gameMenu.TabIndex = 2;
            gameMenu.Text = "Game_Menu";
            gameMenu.UseVisualStyleBackColor = true;
            // 
            // auctionPage
            // 
            auctionPage.Location = new Point(4, 24);
            auctionPage.Name = "auctionPage";
            auctionPage.Padding = new Padding(3);
            auctionPage.Size = new Size(799, 430);
            auctionPage.TabIndex = 3;
            auctionPage.Text = "Auction_Page";
            auctionPage.UseVisualStyleBackColor = true;
            // 
            // repairPage
            // 
            repairPage.Location = new Point(4, 24);
            repairPage.Name = "repairPage";
            repairPage.Padding = new Padding(3);
            repairPage.Size = new Size(799, 430);
            repairPage.TabIndex = 4;
            repairPage.Text = "Repair_Page";
            repairPage.UseVisualStyleBackColor = true;
            // 
            // finalPage
            // 
            finalPage.Controls.Add(exitButtonFP);
            finalPage.Location = new Point(4, 24);
            finalPage.Name = "finalPage";
            finalPage.Padding = new Padding(3);
            finalPage.Size = new Size(799, 430);
            finalPage.TabIndex = 5;
            finalPage.Text = "Final_Page";
            finalPage.UseVisualStyleBackColor = true;
            finalPage.Click += finalPage_Click;
            // 
            // playButton
            // 
            playButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            playButton.Location = new Point(275, 101);
            playButton.Name = "playButton";
            playButton.Size = new Size(249, 93);
            playButton.TabIndex = 0;
            playButton.Text = "PLAY";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // titleCard
            // 
            titleCard.AutoSize = true;
            titleCard.Font = new Font("Segoe UI", 40F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            titleCard.Location = new Point(204, 26);
            titleCard.Name = "titleCard";
            titleCard.Size = new Size(391, 72);
            titleCard.TabIndex = 1;
            titleCard.Text = "THE AUCTION";
            // 
            // tutorialButton
            // 
            tutorialButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            tutorialButton.Location = new Point(275, 200);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(249, 93);
            tutorialButton.TabIndex = 2;
            tutorialButton.Text = "TUTORIAL";
            tutorialButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            exitButton.Location = new Point(275, 299);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(249, 93);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // exitButtonFP
            // 
            exitButtonFP.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            exitButtonFP.Location = new Point(670, 6);
            exitButtonFP.Name = "exitButtonFP";
            exitButtonFP.Size = new Size(123, 44);
            exitButtonFP.TabIndex = 4;
            exitButtonFP.Text = "EXIT";
            exitButtonFP.UseVisualStyleBackColor = true;
            // 
            // exitButtonGM
            // 
            exitButtonGM.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            exitButtonGM.Location = new Point(670, 6);
            exitButtonGM.Name = "exitButtonGM";
            exitButtonGM.Size = new Size(123, 44);
            exitButtonGM.TabIndex = 5;
            exitButtonGM.Text = "EXIT";
            exitButtonGM.UseVisualStyleBackColor = true;
            // 
            // exitButtonTP
            // 
            exitButtonTP.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            exitButtonTP.Location = new Point(670, 6);
            exitButtonTP.Name = "exitButtonTP";
            exitButtonTP.Size = new Size(123, 44);
            exitButtonTP.TabIndex = 5;
            exitButtonTP.Text = "EXIT";
            exitButtonTP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(this.auctionTabs);
            Name = "Form1";
            Text = "THE AUCTION";
            Load += Form1_Load;
            this.auctionTabs.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            tutorialPage.ResumeLayout(false);
            gameMenu.ResumeLayout(false);
            finalPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tutorialPage;
        private TabPage gameMenu;
        private TabPage auctionPage;
        private TabPage repairPage;
        private TabPage finalPage;
        private Button playButton;
        private Button exitButton;
        private Button tutorialButton;
        private Label titleCard;
        private Button exitButtonFP;
        private Button exitButtonTP;
        private Button exitButtonGM;
        private TabControl auctionTabs;
        private TabPage mainMenu;
    }
}
