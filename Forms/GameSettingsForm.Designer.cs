﻿namespace ReversedXMixDrix
{
    partial class GameSettingsForm
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
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelCols = new System.Windows.Forms.Label();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.ButtonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayers
            // 
            this.labelPlayers.AccessibleName = "";
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(40, 40);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(64, 20);
            this.labelPlayers.TabIndex = 0;
            this.labelPlayers.Text = "Players:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AccessibleName = "";
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(60, 90);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(69, 20);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // labelRows
            // 
            this.labelRows.AccessibleName = "Rows";
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(60, 260);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(53, 20);
            this.labelRows.TabIndex = 0;
            this.labelRows.Text = "Rows:";
            // 
            // labelCols
            // 
            this.labelCols.AccessibleName = "";
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(220, 260);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(44, 20);
            this.labelCols.TabIndex = 0;
            this.labelCols.Text = "Cols:";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AccessibleName = "Board Size";
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Location = new System.Drawing.Point(40, 200);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(91, 20);
            this.labelBoardSize.TabIndex = 0;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(180, 80);
            this.textBoxPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(170, 26);
            this.textBoxPlayer1.TabIndex = 1;
            this.textBoxPlayer1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(180, 130);
            this.textBoxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(170, 26);
            this.textBoxPlayer2.TabIndex = 1;
            this.textBoxPlayer2.Text = "[Computer]";
            this.textBoxPlayer2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AccessibleName = "";
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(60, 130);
            this.checkBoxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(95, 24);
            this.checkBoxPlayer2.TabIndex = 2;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.Click += new System.EventHandler(this.checkBoxPlayer2_Click);
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(150, 256);
            this.numericUpDownRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownRows.TabIndex = 3;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.Click += new System.EventHandler(this.numericUpDown_Click);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(300, 256);
            this.numericUpDownCols.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownCols.TabIndex = 3;
            this.numericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCols.Click += new System.EventHandler(this.numericUpDown_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.AccessibleName = "";
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Location = new System.Drawing.Point(70, 330);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(270, 40);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Start!";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 389);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.ShowIcon = false;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Button ButtonStart;
    }
}