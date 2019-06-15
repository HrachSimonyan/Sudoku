namespace Sudoku
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.label_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.checkBox_sound = new System.Windows.Forms.CheckBox();
            this.groupBox_gameLevel = new System.Windows.Forms.GroupBox();
            this.radioButton_expert = new System.Windows.Forms.RadioButton();
            this.radioButton_hard = new System.Windows.Forms.RadioButton();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_easy = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button_settings_cancel = new System.Windows.Forms.Button();
            this.button_settings_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mistakes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_game_level = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.num_9 = new System.Windows.Forms.Button();
            this.num_8 = new System.Windows.Forms.Button();
            this.num_7 = new System.Windows.Forms.Button();
            this.num_6 = new System.Windows.Forms.Button();
            this.num_5 = new System.Windows.Forms.Button();
            this.num_4 = new System.Windows.Forms.Button();
            this.num_3 = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.Button();
            this.num_1 = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.groupBox_gameLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.AllowUserToResizeColumns = false;
            this.datagridview.AllowUserToResizeRows = false;
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.BackgroundColor = System.Drawing.Color.White;
            this.datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridview.ColumnHeadersVisible = false;
            this.datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagridview.Location = new System.Drawing.Point(0, 0);
            this.datagridview.MaximumSize = new System.Drawing.Size(518, 352);
            this.datagridview.MinimumSize = new System.Drawing.Size(518, 352);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridview.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.datagridview.ShowCellErrors = false;
            this.datagridview.ShowCellToolTips = false;
            this.datagridview.ShowEditingIcon = false;
            this.datagridview.ShowRowErrors = false;
            this.datagridview.Size = new System.Drawing.Size(518, 352);
            this.datagridview.TabIndex = 1;
            this.datagridview.TabStop = false;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            this.datagridview.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.datagridview_CellPainting);
            this.datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellValueChanged);
            this.datagridview.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datagridview_KeyPress);
            // 
            // label_timer
            // 
            this.label_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_timer.Location = new System.Drawing.Point(464, 53);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(66, 22);
            this.label_timer.TabIndex = 0;
            this.label_timer.Text = "00:00:00";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel_settings);
            this.panel1.Controls.Add(this.datagridview);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 352);
            this.panel1.TabIndex = 4;
            // 
            // panel_settings
            // 
            this.panel_settings.BackColor = System.Drawing.Color.White;
            this.panel_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_settings.Controls.Add(this.checkBox_sound);
            this.panel_settings.Controls.Add(this.groupBox_gameLevel);
            this.panel_settings.Controls.Add(this.label5);
            this.panel_settings.Controls.Add(this.button_settings_cancel);
            this.panel_settings.Controls.Add(this.button_settings_save);
            this.panel_settings.Location = new System.Drawing.Point(168, 67);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(175, 227);
            this.panel_settings.TabIndex = 2;
            this.panel_settings.Visible = false;
            // 
            // checkBox_sound
            // 
            this.checkBox_sound.AutoSize = true;
            this.checkBox_sound.Enabled = false;
            this.checkBox_sound.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sound.Location = new System.Drawing.Point(7, 31);
            this.checkBox_sound.Name = "checkBox_sound";
            this.checkBox_sound.Size = new System.Drawing.Size(57, 20);
            this.checkBox_sound.TabIndex = 1;
            this.checkBox_sound.Text = "Sound";
            this.checkBox_sound.UseVisualStyleBackColor = true;
            // 
            // groupBox_gameLevel
            // 
            this.groupBox_gameLevel.Controls.Add(this.radioButton_expert);
            this.groupBox_gameLevel.Controls.Add(this.radioButton_hard);
            this.groupBox_gameLevel.Controls.Add(this.radioButton_normal);
            this.groupBox_gameLevel.Controls.Add(this.radioButton_easy);
            this.groupBox_gameLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_gameLevel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_gameLevel.Location = new System.Drawing.Point(1, 59);
            this.groupBox_gameLevel.Name = "groupBox_gameLevel";
            this.groupBox_gameLevel.Size = new System.Drawing.Size(169, 134);
            this.groupBox_gameLevel.TabIndex = 3;
            this.groupBox_gameLevel.TabStop = false;
            this.groupBox_gameLevel.Text = "Game level";
            // 
            // radioButton_expert
            // 
            this.radioButton_expert.AutoSize = true;
            this.radioButton_expert.Location = new System.Drawing.Point(6, 103);
            this.radioButton_expert.Name = "radioButton_expert";
            this.radioButton_expert.Size = new System.Drawing.Size(62, 22);
            this.radioButton_expert.TabIndex = 0;
            this.radioButton_expert.Text = "Expert";
            this.radioButton_expert.UseVisualStyleBackColor = true;
            this.radioButton_expert.CheckedChanged += new System.EventHandler(this.radioButton_expert_CheckedChanged);
            // 
            // radioButton_hard
            // 
            this.radioButton_hard.AutoSize = true;
            this.radioButton_hard.Location = new System.Drawing.Point(5, 75);
            this.radioButton_hard.Name = "radioButton_hard";
            this.radioButton_hard.Size = new System.Drawing.Size(54, 22);
            this.radioButton_hard.TabIndex = 0;
            this.radioButton_hard.Text = "Hard";
            this.radioButton_hard.UseVisualStyleBackColor = true;
            this.radioButton_hard.CheckedChanged += new System.EventHandler(this.radioButton_hard_CheckedChanged);
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Location = new System.Drawing.Point(5, 47);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(68, 22);
            this.radioButton_normal.TabIndex = 0;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            this.radioButton_normal.CheckedChanged += new System.EventHandler(this.radioButton_normal_CheckedChanged);
            // 
            // radioButton_easy
            // 
            this.radioButton_easy.AutoSize = true;
            this.radioButton_easy.Location = new System.Drawing.Point(6, 19);
            this.radioButton_easy.Name = "radioButton_easy";
            this.radioButton_easy.Size = new System.Drawing.Size(51, 22);
            this.radioButton_easy.TabIndex = 0;
            this.radioButton_easy.Text = "Easy";
            this.radioButton_easy.UseVisualStyleBackColor = true;
            this.radioButton_easy.CheckedChanged += new System.EventHandler(this.radioButton_easy_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Settings";
            // 
            // button_settings_cancel
            // 
            this.button_settings_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings_cancel.Location = new System.Drawing.Point(95, 199);
            this.button_settings_cancel.Name = "button_settings_cancel";
            this.button_settings_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_settings_cancel.TabIndex = 1;
            this.button_settings_cancel.Text = "Cancel";
            this.button_settings_cancel.UseVisualStyleBackColor = true;
            this.button_settings_cancel.Click += new System.EventHandler(this.button_settings_cancel_Click);
            // 
            // button_settings_save
            // 
            this.button_settings_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings_save.Location = new System.Drawing.Point(14, 199);
            this.button_settings_save.Name = "button_settings_save";
            this.button_settings_save.Size = new System.Drawing.Size(75, 23);
            this.button_settings_save.TabIndex = 0;
            this.button_settings_save.Text = "Save";
            this.button_settings_save.UseVisualStyleBackColor = true;
            this.button_settings_save.Click += new System.EventHandler(this.button_settings_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(218, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mistakes:";
            // 
            // label_mistakes
            // 
            this.label_mistakes.AutoSize = true;
            this.label_mistakes.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mistakes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_mistakes.Location = new System.Drawing.Point(293, 53);
            this.label_mistakes.Name = "label_mistakes";
            this.label_mistakes.Size = new System.Drawing.Size(31, 22);
            this.label_mistakes.TabIndex = 9;
            this.label_mistakes.Text = "0/3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Game level:";
            // 
            // label_game_level
            // 
            this.label_game_level.AutoSize = true;
            this.label_game_level.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label_game_level.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_game_level.Location = new System.Drawing.Point(92, 53);
            this.label_game_level.Name = "label_game_level";
            this.label_game_level.Size = new System.Drawing.Size(0, 22);
            this.label_game_level.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(409, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time:";
            // 
            // button_settings
            // 
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Image = global::Sudoku.Properties.Resources.settings_32px;
            this.button_settings.Location = new System.Drawing.Point(50, 8);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(32, 32);
            this.button_settings.TabIndex = 10;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Image = global::Sudoku.Properties.Resources.delete;
            this.button_delete.Location = new System.Drawing.Point(390, 439);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(44, 36);
            this.button_delete.TabIndex = 6;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // num_9
            // 
            this.num_9.BackColor = System.Drawing.Color.White;
            this.num_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_9.ForeColor = System.Drawing.Color.White;
            this.num_9.Image = global::Sudoku.Properties.Resources.num9;
            this.num_9.Location = new System.Drawing.Point(348, 439);
            this.num_9.Name = "num_9";
            this.num_9.Size = new System.Drawing.Size(36, 36);
            this.num_9.TabIndex = 5;
            this.num_9.UseVisualStyleBackColor = false;
            this.num_9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num_8
            // 
            this.num_8.BackColor = System.Drawing.Color.White;
            this.num_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_8.ForeColor = System.Drawing.Color.White;
            this.num_8.Image = global::Sudoku.Properties.Resources.num8;
            this.num_8.Location = new System.Drawing.Point(306, 439);
            this.num_8.Name = "num_8";
            this.num_8.Size = new System.Drawing.Size(36, 36);
            this.num_8.TabIndex = 5;
            this.num_8.UseVisualStyleBackColor = false;
            this.num_8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num_7
            // 
            this.num_7.BackColor = System.Drawing.Color.White;
            this.num_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_7.ForeColor = System.Drawing.Color.White;
            this.num_7.Image = global::Sudoku.Properties.Resources.num7;
            this.num_7.Location = new System.Drawing.Point(264, 439);
            this.num_7.Name = "num_7";
            this.num_7.Size = new System.Drawing.Size(36, 36);
            this.num_7.TabIndex = 5;
            this.num_7.UseVisualStyleBackColor = false;
            this.num_7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num_6
            // 
            this.num_6.BackColor = System.Drawing.Color.White;
            this.num_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_6.ForeColor = System.Drawing.Color.White;
            this.num_6.Image = global::Sudoku.Properties.Resources.num6;
            this.num_6.Location = new System.Drawing.Point(222, 439);
            this.num_6.Name = "num_6";
            this.num_6.Size = new System.Drawing.Size(36, 36);
            this.num_6.TabIndex = 5;
            this.num_6.UseVisualStyleBackColor = false;
            this.num_6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num_5
            // 
            this.num_5.BackColor = System.Drawing.Color.White;
            this.num_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_5.ForeColor = System.Drawing.Color.White;
            this.num_5.Image = global::Sudoku.Properties.Resources.num5;
            this.num_5.Location = new System.Drawing.Point(180, 439);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(36, 36);
            this.num_5.TabIndex = 5;
            this.num_5.UseVisualStyleBackColor = false;
            this.num_5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num_4
            // 
            this.num_4.BackColor = System.Drawing.Color.White;
            this.num_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_4.ForeColor = System.Drawing.Color.White;
            this.num_4.Image = global::Sudoku.Properties.Resources.num4;
            this.num_4.Location = new System.Drawing.Point(138, 439);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(36, 36);
            this.num_4.TabIndex = 5;
            this.num_4.UseVisualStyleBackColor = false;
            this.num_4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num_3
            // 
            this.num_3.BackColor = System.Drawing.Color.White;
            this.num_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_3.ForeColor = System.Drawing.Color.White;
            this.num_3.Image = global::Sudoku.Properties.Resources.num3;
            this.num_3.Location = new System.Drawing.Point(96, 439);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(36, 36);
            this.num_3.TabIndex = 5;
            this.num_3.UseVisualStyleBackColor = false;
            this.num_3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num_2
            // 
            this.num_2.BackColor = System.Drawing.Color.White;
            this.num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_2.ForeColor = System.Drawing.Color.White;
            this.num_2.Image = global::Sudoku.Properties.Resources.num2;
            this.num_2.Location = new System.Drawing.Point(54, 439);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(36, 36);
            this.num_2.TabIndex = 5;
            this.num_2.UseVisualStyleBackColor = false;
            this.num_2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num_1
            // 
            this.num_1.BackColor = System.Drawing.Color.White;
            this.num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_1.ForeColor = System.Drawing.Color.White;
            this.num_1.Image = global::Sudoku.Properties.Resources.num1;
            this.num_1.Location = new System.Drawing.Point(12, 439);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(36, 36);
            this.num_1.TabIndex = 5;
            this.num_1.UseVisualStyleBackColor = false;
            this.num_1.Click += new System.EventHandler(this.num1_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.White;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_play.ForeColor = System.Drawing.Color.Ivory;
            this.button_play.Image = global::Sudoku.Properties.Resources.play_32px;
            this.button_play.Location = new System.Drawing.Point(12, 8);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(32, 32);
            this.button_play.TabIndex = 3;
            this.button_play.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.BackColor = System.Drawing.Color.White;
            this.button_help.FlatAppearance.BorderSize = 0;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.ForeColor = System.Drawing.Color.White;
            this.button_help.Image = global::Sudoku.Properties.Resources.help_32px1;
            this.button_help.Location = new System.Drawing.Point(437, 3);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(35, 32);
            this.button_help.TabIndex = 0;
            this.button_help.TabStop = false;
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_min
            // 
            this.button_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_min.BackColor = System.Drawing.Color.White;
            this.button_min.FlatAppearance.BorderSize = 0;
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_min.ForeColor = System.Drawing.Color.White;
            this.button_min.Image = global::Sudoku.Properties.Resources.minimize;
            this.button_min.Location = new System.Drawing.Point(478, 8);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(23, 23);
            this.button_min.TabIndex = 0;
            this.button_min.TabStop = false;
            this.button_min.UseVisualStyleBackColor = false;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            this.button_min.MouseLeave += new System.EventHandler(this.button_min_MouseLeave);
            this.button_min.MouseHover += new System.EventHandler(this.button_min_MouseHover);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.White;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Image = global::Sudoku.Properties.Resources.close;
            this.button_close.Location = new System.Drawing.Point(507, 8);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(23, 23);
            this.button_close.TabIndex = 0;
            this.button_close.TabStop = false;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            this.button_close.MouseLeave += new System.EventHandler(this.button_close_MouseLeave);
            this.button_close.MouseHover += new System.EventHandler(this.button_close_MouseHover);
            // 
            // button_restart
            // 
            this.button_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restart.ForeColor = System.Drawing.Color.White;
            this.button_restart.Image = global::Sudoku.Properties.Resources.restart_32px;
            this.button_restart.Location = new System.Drawing.Point(88, 8);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(32, 32);
            this.button_restart.TabIndex = 10;
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(542, 495);
            this.ControlBox = false;
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.label_mistakes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_game_level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.num_9);
            this.Controls.Add(this.num_8);
            this.Controls.Add(this.num_7);
            this.Controls.Add(this.num_6);
            this.Controls.Add(this.num_5);
            this.Controls.Add(this.num_4);
            this.Controls.Add(this.num_3);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_close);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(542, 495);
            this.MinimumSize = new System.Drawing.Size(542, 495);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.groupBox_gameLevel.ResumeLayout(false);
            this.groupBox_gameLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button num_1;
        private System.Windows.Forms.Button num_3;
        private System.Windows.Forms.Button num_4;
        private System.Windows.Forms.Button num_5;
        private System.Windows.Forms.Button num_6;
        private System.Windows.Forms.Button num_7;
        private System.Windows.Forms.Button num_8;
        private System.Windows.Forms.Button num_9;
        private System.Windows.Forms.Button num_2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mistakes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_game_level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.CheckBox checkBox_sound;
        private System.Windows.Forms.GroupBox groupBox_gameLevel;
        private System.Windows.Forms.RadioButton radioButton_expert;
        private System.Windows.Forms.RadioButton radioButton_hard;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButton_easy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_settings_cancel;
        private System.Windows.Forms.Button button_settings_save;
        private System.Windows.Forms.Button button_restart;
    }
}

