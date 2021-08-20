
namespace SimbirSoftProj
{
    partial class ParserApp
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CountedWordsTextBox = new System.Windows.Forms.RichTextBox();
            this.LogFileTextBox = new System.Windows.Forms.RichTextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CountWordsButton = new System.Windows.Forms.Button();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DBNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LinkComboBox = new System.Windows.Forms.ComboBox();
            this.IgnoredTagTextBox = new System.Windows.Forms.TextBox();
            this.AddIgnoredTagButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(-1979, -812);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(230, 209);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Посчитанные слова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логирование действий программы";
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(584, 62);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(318, 27);
            this.LinkTextBox.TabIndex = 5;
            this.LinkTextBox.TextChanged += new System.EventHandler(this.LinkTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите ссылку на сайт для парсинга";
            // 
            // CountedWordsTextBox
            // 
            this.CountedWordsTextBox.Location = new System.Drawing.Point(13, 36);
            this.CountedWordsTextBox.Name = "CountedWordsTextBox";
            this.CountedWordsTextBox.ReadOnly = true;
            this.CountedWordsTextBox.Size = new System.Drawing.Size(556, 372);
            this.CountedWordsTextBox.TabIndex = 8;
            this.CountedWordsTextBox.Text = "";
            // 
            // LogFileTextBox
            // 
            this.LogFileTextBox.Location = new System.Drawing.Point(13, 434);
            this.LogFileTextBox.Name = "LogFileTextBox";
            this.LogFileTextBox.ReadOnly = true;
            this.LogFileTextBox.Size = new System.Drawing.Size(556, 227);
            this.LogFileTextBox.TabIndex = 9;
            this.LogFileTextBox.Text = "";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(584, 295);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(319, 34);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Загрузить данные в БД";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CountWordsButton
            // 
            this.CountWordsButton.Location = new System.Drawing.Point(584, 150);
            this.CountWordsButton.Name = "CountWordsButton";
            this.CountWordsButton.Size = new System.Drawing.Size(318, 33);
            this.CountWordsButton.TabIndex = 12;
            this.CountWordsButton.Text = "Посчитать слова";
            this.CountWordsButton.UseVisualStyleBackColor = true;
            this.CountWordsButton.Click += new System.EventHandler(this.CountWordsButton_Click);
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(584, 209);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(318, 27);
            this.ServerNameTextBox.TabIndex = 13;
            this.ServerNameTextBox.TextChanged += new System.EventHandler(this.ServerNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите имя сервера";
            // 
            // DBNameTextBox
            // 
            this.DBNameTextBox.Location = new System.Drawing.Point(584, 262);
            this.DBNameTextBox.Name = "DBNameTextBox";
            this.DBNameTextBox.Size = new System.Drawing.Size(318, 27);
            this.DBNameTextBox.TabIndex = 15;
            this.DBNameTextBox.TextChanged += new System.EventHandler(this.DBNameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Введите имя базы данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Или выберите из предустановленных";
            // 
            // LinkComboBox
            // 
            this.LinkComboBox.FormattingEnabled = true;
            this.LinkComboBox.Items.AddRange(new object[] {
            "https://www.simbirsoft.com/career/",
            "https://www.microsoft.com/ru-ru/",
            "https://stackoverflow.com/",
            "https://coderoad.ru/"});
            this.LinkComboBox.Location = new System.Drawing.Point(584, 116);
            this.LinkComboBox.Name = "LinkComboBox";
            this.LinkComboBox.Size = new System.Drawing.Size(318, 28);
            this.LinkComboBox.TabIndex = 19;
            this.LinkComboBox.SelectedIndexChanged += new System.EventHandler(this.LinkComboBox_SelectedIndexChanged);
            // 
            // IgnoredTagTextBox
            // 
            this.IgnoredTagTextBox.Location = new System.Drawing.Point(585, 355);
            this.IgnoredTagTextBox.Name = "IgnoredTagTextBox";
            this.IgnoredTagTextBox.Size = new System.Drawing.Size(318, 27);
            this.IgnoredTagTextBox.TabIndex = 17;
            this.ToolTip.SetToolTip(this.IgnoredTagTextBox, "Введите тег без угловых скобочек и прочих символов. Игнорируемый тег не будет ска" +
        "нироваться программой при парсинге.");
            this.IgnoredTagTextBox.TextChanged += new System.EventHandler(this.IgnoredTagTextBox_TextChanged);
            // 
            // AddIgnoredTagButton
            // 
            this.AddIgnoredTagButton.Location = new System.Drawing.Point(584, 385);
            this.AddIgnoredTagButton.Name = "AddIgnoredTagButton";
            this.AddIgnoredTagButton.Size = new System.Drawing.Size(319, 34);
            this.AddIgnoredTagButton.TabIndex = 17;
            this.AddIgnoredTagButton.Text = "Добавить тег";
            this.AddIgnoredTagButton.UseVisualStyleBackColor = true;
            this.AddIgnoredTagButton.Click += new System.EventHandler(this.AddIgnoredTagButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Введите тег для добавления в игнорируемые";
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 100;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Подсказка";
            // 
            // ParserApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DBNameTextBox);
            this.Controls.Add(this.AddIgnoredTagButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.IgnoredTagTextBox);
            this.Controls.Add(this.ServerNameTextBox);
            this.Controls.Add(this.LinkComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CountWordsButton);
            this.Controls.Add(this.LogFileTextBox);
            this.Controls.Add(this.CountedWordsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParserApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парсер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CountedWordsTextBox;
        private System.Windows.Forms.RichTextBox LogFileTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button CountWordsButton;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox LinkComboBox;
        private System.Windows.Forms.TextBox IgnoredTagTextBox;
        private System.Windows.Forms.Button AddIgnoredTagButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

