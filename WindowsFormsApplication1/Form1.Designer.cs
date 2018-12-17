namespace WindowsFormsApplication1
{
    partial class TicTacToe
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnFrench = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHumanToComputer = new System.Windows.Forms.Button();
            this.btnHumanToHuman = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.radioEasy = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblGameType = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.txtPlayerXResult = new System.Windows.Forms.TextBox();
            this.txtPlayerOResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LimeGreen;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(318, 145);
            this.btn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 95);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEnglish.Location = new System.Drawing.Point(840, 514);
            this.btnEnglish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(147, 64);
            this.btnEnglish.TabIndex = 9;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnFrench
            // 
            this.btnFrench.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrench.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFrench.Location = new System.Drawing.Point(685, 514);
            this.btnFrench.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(147, 64);
            this.btnFrench.TabIndex = 10;
            this.btnFrench.Text = "Français";
            this.btnFrench.UseVisualStyleBackColor = false;
            this.btnFrench.Click += new System.EventHandler(this.btnFrench_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(731, 352);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 61);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHumanToComputer
            // 
            this.btnHumanToComputer.BackColor = System.Drawing.Color.DarkGreen;
            this.btnHumanToComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHumanToComputer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHumanToComputer.Location = new System.Drawing.Point(28, 96);
            this.btnHumanToComputer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnHumanToComputer.Name = "btnHumanToComputer";
            this.btnHumanToComputer.Size = new System.Drawing.Size(242, 61);
            this.btnHumanToComputer.TabIndex = 12;
            this.btnHumanToComputer.Text = "Human To Computer";
            this.btnHumanToComputer.UseVisualStyleBackColor = false;
            this.btnHumanToComputer.Click += new System.EventHandler(this.btnHumanToComputer_Click);
            // 
            // btnHumanToHuman
            // 
            this.btnHumanToHuman.BackColor = System.Drawing.Color.Green;
            this.btnHumanToHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHumanToHuman.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHumanToHuman.Location = new System.Drawing.Point(29, 173);
            this.btnHumanToHuman.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnHumanToHuman.Name = "btnHumanToHuman";
            this.btnHumanToHuman.Size = new System.Drawing.Size(242, 60);
            this.btnHumanToHuman.TabIndex = 13;
            this.btnHumanToHuman.Text = "Human To Human";
            this.btnHumanToHuman.UseVisualStyleBackColor = false;
            this.btnHumanToHuman.Click += new System.EventHandler(this.btnHumanToHuman_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LimeGreen;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Location = new System.Drawing.Point(420, 145);
            this.btn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 95);
            this.btn2.TabIndex = 14;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            this.btn2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LimeGreen;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Location = new System.Drawing.Point(522, 145);
            this.btn3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 95);
            this.btn3.TabIndex = 15;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            this.btn3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LimeGreen;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Location = new System.Drawing.Point(318, 246);
            this.btn4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 95);
            this.btn4.TabIndex = 16;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            this.btn4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LimeGreen;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Location = new System.Drawing.Point(420, 246);
            this.btn5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 95);
            this.btn5.TabIndex = 17;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            this.btn5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LimeGreen;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Location = new System.Drawing.Point(522, 246);
            this.btn6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 95);
            this.btn6.TabIndex = 18;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            this.btn6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LimeGreen;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(318, 344);
            this.btn7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 95);
            this.btn7.TabIndex = 19;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            this.btn7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LimeGreen;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Location = new System.Drawing.Point(420, 346);
            this.btn8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 95);
            this.btn8.TabIndex = 20;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            this.btn8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LimeGreen;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(522, 346);
            this.btn9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 95);
            this.btn9.TabIndex = 21;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            this.btn9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(66, 265);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(303, 53);
            this.lblLevel.TabIndex = 22;
            this.lblLevel.Text = "Choose level:";
            // 
            // radioEasy
            // 
            this.radioEasy.AutoSize = true;
            this.radioEasy.BackColor = System.Drawing.Color.Transparent;
            this.radioEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEasy.Location = new System.Drawing.Point(91, 311);
            this.radioEasy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioEasy.Name = "radioEasy";
            this.radioEasy.Size = new System.Drawing.Size(140, 50);
            this.radioEasy.TabIndex = 23;
            this.radioEasy.Text = "Easy";
            this.radioEasy.UseVisualStyleBackColor = false;
            this.radioEasy.CheckedChanged += new System.EventHandler(this.radioEasy_CheckedChanged);
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.BackColor = System.Drawing.Color.Transparent;
            this.radioMedium.Checked = true;
            this.radioMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMedium.Location = new System.Drawing.Point(93, 352);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(192, 50);
            this.radioMedium.TabIndex = 24;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = false;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // radioHard
            // 
            this.radioHard.AutoSize = true;
            this.radioHard.BackColor = System.Drawing.Color.Transparent;
            this.radioHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHard.Location = new System.Drawing.Point(93, 394);
            this.radioHard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(137, 50);
            this.radioHard.TabIndex = 25;
            this.radioHard.Text = "Hard";
            this.radioHard.UseVisualStyleBackColor = false;
            this.radioHard.CheckedChanged += new System.EventHandler(this.radioHard_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(347, 61);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(423, 79);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Tic Tac Toe ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(45, 465);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(214, 113);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "Start new round";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Green;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUndo.Location = new System.Drawing.Point(731, 265);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(173, 60);
            this.btnUndo.TabIndex = 28;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.BackColor = System.Drawing.Color.Transparent;
            this.lblGameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameType.Location = new System.Drawing.Point(44, 49);
            this.lblGameType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(415, 53);
            this.lblGameType.TabIndex = 29;
            this.lblGameType.Text = "Choose opponent: ";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(707, 61);
            this.lblResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(461, 53);
            this.lblResults.TabIndex = 30;
            this.lblResults.Text = "Results for the game:";
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.AutoSize = true;
            this.lblPlayerX.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(667, 123);
            this.lblPlayerX.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(190, 48);
            this.lblPlayerX.TabIndex = 31;
            this.lblPlayerX.Text = "Player X:";
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.AutoSize = true;
            this.lblPlayerO.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.Location = new System.Drawing.Point(646, 179);
            this.lblPlayerO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(215, 48);
            this.lblPlayerO.TabIndex = 32;
            this.lblPlayerO.Text = "Computer:";
            // 
            // txtPlayerXResult
            // 
            this.txtPlayerXResult.BackColor = System.Drawing.Color.DarkOrange;
            this.txtPlayerXResult.Enabled = false;
            this.txtPlayerXResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerXResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPlayerXResult.Location = new System.Drawing.Point(813, 117);
            this.txtPlayerXResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPlayerXResult.Name = "txtPlayerXResult";
            this.txtPlayerXResult.ReadOnly = true;
            this.txtPlayerXResult.Size = new System.Drawing.Size(180, 62);
            this.txtPlayerXResult.TabIndex = 33;
            // 
            // txtPlayerOResult
            // 
            this.txtPlayerOResult.BackColor = System.Drawing.Color.DarkOrange;
            this.txtPlayerOResult.Enabled = false;
            this.txtPlayerOResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPlayerOResult.Location = new System.Drawing.Point(813, 173);
            this.txtPlayerOResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPlayerOResult.Name = "txtPlayerOResult";
            this.txtPlayerOResult.ReadOnly = true;
            this.txtPlayerOResult.Size = new System.Drawing.Size(180, 62);
            this.txtPlayerOResult.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(522, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 64);
            this.button1.TabIndex = 36;
            this.button1.Text = "ไทย";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1197, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlayerOResult);
            this.Controls.Add(this.txtPlayerXResult);
            this.Controls.Add(this.lblPlayerO);
            this.Controls.Add(this.lblPlayerX);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblGameType);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.radioHard);
            this.Controls.Add(this.radioMedium);
            this.Controls.Add(this.radioEasy);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnHumanToHuman);
            this.Controls.Add(this.btnHumanToComputer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFrench);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnFrench;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHumanToComputer;
        private System.Windows.Forms.Button btnHumanToHuman;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.RadioButton radioEasy;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblGameType;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.TextBox txtPlayerXResult;
        private System.Windows.Forms.TextBox txtPlayerOResult;
        private System.Windows.Forms.Button button1;
    }
}

