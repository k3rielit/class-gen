using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_gen {
    public partial class Form1 : Form {
        public static AddClass addclass = new AddClass();
        public Form1() {
            InitializeComponent();
            DefaultSetType();
            DefaultAddItem();
            DefaultAddMethod();
        }
        public void DefaultSetType() {
            SeparateFIle.Checked = false;
            ClassNamespace.Text = "";
            ClassNamespace.Enabled = false;
            ClassName.Text = "Class1";
            InclConstr.Checked = true;
            ConstrAuto.Checked = true;
            NamespaceList.Enabled = false;
        }
        public void DefaultAddItem() {
            AddItemAcc.Text = "public";
            AddItemUsage.Text = "Autoproperty";
            AddItemTypeMod.Text = "None";
            AddItemType.Text = "int";
            AddItemName.Text = "";
        }
        public void DefaultAddMethod() {
            AddMethodAsync.Checked = false;
            AddMethodAcc.Text = "public";
            AddMethodTypeMod.Text = "None";
            AddMethodTypeMod.Enabled = false;
            AddMethodType.Text = "void";
            AddMethodName.Text = "";
        }
        private void ResetAddItem_Click(object sender, EventArgs e) => DefaultAddItem();
        private void ResetMethod_Click(object sender, EventArgs e) => DefaultAddMethod();
        private void SeparateFIleCB_CheckedChanged(object sender, EventArgs e) {
            ClassNamespace.Enabled = SeparateFIle.Checked;
            NamespaceList.Enabled = SeparateFIle.Checked;
            addclass.SeparateFile = SeparateFIle.Checked;
        }
        private void ClassNamespace_TextChanged(object sender, EventArgs e) {
            addclass.ClassNamespace = addclass.CheckName(ClassNamespace.Text,"") ? ClassNamespace.Text.Trim() : addclass.ClassNamespace;
            ClassNamespace.ForeColor = addclass.CheckName(ClassNamespace.Text,"") ? Color.Black : Color.Red;
        }
        private void ClassName_TextChanged(object sender, EventArgs e) {
            addclass.ClassName = addclass.CheckName(ClassName.Text,"") ? ClassName.Text.Trim() : addclass.ClassName;
            ClassName.ForeColor = addclass.CheckName(ClassName.Text,"") ? Color.Black : Color.Red;
        }
        private void InclConstr_CheckedChanged(object sender, EventArgs e) {
            ConstrAuto.Enabled = InclConstr.Checked;
            addclass.InclConstr = InclConstr.Checked;
        }
        private void ConstrAuto_CheckedChanged(object sender, EventArgs e) => addclass.ConstrAuto = ConstrAuto.Checked;
        private void AddItemName_TextChanged(object sender, EventArgs e) => AddItemName.ForeColor = addclass.CheckName(AddItemName.Text,"item") ? Color.Black : Color.Red;
        private void AddMethodName_TextChanged(object sender, EventArgs e) => AddMethodName.ForeColor = addclass.CheckName(AddMethodName.Text,"method") ? Color.Black : Color.Red;
        private void AddItemType_TextChanged(object sender, EventArgs e) => AddItemType.ForeColor = addclass.CheckName(AddItemType.Text,"") ? Color.Black : Color.Red;
        private void AddMethodType_TextChanged(object sender, EventArgs e) {
            AddMethodType.ForeColor = addclass.CheckName(AddMethodType.Text,"") ? Color.Black : Color.Red;
            AddMethodTypeMod.Enabled = AddMethodType.Text!="void";
        }
        private void AddItem_Click(object sender, EventArgs e) {
            if(addclass.CheckName(AddItemName.Text,"item") && addclass.CheckName(AddItemType.Text,"item") && !(AddItemUsage.Text.StartsWith("Encapsulated field") && (!AddItemGet.Checked && !AddItemSet.Checked))) {
                addclass.AddFieldProperty(AddItemAcc.Text, AddItemUsage.Text, AddItemGet.Checked, AddItemSet.Checked, AddItemTypeMod.Text, AddItemType.Text.Trim(), AddItemName.Text.Trim());
                RefreshList();
                DefaultAddItem();
            }
        }
        private void AddMethod_Click(object sender, EventArgs e) {
            if(addclass.CheckName(AddMethodName.Text,"method") && addclass.CheckName(AddMethodType.Text,"method")) {
                addclass.AddMethod(AddMethodAsync.Checked, AddMethodAcc.Text, AddMethodTypeMod.Text, AddMethodType.Text.Trim(), AddMethodName.Text.Trim());
                RefreshList();
                DefaultAddMethod();
            }
        }
        private void ExportCode_Click(object sender, EventArgs e) {
            if((!addclass.SeparateFile && addclass.CheckName(ClassName.Text,"")) || (addclass.CheckName(ClassNamespace.Text,"") && addclass.CheckName(ClassName.Text,"")) ) {
                addclass.ClassNamespaces = new List<string>() { "System" };
                foreach (string item in NamespaceList.CheckedItems) {
                    addclass.ClassNamespaces.Add(item);
                }
                SaveForm saveform = new SaveForm();
                saveform.ShowDialog();
            }
            else {
                MessageBox.Show("Incorrect, or no characters in one or more names.");
            }
        }
        private void RemoveOne_Click(object sender, EventArgs e) {
            addclass.Remove(ItemList.SelectedIndex, ItemList.SelectedIndex > addclass.FieldsProps.Count());
            RefreshList();
        }
        private void RemoveAll_Click(object sender, EventArgs e) {
            if ((addclass.FieldsProps.Count()>0 || addclass.Methods.Count()>0) && MessageBox.Show("Every field, property, and method will be dropped. Are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                addclass.RemoveAll();
            }
            RefreshList();
        }
        private void RefreshList() {
            ItemList.Items.Clear();
            foreach(string item in addclass.FieldsProps.Select(s => $"[{s.Usage.ToUpper()}] {s.Access} {s.GetPropType()} {s.Name}")) {
                ItemList.Items.Add(item);
            }
            foreach(string item in addclass.Methods.Select(s => $"[METHOD] {(s.IsAsync ? "async " : "")}{s.Access} {s.GetMethodType()} {s.Name}")) {
                ItemList.Items.Add(item);
            }
        }
        private void AddItemUsage_TextChanged(object sender, EventArgs e) {
            AddItemGet.Enabled = AddItemUsage.Text!="Field" && AddItemUsage.Text!="Autoproperty";
            AddItemSet.Enabled = AddItemUsage.Text!="Field";
        }
        private void AddItemGetSet_CheckedChanged(object sender, EventArgs e) {
            AddItemGet.ForeColor = AddItemGet.Checked || AddItemSet.Checked ? Color.Black : Color.Red;
            AddItemSet.ForeColor = AddItemGet.Checked || AddItemSet.Checked ? Color.Black : Color.Red;
        }
    }
}
