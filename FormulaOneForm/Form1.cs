using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaOneForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        static string[] fontName=new string[3];
        //0--> Formula1 Display Bold
        //1--> Formula1 Display Regular
        //2--> Formula1 Display Wide

        private void mainForm_Load(object sender, EventArgs e)
        {
            font();

            label1.Font=new Font(fontName[0],10);
            label2.Font = new Font(fontName[1], 10);
            label3.Font = new Font(fontName[2], 10);
        }

        private static void font()
        {
            Dictionary<string, string> fonts = new Dictionary<string, string>() {
                { "Formula1 Display Bold",Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName+"\\customFont\\Formula1-Bold_web_0.ttf" },
                { "Formula1 Display Regular",Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName+"\\customFont\\Formula1-Regular_web_0.ttf" },
                { "Formula1 Display Wide",Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName+"\\customFont\\Formula1-Wide_web_0.ttf" }
            };

            int i=0;
            foreach (var item in fonts)
            {
                if (!IsFontInstalled(item.Key.ToString()))
                    InstallFont(item.Value.ToString(), item.Key.ToString());
                fontName[i] = item.Key.ToString();
                i++;
            }
        }

        private static bool IsFontInstalled(string fontName)
        {
            var fontsCollection = new InstalledFontCollection();
            bool resp = false;
            foreach (var fontFamily in fontsCollection.Families)
            {
                if (fontFamily.Name == fontName)
                { //check if font is installed
                    resp = true;
                    break;
                }
                else
                    resp = false;
            }
            return resp;
        }

        private static void InstallFont(string fontSourcePath,string fontName)
        {
            var shellAppType = Type.GetTypeFromProgID("Shell.Application");
            var shell = Activator.CreateInstance(shellAppType);
            var fontFolder = (Shell32.Folder)shellAppType.InvokeMember("NameSpace", System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { Environment.GetFolderPath(Environment.SpecialFolder.Fonts) });
            if (File.Exists(fontSourcePath))
                fontFolder.CopyHere(fontSourcePath);
        }
    }
}
