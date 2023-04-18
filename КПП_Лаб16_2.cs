using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyApplication
{
public partial class MainForm : Form
{
private bool radioButtonChecked;
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // завантаження налаштувань з XML-файлу
        LoadSettings();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // збереження налаштувань в XML-файл перед закриттям форми
        SaveSettings();
    }

    private void SaveSettings()
    {
        // створення об'єкта налаштувань
        Settings settings = new Settings();
        settings.FormX = this.Location.X;
        settings.FormY = this.Location.Y;
        settings.RadioButtonChecked = radioButtonChecked;

        // серіалізація налаштувань до XML-файлу
        XmlSerializer serializer = new XmlSerializer(typeof(Settings));
        using (TextWriter writer = new StreamWriter("settings.xml"))
        {
            serializer.Serialize(writer, settings);
        }
    }

    private void LoadSettings()
    {
        // завантаження налаштувань з XML-файлу
        XmlSerializer serializer = new XmlSerializer(typeof(Settings));
        try
        {
            using (TextReader reader = new StreamReader("settings.xml"))
            {
                Settings settings = (Settings)serializer.Deserialize(reader);
                this.Location = new System.Drawing.Point(settings.FormX, settings.FormY);
                radioButtonChecked = settings.RadioButtonChecked;
                radioButton.Checked = radioButtonChecked;
            }
        }
        catch (FileNotFoundException)
        {
            // якщо файл налаштувань не знайдено, залишаємо налаштування за замовчуванням
        }
    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        radioButtonChecked = radioButton.Checked;
    }
}

    public class Settings
    {
        public int FormX { get; set; }
        public int FormY { get; set; }
        public bool RadioButtonChecked { get; set; }
    }
}