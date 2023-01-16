using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using WpfMath;
using WpfMath.Converters;

namespace Mathink.GUI
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string OutputPath { get; private set; }
        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            slRet.Text = string.Empty;
            var latex = txtIn.Text.Trim();
            if (latex == string.Empty) return;
            string svgStr;
            try
            {
                (svgStr, imgOut) = renderLatex(latex, false);
            }
            catch (Exception ex)
            {
                slErr.Text = "Error: " + ex.Message;
                return;
            }
            File.WriteAllText(OutputPath, svgStr);
            using (var ms = new MemoryStream(imgOut))
            {
                this.picOut.Image = Image.FromStream(ms);
            }
            slErr.Text = string.Empty;
            slRet.Text = "Rendered successfully";

        }
        byte[] imgOut;



        private static (string, byte[]) renderLatex(string latex, bool onlyReturnDpath = true)
        {

            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);
            var renderer = formula.GetRenderer(TexStyle.Display, 20, "Arial");
            var pngBytes = formula.RenderToPng(20.0, 0.0, 0.0, "Arial");
            var geometry = renderer.RenderToGeometry(0, 0);
            var converter = new SVGConverter();
            var svgPathText = converter.ConvertGeometry(geometry);
            if (!onlyReturnDpath) return (AddSVGHeader(svgPathText), pngBytes);
            var tmp1 = svgPathText.Split(new string[] { "d=\"" }, StringSplitOptions.None)[1];
            var tmp2 = tmp1.Split(new string[] { "\"" }, StringSplitOptions.None)[0];
            return (tmp2, pngBytes);
        }
        private static string AddSVGHeader(string svgText)
        {
            var builder = new StringBuilder();
            builder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>")
                .AppendLine("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" >")
                .AppendLine("<g>")
                .AppendLine(svgText)
                .AppendLine("</g>")
                .AppendLine("</svg>");

            return builder.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OutputPath = Application.StartupPath + Path.DirectorySeparatorChar + "out.svg";
            txtIn_TextChanged(null, null);
            TopWindowToolStripMenuItem_Click(null, null);

            tabPage1.Parent = null;
            //wb.AllowWebBrowserDrop = false;
            //wb.IsWebBrowserContextMenuEnabled = false;
            //wb.WebBrowserShortcutsEnabled = false;
            //wb.ObjectForScripting = this;
            //wb.Url = new Uri(Application.StartupPath + "/editor/index.html");
        }

        public void Callback(string svgstr)
        {
            MessageBox.Show(svgstr);
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open a file";
            dialog.FileName = "";
            dialog.Filter = "Plain text(.txt)|.txt|Markdown(.md)|.md|LaTex(.tex)|.tex|All(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.Cancel) return;
            var fileName = dialog.FileName;
            if (!File.Exists(fileName))
            {
                MessageBox.Show("File does not exist!", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIn.Text = File.ReadAllText(fileName);

        }

        private void savePNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "";
            dialog.Filter = "PNG format|.png";
            dialog.Title = "Save as PNG";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            var fileName = dialog.FileName;
            if (!fileName.EndsWith(".png")) fileName += ".png";
            System.IO.File.WriteAllBytes(fileName, imgOut);
            var ret = MessageBox.Show("Saved successfully , Is it the right directory?", "Hint", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                string argument = "/select, \"" + fileName + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
        }

        private void saveSVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string svg;
            var latex = txtIn.Text.Trim();
            (svg, _) = renderLatex(latex, false);

            var dialog = new SaveFileDialog();
            dialog.FileName = "";
            dialog.Filter = "SVG format(.svg)";
            dialog.Title = "Save as SVG";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            var fileName = dialog.FileName;
            if (!fileName.EndsWith(".svg")) fileName += ".svg";
            System.IO.File.WriteAllText(fileName, svg);
            var ret = MessageBox.Show("Saved successfully, Is it the right directory?", "Hint", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                string argument = "/select, \"" + fileName + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }

        }

        private void saveTxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var latex = txtIn.Text.Trim();

            var dialog = new SaveFileDialog();
            dialog.FileName = "";
            dialog.Filter = "plain text(.txt)|.txt";
            dialog.Title = "Save as txt";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            var fileName = dialog.FileName;
            if (!fileName.EndsWith(".txt")) fileName += ".txt";
            System.IO.File.WriteAllText(fileName, latex);
            var ret = MessageBox.Show("Saved successfully, Is it the right directory?", "Hint", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                string argument = "/select, \"" + fileName + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
        }

        private void cpyOutPath(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputPath);
            slRet.Text = "Copy successfully!";
        }

        private void openProgDir(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Application.StartupPath);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.Delete(OutputPath);
        }

        private void EmptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIn.Clear();
            picOut.Image = null;
        }

        private void TopWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = topWindowToolStripMenuItem.Checked;
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ret = MessageBox.Show("It will open the Github repo webpage, continue?", "Hint", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.Cancel) return;
            Process.Start("https://github.com/pluveto/Mathink");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This product is developed by Pluveto, based on WpfMath library. Dev by Pluveto.\n And thanks to the authors of WpfMath lib!");
        }

        private void buttonCopyClipboard_Click(object sender, EventArgs e)
        {
            var latex = txtIn.Text.Trim();
            string dataSVG;
            try
            {
                ( dataSVG, imgOut) = renderLatex(latex, false);
            }
            catch (Exception ex)
            {
                slErr.Text = "Error: " + ex.Message;
                return;
            }
            byte[] bytes = Encoding.UTF8.GetBytes(dataSVG);
            MemoryStream stream = new MemoryStream(bytes);
            Clipboard.SetData("image/svg+xml", stream);

            slErr.Text = string.Empty;
            slRet.Text = "Copy to clipboard successfully";
        }
    }
}