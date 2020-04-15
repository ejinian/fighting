namespace fighting
{
    partial class fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fight));
            this.progressBarHappiFac3 = new System.Windows.Forms.ProgressBar();
            this.progressBarXTerminator = new System.Windows.Forms.ProgressBar();
            this.fireHappiFac3 = new System.Windows.Forms.Button();
            this.healingHappiFac3 = new System.Windows.Forms.Button();
            this.reloadHappiFac3 = new System.Windows.Forms.Button();
            this.happiFac3Special = new System.Windows.Forms.Button();
            this.fireXTerminator = new System.Windows.Forms.Button();
            this.healingXTerminator = new System.Windows.Forms.Button();
            this.reloadXTerminator = new System.Windows.Forms.Button();
            this.XTerminatorSpecial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yourTurnLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.happiFac3StatusAmmo = new System.Windows.Forms.Label();
            this.XTermintorStatusAmmo = new System.Windows.Forms.Label();
            this.happiFac3StatusHeal = new System.Windows.Forms.Label();
            this.XTermintorStatusHeal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.happiHealthLabel = new System.Windows.Forms.Label();
            this.xHealthLabel = new System.Windows.Forms.Label();
            this.deathLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ticktock_left = new System.Windows.Forms.Label();
            this.ticktock_right = new System.Windows.Forms.Label();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.outoftime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarHappiFac3
            // 
            this.progressBarHappiFac3.Location = new System.Drawing.Point(12, 58);
            this.progressBarHappiFac3.Name = "progressBarHappiFac3";
            this.progressBarHappiFac3.Size = new System.Drawing.Size(143, 23);
            this.progressBarHappiFac3.TabIndex = 2;
            this.progressBarHappiFac3.Value = 100;
            // 
            // progressBarXTerminator
            // 
            this.progressBarXTerminator.BackColor = System.Drawing.Color.Red;
            this.progressBarXTerminator.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.progressBarXTerminator.Location = new System.Drawing.Point(567, 59);
            this.progressBarXTerminator.Name = "progressBarXTerminator";
            this.progressBarXTerminator.Size = new System.Drawing.Size(148, 23);
            this.progressBarXTerminator.TabIndex = 3;
            this.progressBarXTerminator.Value = 100;
            // 
            // fireHappiFac3
            // 
            this.fireHappiFac3.ForeColor = System.Drawing.Color.Red;
            this.fireHappiFac3.Location = new System.Drawing.Point(56, 183);
            this.fireHappiFac3.Name = "fireHappiFac3";
            this.fireHappiFac3.Size = new System.Drawing.Size(43, 20);
            this.fireHappiFac3.TabIndex = 4;
            this.fireHappiFac3.Text = "Fire!";
            this.fireHappiFac3.UseVisualStyleBackColor = true;
            this.fireHappiFac3.Click += new System.EventHandler(this.fireHappiFac3_Click);
            // 
            // healingHappiFac3
            // 
            this.healingHappiFac3.ForeColor = System.Drawing.Color.Orange;
            this.healingHappiFac3.Location = new System.Drawing.Point(56, 214);
            this.healingHappiFac3.Name = "healingHappiFac3";
            this.healingHappiFac3.Size = new System.Drawing.Size(43, 21);
            this.healingHappiFac3.TabIndex = 5;
            this.healingHappiFac3.Text = "Heal!";
            this.healingHappiFac3.UseVisualStyleBackColor = true;
            this.healingHappiFac3.Click += new System.EventHandler(this.healingHappiFac3_Click);
            // 
            // reloadHappiFac3
            // 
            this.reloadHappiFac3.ForeColor = System.Drawing.Color.Blue;
            this.reloadHappiFac3.Location = new System.Drawing.Point(56, 246);
            this.reloadHappiFac3.Name = "reloadHappiFac3";
            this.reloadHappiFac3.Size = new System.Drawing.Size(55, 23);
            this.reloadHappiFac3.TabIndex = 6;
            this.reloadHappiFac3.Text = "Reload!";
            this.reloadHappiFac3.UseVisualStyleBackColor = true;
            this.reloadHappiFac3.Click += new System.EventHandler(this.reloadHappiFac3_Click);
            // 
            // happiFac3Special
            // 
            this.happiFac3Special.ForeColor = System.Drawing.Color.Purple;
            this.happiFac3Special.Location = new System.Drawing.Point(56, 280);
            this.happiFac3Special.Name = "happiFac3Special";
            this.happiFac3Special.Size = new System.Drawing.Size(55, 23);
            this.happiFac3Special.TabIndex = 7;
            this.happiFac3Special.Text = "Special!";
            this.happiFac3Special.UseVisualStyleBackColor = true;
            this.happiFac3Special.Click += new System.EventHandler(this.happiFac3Special_Click);
            // 
            // fireXTerminator
            // 
            this.fireXTerminator.Enabled = false;
            this.fireXTerminator.ForeColor = System.Drawing.Color.Red;
            this.fireXTerminator.Location = new System.Drawing.Point(620, 183);
            this.fireXTerminator.Name = "fireXTerminator";
            this.fireXTerminator.Size = new System.Drawing.Size(43, 20);
            this.fireXTerminator.TabIndex = 8;
            this.fireXTerminator.Text = "Fire!";
            this.fireXTerminator.UseVisualStyleBackColor = true;
            this.fireXTerminator.Click += new System.EventHandler(this.fireXTerminator_Click);
            // 
            // healingXTerminator
            // 
            this.healingXTerminator.Enabled = false;
            this.healingXTerminator.ForeColor = System.Drawing.Color.Orange;
            this.healingXTerminator.Location = new System.Drawing.Point(620, 214);
            this.healingXTerminator.Name = "healingXTerminator";
            this.healingXTerminator.Size = new System.Drawing.Size(43, 21);
            this.healingXTerminator.TabIndex = 9;
            this.healingXTerminator.Text = "Heal!";
            this.healingXTerminator.UseVisualStyleBackColor = true;
            this.healingXTerminator.Click += new System.EventHandler(this.healingXTerminator_Click);
            // 
            // reloadXTerminator
            // 
            this.reloadXTerminator.Enabled = false;
            this.reloadXTerminator.ForeColor = System.Drawing.Color.Blue;
            this.reloadXTerminator.Location = new System.Drawing.Point(608, 246);
            this.reloadXTerminator.Name = "reloadXTerminator";
            this.reloadXTerminator.Size = new System.Drawing.Size(55, 23);
            this.reloadXTerminator.TabIndex = 10;
            this.reloadXTerminator.Text = "Reload!";
            this.reloadXTerminator.UseVisualStyleBackColor = true;
            this.reloadXTerminator.Click += new System.EventHandler(this.reloadXTerminator_Click);
            // 
            // XTerminatorSpecial
            // 
            this.XTerminatorSpecial.Enabled = false;
            this.XTerminatorSpecial.ForeColor = System.Drawing.Color.Purple;
            this.XTerminatorSpecial.Location = new System.Drawing.Point(608, 280);
            this.XTerminatorSpecial.Name = "XTerminatorSpecial";
            this.XTerminatorSpecial.Size = new System.Drawing.Size(55, 23);
            this.XTerminatorSpecial.TabIndex = 11;
            this.XTerminatorSpecial.Text = "Special!";
            this.XTerminatorSpecial.UseVisualStyleBackColor = true;
            this.XTerminatorSpecial.Click += new System.EventHandler(this.XTerminatorSpecial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doctor Salt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(585, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "X-Terminator";
            // 
            // yourTurnLabel
            // 
            this.yourTurnLabel.AutoSize = true;
            this.yourTurnLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourTurnLabel.ForeColor = System.Drawing.Color.Crimson;
            this.yourTurnLabel.Location = new System.Drawing.Point(184, 143);
            this.yourTurnLabel.Name = "yourTurnLabel";
            this.yourTurnLabel.Size = new System.Drawing.Size(0, 31);
            this.yourTurnLabel.TabIndex = 14;
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialLabel.ForeColor = System.Drawing.Color.Blue;
            this.specialLabel.Location = new System.Drawing.Point(221, 279);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(0, 18);
            this.specialLabel.TabIndex = 16;
            // 
            // happiFac3StatusAmmo
            // 
            this.happiFac3StatusAmmo.AutoSize = true;
            this.happiFac3StatusAmmo.BackColor = System.Drawing.Color.Transparent;
            this.happiFac3StatusAmmo.ForeColor = System.Drawing.Color.Black;
            this.happiFac3StatusAmmo.Location = new System.Drawing.Point(117, 187);
            this.happiFac3StatusAmmo.Name = "happiFac3StatusAmmo";
            this.happiFac3StatusAmmo.Size = new System.Drawing.Size(48, 13);
            this.happiFac3StatusAmmo.TabIndex = 17;
            this.happiFac3StatusAmmo.Text = "Ammo: 1";
            // 
            // XTermintorStatusAmmo
            // 
            this.XTermintorStatusAmmo.AutoSize = true;
            this.XTermintorStatusAmmo.BackColor = System.Drawing.Color.Transparent;
            this.XTermintorStatusAmmo.ForeColor = System.Drawing.Color.Black;
            this.XTermintorStatusAmmo.Location = new System.Drawing.Point(557, 188);
            this.XTermintorStatusAmmo.Name = "XTermintorStatusAmmo";
            this.XTermintorStatusAmmo.Size = new System.Drawing.Size(48, 13);
            this.XTermintorStatusAmmo.TabIndex = 18;
            this.XTermintorStatusAmmo.Text = "Ammo: 1";
            // 
            // happiFac3StatusHeal
            // 
            this.happiFac3StatusHeal.AutoSize = true;
            this.happiFac3StatusHeal.BackColor = System.Drawing.Color.Transparent;
            this.happiFac3StatusHeal.ForeColor = System.Drawing.Color.Black;
            this.happiFac3StatusHeal.Location = new System.Drawing.Point(117, 219);
            this.happiFac3StatusHeal.Name = "happiFac3StatusHeal";
            this.happiFac3StatusHeal.Size = new System.Drawing.Size(55, 13);
            this.happiFac3StatusHeal.TabIndex = 19;
            this.happiFac3StatusHeal.Text = "Healing: 4";
            // 
            // XTermintorStatusHeal
            // 
            this.XTermintorStatusHeal.AutoSize = true;
            this.XTermintorStatusHeal.BackColor = System.Drawing.Color.Transparent;
            this.XTermintorStatusHeal.ForeColor = System.Drawing.Color.Black;
            this.XTermintorStatusHeal.Location = new System.Drawing.Point(549, 219);
            this.XTermintorStatusHeal.Name = "XTermintorStatusHeal";
            this.XTermintorStatusHeal.Size = new System.Drawing.Size(55, 13);
            this.XTermintorStatusHeal.TabIndex = 20;
            this.XTermintorStatusHeal.Text = "Healing: 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Reload: Infinite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(527, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Reload: Infinite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(117, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "One Special";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(539, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "One Special";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(323, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 25;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // happiHealthLabel
            // 
            this.happiHealthLabel.AutoSize = true;
            this.happiHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.happiHealthLabel.ForeColor = System.Drawing.Color.Purple;
            this.happiHealthLabel.Location = new System.Drawing.Point(66, 63);
            this.happiHealthLabel.Name = "happiHealthLabel";
            this.happiHealthLabel.Size = new System.Drawing.Size(25, 13);
            this.happiHealthLabel.TabIndex = 26;
            this.happiHealthLabel.Text = "100";
            this.happiHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xHealthLabel
            // 
            this.xHealthLabel.AutoSize = true;
            this.xHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.xHealthLabel.ForeColor = System.Drawing.Color.Purple;
            this.xHealthLabel.Location = new System.Drawing.Point(626, 64);
            this.xHealthLabel.Name = "xHealthLabel";
            this.xHealthLabel.Size = new System.Drawing.Size(25, 13);
            this.xHealthLabel.TabIndex = 27;
            this.xHealthLabel.Text = "100";
            this.xHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deathLabel
            // 
            this.deathLabel.AutoSize = true;
            this.deathLabel.BackColor = System.Drawing.Color.Transparent;
            this.deathLabel.Font = new System.Drawing.Font("Segoe Marker", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathLabel.ForeColor = System.Drawing.Color.Red;
            this.deathLabel.Location = new System.Drawing.Point(227, 58);
            this.deathLabel.Name = "deathLabel";
            this.deathLabel.Size = new System.Drawing.Size(0, 74);
            this.deathLabel.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "+17 Damage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(664, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "+19 Damage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(3, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "+80 Health";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(666, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "+50 Health";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(7, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "+1 Ammo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(666, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "+2 Ammo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(4, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "+1 Healing";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(666, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "AIRSTRIKE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(42, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 69);
            this.label15.TabIndex = 40;
            this.label15.Text = "😷";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(608, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 69);
            this.label16.TabIndex = 41;
            this.label16.Text = "✖";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(104, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 33);
            this.label17.TabIndex = 42;
            this.label17.Text = "👊";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(587, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 31);
            this.label18.TabIndex = 43;
            this.label18.Text = "👈";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(575, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 31);
            this.label19.TabIndex = 44;
            this.label19.Text = "👈";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(659, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 39);
            this.label20.TabIndex = 45;
            this.label20.Text = "⚡";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(13, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 39);
            this.label21.TabIndex = 46;
            this.label21.Text = "💉";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(675, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 39);
            this.label22.TabIndex = 47;
            this.label22.Text = "⚡";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(586, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 33);
            this.label23.TabIndex = 48;
            this.label23.Text = "🔫";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(8, 127);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 39);
            this.label24.TabIndex = 49;
            this.label24.Text = "☼";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(96, 81);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 37);
            this.label25.TabIndex = 50;
            this.label25.Text = "🌟";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(693, 87);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 25);
            this.label26.TabIndex = 51;
            this.label26.Text = "⚡";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(217, 348);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(221, 46);
            this.axWindowsMediaPlayer1.TabIndex = 52;
            // 
            // ticktock_left
            // 
            this.ticktock_left.AutoSize = true;
            this.ticktock_left.BackColor = System.Drawing.Color.Transparent;
            this.ticktock_left.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticktock_left.ForeColor = System.Drawing.Color.White;
            this.ticktock_left.Location = new System.Drawing.Point(46, 310);
            this.ticktock_left.Name = "ticktock_left";
            this.ticktock_left.Size = new System.Drawing.Size(82, 26);
            this.ticktock_left.TabIndex = 53;
            this.ticktock_left.Text = "00:02:30";
            // 
            // ticktock_right
            // 
            this.ticktock_right.AutoSize = true;
            this.ticktock_right.BackColor = System.Drawing.Color.Transparent;
            this.ticktock_right.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticktock_right.ForeColor = System.Drawing.Color.White;
            this.ticktock_right.Location = new System.Drawing.Point(598, 310);
            this.ticktock_right.Name = "ticktock_right";
            this.ticktock_right.Size = new System.Drawing.Size(82, 26);
            this.ticktock_right.TabIndex = 54;
            this.ticktock_right.Text = "00:02:30";
            // 
            // turnTimer
            // 
            this.turnTimer.Enabled = true;
            this.turnTimer.Interval = 1000;
            this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
            // 
            // outoftime
            // 
            this.outoftime.AutoSize = true;
            this.outoftime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outoftime.Location = new System.Drawing.Point(189, 183);
            this.outoftime.Name = "outoftime";
            this.outoftime.Size = new System.Drawing.Size(0, 37);
            this.outoftime.TabIndex = 55;
            // 
            // fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fighting.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 347);
            this.Controls.Add(this.outoftime);
            this.Controls.Add(this.ticktock_right);
            this.Controls.Add(this.ticktock_left);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deathLabel);
            this.Controls.Add(this.xHealthLabel);
            this.Controls.Add(this.happiHealthLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XTermintorStatusHeal);
            this.Controls.Add(this.happiFac3StatusHeal);
            this.Controls.Add(this.XTermintorStatusAmmo);
            this.Controls.Add(this.happiFac3StatusAmmo);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.yourTurnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XTerminatorSpecial);
            this.Controls.Add(this.reloadXTerminator);
            this.Controls.Add(this.healingXTerminator);
            this.Controls.Add(this.fireXTerminator);
            this.Controls.Add(this.happiFac3Special);
            this.Controls.Add(this.reloadHappiFac3);
            this.Controls.Add(this.healingHappiFac3);
            this.Controls.Add(this.fireHappiFac3);
            this.Controls.Add(this.progressBarXTerminator);
            this.Controls.Add(this.progressBarHappiFac3);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.Color.Red;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fight";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarHappiFac3;
        private System.Windows.Forms.ProgressBar progressBarXTerminator;
        private System.Windows.Forms.Button fireHappiFac3;
        private System.Windows.Forms.Button healingHappiFac3;
        private System.Windows.Forms.Button reloadHappiFac3;
        private System.Windows.Forms.Button happiFac3Special;
        private System.Windows.Forms.Button fireXTerminator;
        private System.Windows.Forms.Button healingXTerminator;
        private System.Windows.Forms.Button reloadXTerminator;
        private System.Windows.Forms.Button XTerminatorSpecial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yourTurnLabel;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Label happiFac3StatusAmmo;
        private System.Windows.Forms.Label XTermintorStatusAmmo;
        private System.Windows.Forms.Label happiFac3StatusHeal;
        private System.Windows.Forms.Label XTermintorStatusHeal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label happiHealthLabel;
        private System.Windows.Forms.Label xHealthLabel;
        private System.Windows.Forms.Label deathLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label ticktock_left;
        private System.Windows.Forms.Label ticktock_right;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.Label outoftime;
    }
}

