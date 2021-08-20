using SimbirSoftProj.Core;
using SimbirSoftProj.Core.DBConnection;
using SimbirSoftProj.Core.Parsers;
using SimbirSoftProj.Core.Parsers.ParserSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SimbirSoftProj
{
    public partial class ParserApp : Form
    {
        ParserWorker<string[]> parser;
        IDBSettings dBSettings;
        IParserSettings parserSettings;
        Dictionary<string, int> countedWords;

        public ParserApp()
        {
            InitializeComponent();
        }
        private void Parser_OnNewData(object parser, string[] text)
        {
            countedWords = WordCounter.GetCountedWords(text);
            foreach (var word in countedWords)
                CountedWordsTextBox.Text += word.Key + " = " + word.Value + "\n";

            try
            {
                using (StreamReader reader = new StreamReader("LogFile.txt"))
                {
                    LogFileTextBox.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't open LogFile. [ {ex.Message} ]");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CountWordsButton.Enabled = false;
            LoadButton.Enabled = false;
            AddIgnoredTagButton.Enabled = false;
        }

        private void CountWordsButton_Click(object sender, EventArgs e)
        {
            CountedWordsTextBox.Clear();
            LogFileTextBox.Clear();

            var simpleParser = new SimpleParser();
            parser = new ParserWorker<string[]>(simpleParser, parserSettings);

            parser.OnNewData += Parser_OnNewData;
            parser.Worker();
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CountedWordsTextBox.Text != "")
                {
                    dBSettings = new ModifiableDBSettings(ServerNameTextBox.Text, DBNameTextBox.Text);
                    DBConnector connector = new DBConnector(dBSettings);
                    connector.OpenConnection();
                    connector.FillTableWithData(countedWords);
                    connector.CloseConnection();
                    MessageBox.Show($"Данные загружены в базу!");
                }
                else
                    MessageBox.Show("Отсутствуют данные для загрузки в базу! Сначала запустите подсчет слов.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных в базу. [ {ex.Message} ]");
            }

            try
            {
                using (StreamReader reader = new StreamReader("LogFile.txt"))
                {
                    LogFileTextBox.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't open LogFile. [ {ex.Message} ]");
            }
        }

        private void LinkTextBox_TextChanged(object sender, EventArgs e)
        {
            LinkComboBox.Text = "";
            parserSettings = new LinkOnlyParserSettings(LinkTextBox.Text);
            CountWordsButton.Enabled = true;
        }

        private void LinkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LinkTextBox.Text = "";
            parserSettings = new LinkOnlyParserSettings(LinkComboBox.Text);
            CountWordsButton.Enabled = true;
        }

        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DBNameTextBox.Text != "")
                LoadButton.Enabled = true;
            else
                LoadButton.Enabled = false;
        }

        private void DBNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ServerNameTextBox.Text != "")
                LoadButton.Enabled = true;
            else
                LoadButton.Enabled = false;
        }

        private void AddIgnoredTagButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("IgnoredTags.txt",true))
                {
                    writer.WriteLine(IgnoredTagTextBox.Text.ToUpper());
                }
                MessageBox.Show("Тег добавлен в игнорируемые!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Не удалось добавить тег в игнорируемые. [ {ex.Message} ]");
            }
            
        }

        private void IgnoredTagTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IgnoredTagTextBox.Text != "")
                AddIgnoredTagButton.Enabled = true;
            else
                AddIgnoredTagButton.Enabled = false;
        }
    }
}
