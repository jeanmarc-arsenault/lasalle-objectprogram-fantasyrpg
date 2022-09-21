namespace Project_RPG_JMA
{
    partial class Main_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Game));
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.btnExplore = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShield = new System.Windows.Forms.Button();
            this.btnDust = new System.Windows.Forms.Button();
            this.btnPotion = new System.Windows.Forms.Button();
            this.btnCloak = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblHealthMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMontserHP = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblShield = new System.Windows.Forms.Label();
            this.lblCloak = new System.Windows.Forms.Label();
            this.lblPotion = new System.Windows.Forms.Label();
            this.lblDust = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMainName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnBuySheild = new System.Windows.Forms.Button();
            this.btnBuyDust = new System.Windows.Forms.Button();
            this.btnBuyPotion = new System.Windows.Forms.Button();
            this.btnBuyCloak = new System.Windows.Forms.Button();
            this.btnBuyRock = new System.Windows.Forms.Button();
            this.btnBuyTorch = new System.Windows.Forms.Button();
            this.btnBuySword = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPlayerDam = new System.Windows.Forms.Label();
            this.lblMonsterDam = new System.Windows.Forms.Label();
            this.lbFirstline = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxMessages.Font = new System.Drawing.Font("Charlemagne Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxMessages.ForeColor = System.Drawing.Color.Gray;
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 15;
            this.listBoxMessages.Location = new System.Drawing.Point(2, 501);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(999, 154);
            this.listBoxMessages.TabIndex = 0;
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExplore.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExplore.FlatAppearance.BorderSize = 10;
            this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExplore.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExplore.Location = new System.Drawing.Point(87, 346);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(191, 46);
            this.btnExplore.TabIndex = 1;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHealth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHealth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHealth.ForeColor = System.Drawing.Color.Red;
            this.lblHealth.Location = new System.Drawing.Point(800, 98);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(64, 34);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(817, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health Points";
            // 
            // btnShield
            // 
            this.btnShield.Enabled = false;
            this.btnShield.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShield.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShield.Image = global::Project_RPG_JMA.Properties.Resources.sheild;
            this.btnShield.Location = new System.Drawing.Point(437, 328);
            this.btnShield.Name = "btnShield";
            this.btnShield.Size = new System.Drawing.Size(56, 67);
            this.btnShield.TabIndex = 4;
            this.btnShield.Text = "Sheild";
            this.btnShield.UseVisualStyleBackColor = true;
            this.btnShield.Click += new System.EventHandler(this.btnShield_Click);
            // 
            // btnDust
            // 
            this.btnDust.Enabled = false;
            this.btnDust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDust.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDust.Image = global::Project_RPG_JMA.Properties.Resources.dust;
            this.btnDust.Location = new System.Drawing.Point(51, 52);
            this.btnDust.Name = "btnDust";
            this.btnDust.Size = new System.Drawing.Size(63, 51);
            this.btnDust.TabIndex = 5;
            this.btnDust.Text = "Fairy Dust";
            this.btnDust.UseVisualStyleBackColor = true;
            this.btnDust.Click += new System.EventHandler(this.btnDust_Click);
            // 
            // btnPotion
            // 
            this.btnPotion.Enabled = false;
            this.btnPotion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPotion.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnPotion.Image = global::Project_RPG_JMA.Properties.Resources.potion;
            this.btnPotion.Location = new System.Drawing.Point(51, 113);
            this.btnPotion.Name = "btnPotion";
            this.btnPotion.Size = new System.Drawing.Size(63, 60);
            this.btnPotion.TabIndex = 6;
            this.btnPotion.Text = "Potion";
            this.btnPotion.UseVisualStyleBackColor = true;
            this.btnPotion.Click += new System.EventHandler(this.btnPotion_Click);
            // 
            // btnCloak
            // 
            this.btnCloak.Enabled = false;
            this.btnCloak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloak.ForeColor = System.Drawing.Color.Red;
            this.btnCloak.Image = global::Project_RPG_JMA.Properties.Resources.cloak;
            this.btnCloak.Location = new System.Drawing.Point(51, 195);
            this.btnCloak.Name = "btnCloak";
            this.btnCloak.Size = new System.Drawing.Size(66, 69);
            this.btnCloak.TabIndex = 7;
            this.btnCloak.Text = "Stealth Cloak";
            this.btnCloak.UseVisualStyleBackColor = true;
            this.btnCloak.Click += new System.EventHandler(this.btnCloak_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Enabled = false;
            this.btnAttack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttack.ForeColor = System.Drawing.Color.Red;
            this.btnAttack.Image = global::Project_RPG_JMA.Properties.Resources.stick;
            this.btnAttack.Location = new System.Drawing.Point(597, 325);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(116, 71);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Attack";
            this.btnAttack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblHealthMax
            // 
            this.lblHealthMax.AutoSize = true;
            this.lblHealthMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHealthMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHealthMax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHealthMax.ForeColor = System.Drawing.Color.Black;
            this.lblHealthMax.Location = new System.Drawing.Point(911, 98);
            this.lblHealthMax.Name = "lblHealthMax";
            this.lblHealthMax.Size = new System.Drawing.Size(64, 34);
            this.lblHealthMax.TabIndex = 9;
            this.lblHealthMax.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(870, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "of";
            // 
            // pbMontserHP
            // 
            this.pbMontserHP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbMontserHP.ForeColor = System.Drawing.Color.Red;
            this.pbMontserHP.Location = new System.Drawing.Point(437, 37);
            this.pbMontserHP.MarqueeAnimationSpeed = 120;
            this.pbMontserHP.Maximum = 120;
            this.pbMontserHP.Name = "pbMontserHP";
            this.pbMontserHP.Size = new System.Drawing.Size(256, 23);
            this.pbMontserHP.Step = 1;
            this.pbMontserHP.TabIndex = 11;
            this.pbMontserHP.Value = 100;
            this.pbMontserHP.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Powers";
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.AutoSize = true;
            this.lblMonsterName.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterName.Location = new System.Drawing.Point(526, 9);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(0, 25);
            this.lblMonsterName.TabIndex = 13;
            this.lblMonsterName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(813, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Experience Points: ";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblXP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblXP.ForeColor = System.Drawing.Color.Black;
            this.lblXP.Location = new System.Drawing.Point(971, 324);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(24, 26);
            this.lblXP.TabIndex = 15;
            this.lblXP.Text = "0";
            // 
            // lblShield
            // 
            this.lblShield.AutoSize = true;
            this.lblShield.Location = new System.Drawing.Point(418, 357);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(13, 15);
            this.lblShield.TabIndex = 16;
            this.lblShield.Text = "0";
            // 
            // lblCloak
            // 
            this.lblCloak.AutoSize = true;
            this.lblCloak.Location = new System.Drawing.Point(32, 238);
            this.lblCloak.Name = "lblCloak";
            this.lblCloak.Size = new System.Drawing.Size(13, 15);
            this.lblCloak.TabIndex = 17;
            this.lblCloak.Text = "0";
            // 
            // lblPotion
            // 
            this.lblPotion.AutoSize = true;
            this.lblPotion.Location = new System.Drawing.Point(32, 153);
            this.lblPotion.Name = "lblPotion";
            this.lblPotion.Size = new System.Drawing.Size(13, 15);
            this.lblPotion.TabIndex = 18;
            this.lblPotion.Text = "0";
            // 
            // lblDust
            // 
            this.lblDust.AutoSize = true;
            this.lblDust.Location = new System.Drawing.Point(39, 88);
            this.lblDust.Name = "lblDust";
            this.lblDust.Size = new System.Drawing.Size(13, 15);
            this.lblDust.TabIndex = 19;
            this.lblDust.Text = "0";
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeapon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWeapon.Location = new System.Drawing.Point(719, 350);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(95, 21);
            this.lblWeapon.TabIndex = 20;
            this.lblWeapon.Text = "Wood Stick";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(817, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gold:";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGold.ForeColor = System.Drawing.Color.Gold;
            this.lblGold.Location = new System.Drawing.Point(881, 355);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(23, 24);
            this.lblGold.TabIndex = 23;
            this.lblGold.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(822, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Level :";
            // 
            // lblMainName
            // 
            this.lblMainName.AutoSize = true;
            this.lblMainName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainName.Location = new System.Drawing.Point(833, 0);
            this.lblMainName.Name = "lblMainName";
            this.lblMainName.Size = new System.Drawing.Size(83, 34);
            this.lblMainName.TabIndex = 25;
            this.lblMainName.Text = "name";
            this.lblMainName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLevel.Location = new System.Drawing.Point(890, 34);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(22, 24);
            this.lblLevel.TabIndex = 26;
            this.lblLevel.Text = "1";
            // 
            // btnBuySheild
            // 
            this.btnBuySheild.Location = new System.Drawing.Point(150, 19);
            this.btnBuySheild.Name = "btnBuySheild";
            this.btnBuySheild.Size = new System.Drawing.Size(142, 22);
            this.btnBuySheild.TabIndex = 27;
            this.btnBuySheild.Text = "Buy a sheild: 100gp";
            this.btnBuySheild.UseVisualStyleBackColor = true;
            this.btnBuySheild.Visible = false;
            this.btnBuySheild.Click += new System.EventHandler(this.btnBuySheild_Click);
            // 
            // btnBuyDust
            // 
            this.btnBuyDust.Location = new System.Drawing.Point(150, 53);
            this.btnBuyDust.Name = "btnBuyDust";
            this.btnBuyDust.Size = new System.Drawing.Size(142, 22);
            this.btnBuyDust.TabIndex = 28;
            this.btnBuyDust.Text = "Buy a Fairy Dust: 600gp";
            this.btnBuyDust.UseVisualStyleBackColor = true;
            this.btnBuyDust.Visible = false;
            this.btnBuyDust.Click += new System.EventHandler(this.btnBuyDust_Click);
            // 
            // btnBuyPotion
            // 
            this.btnBuyPotion.Location = new System.Drawing.Point(150, 91);
            this.btnBuyPotion.Name = "btnBuyPotion";
            this.btnBuyPotion.Size = new System.Drawing.Size(142, 22);
            this.btnBuyPotion.TabIndex = 29;
            this.btnBuyPotion.Text = "Buy a Potion: 200gp";
            this.btnBuyPotion.UseVisualStyleBackColor = true;
            this.btnBuyPotion.Visible = false;
            this.btnBuyPotion.Click += new System.EventHandler(this.btnBuyPotion_Click);
            // 
            // btnBuyCloak
            // 
            this.btnBuyCloak.Location = new System.Drawing.Point(150, 126);
            this.btnBuyCloak.Name = "btnBuyCloak";
            this.btnBuyCloak.Size = new System.Drawing.Size(142, 22);
            this.btnBuyCloak.TabIndex = 30;
            this.btnBuyCloak.Text = "Buy a Cloak: 300gp";
            this.btnBuyCloak.UseVisualStyleBackColor = true;
            this.btnBuyCloak.Visible = false;
            this.btnBuyCloak.Click += new System.EventHandler(this.btnBuyCloak_Click);
            // 
            // btnBuyRock
            // 
            this.btnBuyRock.Location = new System.Drawing.Point(150, 158);
            this.btnBuyRock.Name = "btnBuyRock";
            this.btnBuyRock.Size = new System.Drawing.Size(142, 22);
            this.btnBuyRock.TabIndex = 31;
            this.btnBuyRock.Text = "Buy a Rock: 100gp";
            this.btnBuyRock.UseVisualStyleBackColor = true;
            this.btnBuyRock.Visible = false;
            this.btnBuyRock.Click += new System.EventHandler(this.btnBuyRock_Click);
            // 
            // btnBuyTorch
            // 
            this.btnBuyTorch.Location = new System.Drawing.Point(150, 195);
            this.btnBuyTorch.Name = "btnBuyTorch";
            this.btnBuyTorch.Size = new System.Drawing.Size(142, 22);
            this.btnBuyTorch.TabIndex = 32;
            this.btnBuyTorch.Text = "Buy a Torch: 300gp";
            this.btnBuyTorch.UseVisualStyleBackColor = true;
            this.btnBuyTorch.Visible = false;
            this.btnBuyTorch.Click += new System.EventHandler(this.btnBuyTorch_Click);
            // 
            // btnBuySword
            // 
            this.btnBuySword.Location = new System.Drawing.Point(150, 231);
            this.btnBuySword.Name = "btnBuySword";
            this.btnBuySword.Size = new System.Drawing.Size(142, 22);
            this.btnBuySword.TabIndex = 33;
            this.btnBuySword.Text = "Buy a Sword: 500gp";
            this.btnBuySword.UseVisualStyleBackColor = true;
            this.btnBuySword.Visible = false;
            this.btnBuySword.Click += new System.EventHandler(this.btnBuySword_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeave.Location = new System.Drawing.Point(150, 270);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(157, 37);
            this.btnLeave.TabIndex = 34;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Visible = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.Transparent;
            this.pbMain.BackgroundImage = global::Project_RPG_JMA.Properties.Resources.forest;
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMain.Location = new System.Drawing.Point(437, 63);
            this.pbMain.MaximumSize = new System.Drawing.Size(256, 256);
            this.pbMain.MinimumSize = new System.Drawing.Size(256, 256);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(256, 256);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMain.TabIndex = 35;
            this.pbMain.TabStop = false;
            this.pbMain.WaitOnLoad = true;
            this.pbMain.BackgroundImageChanged += new System.EventHandler(this.pbMain_BackgroundImageChanged);
            // 
            // ilImages
            // 
            this.ilImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "cloak.jpg");
            this.ilImages.Images.SetKeyName(1, "dragon.jpg");
            this.ilImages.Images.SetKeyName(2, "dust.jpg");
            this.ilImages.Images.SetKeyName(3, "forest.jpg");
            this.ilImages.Images.SetKeyName(4, "goblin.jpg");
            this.ilImages.Images.SetKeyName(5, "gold.jpg");
            this.ilImages.Images.SetKeyName(6, "ogre.jpg");
            this.ilImages.Images.SetKeyName(7, "potion.jpg");
            this.ilImages.Images.SetKeyName(8, "rock.jpg");
            this.ilImages.Images.SetKeyName(9, "sheild.jpg");
            this.ilImages.Images.SetKeyName(10, "stick.jpg");
            this.ilImages.Images.SetKeyName(11, "sword.jpg");
            this.ilImages.Images.SetKeyName(12, "torch.jpg");
            this.ilImages.Images.SetKeyName(13, "wizard.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_RPG_JMA.Properties.Resources.hero;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(822, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 179);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lbPlayerDam
            // 
            this.lbPlayerDam.AutoSize = true;
            this.lbPlayerDam.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerDam.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPlayerDam.ForeColor = System.Drawing.Color.Red;
            this.lbPlayerDam.Location = new System.Drawing.Point(833, 207);
            this.lbPlayerDam.Name = "lbPlayerDam";
            this.lbPlayerDam.Size = new System.Drawing.Size(0, 35);
            this.lbPlayerDam.TabIndex = 37;
            this.lbPlayerDam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonsterDam
            // 
            this.lblMonsterDam.AutoSize = true;
            this.lblMonsterDam.BackColor = System.Drawing.Color.Transparent;
            this.lblMonsterDam.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterDam.ForeColor = System.Drawing.Color.Red;
            this.lblMonsterDam.Location = new System.Drawing.Point(509, 195);
            this.lblMonsterDam.Name = "lblMonsterDam";
            this.lblMonsterDam.Size = new System.Drawing.Size(0, 35);
            this.lblMonsterDam.TabIndex = 38;
            this.lblMonsterDam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFirstline
            // 
            this.lbFirstline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFirstline.Font = new System.Drawing.Font("Charlemagne Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFirstline.ForeColor = System.Drawing.Color.White;
            this.lbFirstline.FormattingEnabled = true;
            this.lbFirstline.ItemHeight = 25;
            this.lbFirstline.Location = new System.Drawing.Point(2, 439);
            this.lbFirstline.Name = "lbFirstline";
            this.lbFirstline.Size = new System.Drawing.Size(999, 29);
            this.lbFirstline.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Game log";
            // 
            // Main_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFirstline);
            this.Controls.Add(this.lblMonsterDam);
            this.Controls.Add(this.lbPlayerDam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnBuySword);
            this.Controls.Add(this.btnBuyTorch);
            this.Controls.Add(this.btnBuyRock);
            this.Controls.Add(this.btnBuyCloak);
            this.Controls.Add(this.btnBuyPotion);
            this.Controls.Add(this.btnBuyDust);
            this.Controls.Add(this.btnBuySheild);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblMainName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.lblDust);
            this.Controls.Add(this.lblPotion);
            this.Controls.Add(this.lblCloak);
            this.Controls.Add(this.lblShield);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMonsterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbMontserHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHealthMax);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnCloak);
            this.Controls.Add(this.btnPotion);
            this.Controls.Add(this.btnDust);
            this.Controls.Add(this.btnShield);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.listBoxMessages);
            this.Name = "Main_Game";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Main_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblHealth;
        public System.Windows.Forms.Label lblHealthMax;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExplore;
        public System.Windows.Forms.Button btnShield;
        public System.Windows.Forms.Button btnDust;
        public System.Windows.Forms.Button btnPotion;
        public System.Windows.Forms.Button btnCloak;
        public System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblXP;
        public System.Windows.Forms.Label lblShield;
        public System.Windows.Forms.Label lblCloak;
        public System.Windows.Forms.Label lblPotion;
        public System.Windows.Forms.Label lblDust;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblGold;
        public System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblLevel;
        public System.Windows.Forms.Label lblMainName;
        public System.Windows.Forms.ProgressBar pbMontserHP;
        public System.Windows.Forms.Button btnBuySheild;
        public System.Windows.Forms.Button btnBuyDust;
        public System.Windows.Forms.Button btnBuyPotion;
        public System.Windows.Forms.Button btnBuyCloak;
        public System.Windows.Forms.Button btnBuyRock;
        public System.Windows.Forms.Button btnBuyTorch;
        public System.Windows.Forms.Button btnBuySword;
        public System.Windows.Forms.Button btnLeave;
        public System.Windows.Forms.PictureBox pbMain;
        public System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbPlayerDam;
        public System.Windows.Forms.Label lblMonsterDam;
        public System.Windows.Forms.ListBox lbFirstline;
        private System.Windows.Forms.Label label6;
    }
}