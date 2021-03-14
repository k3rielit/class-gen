using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace class_gen {
    public partial class SaveForm : Form {
        public SaveForm() {
            InitializeComponent();
        }
        private void CopyToClipboard_Click(object sender, EventArgs e) {
            Clipboard.SetText(Form1.addclass.Export());
            Dispose();
        }
        private void SaveAs_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "C# files (*.cs)|*.cs";
            _ = save.CheckFileExists;
            if (save.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(save.FileName,Form1.addclass.Export());
                Dispose();
            }
        }
    }
}
