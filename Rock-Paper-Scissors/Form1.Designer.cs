namespace Rock_Paper_Scissors
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.lblCPUchoice = new System.Windows.Forms.Label();
            this.lblPlayerchoice = new System.Windows.Forms.Label();
            this.lblPlayerresult = new System.Windows.Forms.Label();
            this.lblCPUresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRock.Location = new System.Drawing.Point(83, 341);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(115, 61);
            this.btnRock.TabIndex = 0;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaper.Location = new System.Drawing.Point(339, 341);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(115, 61);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScissors.Location = new System.Drawing.Point(600, 341);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(115, 61);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Tag = "S";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.Location = new System.Drawing.Point(339, 38);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(115, 100);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 3;
            this.CPU_PIC.TabStop = false;
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.Location = new System.Drawing.Point(339, 188);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(115, 100);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 4;
            this.PLAYER_PIC.TabStop = false;
            // 
            // lblCPUchoice
            // 
            this.lblCPUchoice.AutoSize = true;
            this.lblCPUchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCPUchoice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPUchoice.Location = new System.Drawing.Point(326, 9);
            this.lblCPUchoice.Name = "lblCPUchoice";
            this.lblCPUchoice.Size = new System.Drawing.Size(147, 20);
            this.lblCPUchoice.TabIndex = 5;
            this.lblCPUchoice.Text = "Computer Choice";
            // 
            // lblPlayerchoice
            // 
            this.lblPlayerchoice.AutoSize = true;
            this.lblPlayerchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerchoice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayerchoice.Location = new System.Drawing.Point(336, 304);
            this.lblPlayerchoice.Name = "lblPlayerchoice";
            this.lblPlayerchoice.Size = new System.Drawing.Size(118, 20);
            this.lblPlayerchoice.TabIndex = 6;
            this.lblPlayerchoice.Text = "Player Choice";
            // 
            // lblPlayerresult
            // 
            this.lblPlayerresult.AutoSize = true;
            this.lblPlayerresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerresult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayerresult.Location = new System.Drawing.Point(80, 158);
            this.lblPlayerresult.Name = "lblPlayerresult";
            this.lblPlayerresult.Size = new System.Drawing.Size(115, 20);
            this.lblPlayerresult.TabIndex = 7;
            this.lblPlayerresult.Text = "Player Result";
            // 
            // lblCPUresult
            // 
            this.lblCPUresult.AutoSize = true;
            this.lblCPUresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCPUresult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPUresult.Location = new System.Drawing.Point(581, 158);
            this.lblCPUresult.Name = "lblCPUresult";
            this.lblCPUresult.Size = new System.Drawing.Size(144, 20);
            this.lblCPUresult.TabIndex = 8;
            this.lblCPUresult.Text = "Computer Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCPUresult);
            this.Controls.Add(this.lblPlayerresult);
            this.Controls.Add(this.lblPlayerchoice);
            this.Controls.Add(this.lblCPUchoice);
            this.Controls.Add(this.PLAYER_PIC);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox CPU_PIC;
        private System.Windows.Forms.PictureBox PLAYER_PIC;
        private System.Windows.Forms.Label lblCPUchoice;
        private System.Windows.Forms.Label lblPlayerchoice;
        private System.Windows.Forms.Label lblPlayerresult;
        private System.Windows.Forms.Label lblCPUresult;
    }
}

