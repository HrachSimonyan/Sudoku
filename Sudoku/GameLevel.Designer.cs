namespace Sudoku
{
    partial class GameLevel
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_easy = new System.Windows.Forms.RadioButton();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_hard = new System.Windows.Forms.RadioButton();
            this.button_start = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_expert = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose game level";
            // 
            // radioButton_easy
            // 
            this.radioButton_easy.AutoSize = true;
            this.radioButton_easy.Checked = true;
            this.radioButton_easy.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_easy.Location = new System.Drawing.Point(16, 43);
            this.radioButton_easy.Name = "radioButton_easy";
            this.radioButton_easy.Size = new System.Drawing.Size(58, 26);
            this.radioButton_easy.TabIndex = 1;
            this.radioButton_easy.TabStop = true;
            this.radioButton_easy.Text = "Easy";
            this.radioButton_easy.UseVisualStyleBackColor = true;
            this.radioButton_easy.CheckedChanged += new System.EventHandler(this.radioButton_easy_CheckedChanged);
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_normal.Location = new System.Drawing.Point(16, 75);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(79, 26);
            this.radioButton_normal.TabIndex = 1;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            this.radioButton_normal.CheckedChanged += new System.EventHandler(this.radioButton_normal_CheckedChanged);
            // 
            // radioButton_hard
            // 
            this.radioButton_hard.AutoSize = true;
            this.radioButton_hard.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_hard.Location = new System.Drawing.Point(16, 107);
            this.radioButton_hard.Name = "radioButton_hard";
            this.radioButton_hard.Size = new System.Drawing.Size(61, 26);
            this.radioButton_hard.TabIndex = 1;
            this.radioButton_hard.Text = "Hard";
            this.radioButton_hard.UseVisualStyleBackColor = true;
            this.radioButton_hard.CheckedChanged += new System.EventHandler(this.radioButton_hard_CheckedChanged);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(12, 171);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Red;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(92, 171);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_expert
            // 
            this.radioButton_expert.AutoSize = true;
            this.radioButton_expert.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_expert.Location = new System.Drawing.Point(16, 139);
            this.radioButton_expert.Name = "radioButton_expert";
            this.radioButton_expert.Size = new System.Drawing.Size(70, 26);
            this.radioButton_expert.TabIndex = 1;
            this.radioButton_expert.Text = "Expert";
            this.radioButton_expert.UseVisualStyleBackColor = true;
            this.radioButton_expert.CheckedChanged += new System.EventHandler(this.radioButton_expert_CheckedChanged);
            // 
            // GameLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 202);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.radioButton_expert);
            this.Controls.Add(this.radioButton_hard);
            this.Controls.Add(this.radioButton_normal);
            this.Controls.Add(this.radioButton_easy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(179, 202);
            this.MinimumSize = new System.Drawing.Size(179, 202);
            this.Name = "GameLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_easy;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButton_hard;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RadioButton radioButton_expert;
    }
}