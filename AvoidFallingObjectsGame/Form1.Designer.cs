namespace AvoidFallingObjectsGame
{
    partial class Form1
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
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.UI_BlockCountLbl = new System.Windows.Forms.Label();
            this.UI_PlayerScore_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 50;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // UI_BlockCountLbl
            // 
            this.UI_BlockCountLbl.AutoSize = true;
            this.UI_BlockCountLbl.Location = new System.Drawing.Point(43, 63);
            this.UI_BlockCountLbl.Name = "UI_BlockCountLbl";
            this.UI_BlockCountLbl.Size = new System.Drawing.Size(174, 30);
            this.UI_BlockCountLbl.TabIndex = 0;
            this.UI_BlockCountLbl.Text = "Block Count : 0";
            // 
            // UI_PlayerScore_Lbl
            // 
            this.UI_PlayerScore_Lbl.AutoSize = true;
            this.UI_PlayerScore_Lbl.Location = new System.Drawing.Point(346, 63);
            this.UI_PlayerScore_Lbl.Name = "UI_PlayerScore_Lbl";
            this.UI_PlayerScore_Lbl.Size = new System.Drawing.Size(186, 30);
            this.UI_PlayerScore_Lbl.TabIndex = 1;
            this.UI_PlayerScore_Lbl.Text = "Player_Score : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 280);
            this.Controls.Add(this.UI_PlayerScore_Lbl);
            this.Controls.Add(this.UI_BlockCountLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label UI_BlockCountLbl;
        private System.Windows.Forms.Label UI_PlayerScore_Lbl;
    }
}

