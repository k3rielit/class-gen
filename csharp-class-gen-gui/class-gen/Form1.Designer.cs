namespace class_gen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddMethodTypeMod = new System.Windows.Forms.ComboBox();
            this.AddMethodAcc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddMethod = new System.Windows.Forms.Button();
            this.ResetMethod = new System.Windows.Forms.Button();
            this.AddMethodAsync = new System.Windows.Forms.CheckBox();
            this.AddMethodName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddMethodType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddItemSet = new System.Windows.Forms.CheckBox();
            this.AddItemGet = new System.Windows.Forms.CheckBox();
            this.AddItemAcc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.AddItemUsage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddItemTypeMod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConstrAuto = new System.Windows.Forms.CheckBox();
            this.InclConstr = new System.Windows.Forms.CheckBox();
            this.ClassNameLBL = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.namespaceLBL = new System.Windows.Forms.Label();
            this.ClassNamespace = new System.Windows.Forms.TextBox();
            this.SeparateFIle = new System.Windows.Forms.CheckBox();
            this.NamespaceList = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RemoveAll = new System.Windows.Forms.Button();
            this.ExportCode = new System.Windows.Forms.Button();
            this.RemoveOne = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 389);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.AddMethodTypeMod);
            this.groupBox3.Controls.Add(this.AddMethodAcc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.AddMethod);
            this.groupBox3.Controls.Add(this.ResetMethod);
            this.groupBox3.Controls.Add(this.AddMethodAsync);
            this.groupBox3.Controls.Add(this.AddMethodName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.AddMethodType);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(0, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add method";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Type modifier";
            // 
            // AddMethodTypeMod
            // 
            this.AddMethodTypeMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddMethodTypeMod.FormattingEnabled = true;
            this.AddMethodTypeMod.Items.AddRange(new object[] {
            "None",
            "List",
            "Array",
            "Dictionary"});
            this.AddMethodTypeMod.Location = new System.Drawing.Point(226, 43);
            this.AddMethodTypeMod.Name = "AddMethodTypeMod";
            this.AddMethodTypeMod.Size = new System.Drawing.Size(94, 24);
            this.AddMethodTypeMod.TabIndex = 14;
            // 
            // AddMethodAcc
            // 
            this.AddMethodAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddMethodAcc.FormattingEnabled = true;
            this.AddMethodAcc.Items.AddRange(new object[] {
            "public",
            "private",
            "protected",
            "internal",
            "protected internal"});
            this.AddMethodAcc.Location = new System.Drawing.Point(83, 43);
            this.AddMethodAcc.Name = "AddMethodAcc";
            this.AddMethodAcc.Size = new System.Drawing.Size(143, 24);
            this.AddMethodAcc.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Accessibility";
            // 
            // AddMethod
            // 
            this.AddMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMethod.Location = new System.Drawing.Point(642, 73);
            this.AddMethod.Name = "AddMethod";
            this.AddMethod.Size = new System.Drawing.Size(62, 33);
            this.AddMethod.TabIndex = 11;
            this.AddMethod.Text = "Add";
            this.AddMethod.UseVisualStyleBackColor = true;
            this.AddMethod.Click += new System.EventHandler(this.AddMethod_Click);
            // 
            // ResetMethod
            // 
            this.ResetMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetMethod.Location = new System.Drawing.Point(710, 73);
            this.ResetMethod.Name = "ResetMethod";
            this.ResetMethod.Size = new System.Drawing.Size(62, 33);
            this.ResetMethod.TabIndex = 10;
            this.ResetMethod.Text = "Reset";
            this.ResetMethod.UseVisualStyleBackColor = true;
            this.ResetMethod.Click += new System.EventHandler(this.ResetMethod_Click);
            // 
            // AddMethodAsync
            // 
            this.AddMethodAsync.AutoSize = true;
            this.AddMethodAsync.Location = new System.Drawing.Point(13, 45);
            this.AddMethodAsync.Name = "AddMethodAsync";
            this.AddMethodAsync.Size = new System.Drawing.Size(64, 21);
            this.AddMethodAsync.TabIndex = 7;
            this.AddMethodAsync.Text = "async";
            this.AddMethodAsync.UseVisualStyleBackColor = true;
            // 
            // AddMethodName
            // 
            this.AddMethodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddMethodName.Location = new System.Drawing.Point(472, 44);
            this.AddMethodName.Name = "AddMethodName";
            this.AddMethodName.Size = new System.Drawing.Size(300, 23);
            this.AddMethodName.TabIndex = 6;
            this.AddMethodName.TextChanged += new System.EventHandler(this.AddMethodName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type (can be custom)";
            // 
            // AddMethodType
            // 
            this.AddMethodType.FormattingEnabled = true;
            this.AddMethodType.Items.AddRange(new object[] {
            "void",
            "sbyte",
            "byte",
            "short",
            "ushort",
            "int",
            "uint",
            "long",
            "ulong",
            "float",
            "double",
            "bool",
            "char",
            "string"});
            this.AddMethodType.Location = new System.Drawing.Point(320, 43);
            this.AddMethodType.Name = "AddMethodType";
            this.AddMethodType.Size = new System.Drawing.Size(152, 24);
            this.AddMethodType.TabIndex = 2;
            this.AddMethodType.Text = "void";
            this.AddMethodType.TextChanged += new System.EventHandler(this.AddMethodType_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddItemSet);
            this.groupBox2.Controls.Add(this.AddItemGet);
            this.groupBox2.Controls.Add(this.AddItemAcc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.AddItem);
            this.groupBox2.Controls.Add(this.AddItemUsage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AddItemTypeMod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AddItemName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ResetAddItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddItemType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(0, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add property/field";
            // 
            // AddItemSet
            // 
            this.AddItemSet.AutoSize = true;
            this.AddItemSet.Checked = true;
            this.AddItemSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddItemSet.Location = new System.Drawing.Point(232, 73);
            this.AddItemSet.Name = "AddItemSet";
            this.AddItemSet.Size = new System.Drawing.Size(46, 21);
            this.AddItemSet.TabIndex = 13;
            this.AddItemSet.Text = "set";
            this.toolTip1.SetToolTip(this.AddItemSet, "Autoproperties must have get accessors. Encapsulations must have at lest one acce" +
        "ssor.");
            this.AddItemSet.UseVisualStyleBackColor = true;
            this.AddItemSet.CheckedChanged += new System.EventHandler(this.AddItemGetSet_CheckedChanged);
            // 
            // AddItemGet
            // 
            this.AddItemGet.AutoSize = true;
            this.AddItemGet.Checked = true;
            this.AddItemGet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddItemGet.Location = new System.Drawing.Point(179, 73);
            this.AddItemGet.Name = "AddItemGet";
            this.AddItemGet.Size = new System.Drawing.Size(47, 21);
            this.AddItemGet.TabIndex = 12;
            this.AddItemGet.Text = "get";
            this.toolTip1.SetToolTip(this.AddItemGet, "Autoproperties must have get accessors. Encapsulations must have at lest one acce" +
        "ssor.");
            this.AddItemGet.UseVisualStyleBackColor = true;
            this.AddItemGet.CheckedChanged += new System.EventHandler(this.AddItemGetSet_CheckedChanged);
            // 
            // AddItemAcc
            // 
            this.AddItemAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddItemAcc.FormattingEnabled = true;
            this.AddItemAcc.Items.AddRange(new object[] {
            "public",
            "private",
            "protected",
            "internal",
            "protected internal"});
            this.AddItemAcc.Location = new System.Drawing.Point(13, 43);
            this.AddItemAcc.Name = "AddItemAcc";
            this.AddItemAcc.Size = new System.Drawing.Size(143, 24);
            this.AddItemAcc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Accessibility";
            // 
            // AddItem
            // 
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Location = new System.Drawing.Point(642, 76);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(62, 33);
            this.AddItem.TabIndex = 9;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // AddItemUsage
            // 
            this.AddItemUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddItemUsage.DropDownWidth = 170;
            this.AddItemUsage.FormattingEnabled = true;
            this.AddItemUsage.Items.AddRange(new object[] {
            "Autoproperty",
            "Field",
            "Encapsulated field (simple)",
            "Encapsulated field (full)"});
            this.AddItemUsage.Location = new System.Drawing.Point(156, 43);
            this.AddItemUsage.Name = "AddItemUsage";
            this.AddItemUsage.Size = new System.Drawing.Size(143, 24);
            this.AddItemUsage.TabIndex = 8;
            this.AddItemUsage.TextChanged += new System.EventHandler(this.AddItemUsage_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type modifier";
            // 
            // AddItemTypeMod
            // 
            this.AddItemTypeMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddItemTypeMod.FormattingEnabled = true;
            this.AddItemTypeMod.Items.AddRange(new object[] {
            "None",
            "List",
            "Array",
            "Dictionary"});
            this.AddItemTypeMod.Location = new System.Drawing.Point(299, 43);
            this.AddItemTypeMod.Name = "AddItemTypeMod";
            this.AddItemTypeMod.Size = new System.Drawing.Size(94, 24);
            this.AddItemTypeMod.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usage";
            // 
            // AddItemName
            // 
            this.AddItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddItemName.Location = new System.Drawing.Point(545, 44);
            this.AddItemName.Name = "AddItemName";
            this.AddItemName.Size = new System.Drawing.Size(227, 23);
            this.AddItemName.TabIndex = 4;
            this.AddItemName.TextChanged += new System.EventHandler(this.AddItemName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // ResetAddItem
            // 
            this.ResetAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetAddItem.Location = new System.Drawing.Point(710, 76);
            this.ResetAddItem.Name = "ResetAddItem";
            this.ResetAddItem.Size = new System.Drawing.Size(62, 33);
            this.ResetAddItem.TabIndex = 2;
            this.ResetAddItem.Text = "Reset";
            this.ResetAddItem.UseVisualStyleBackColor = true;
            this.ResetAddItem.Click += new System.EventHandler(this.ResetAddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type (can be custom)";
            // 
            // AddItemType
            // 
            this.AddItemType.FormattingEnabled = true;
            this.AddItemType.Items.AddRange(new object[] {
            "sbyte",
            "byte",
            "short",
            "ushort",
            "int",
            "uint",
            "long",
            "ulong",
            "float",
            "double",
            "bool",
            "char",
            "string"});
            this.AddItemType.Location = new System.Drawing.Point(393, 43);
            this.AddItemType.Name = "AddItemType";
            this.AddItemType.Size = new System.Drawing.Size(152, 24);
            this.AddItemType.TabIndex = 0;
            this.AddItemType.Text = "int";
            this.toolTip1.SetToolTip(this.AddItemType, resources.GetString("AddItemType.ToolTip"));
            this.AddItemType.TextChanged += new System.EventHandler(this.AddItemType_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConstrAuto);
            this.groupBox1.Controls.Add(this.InclConstr);
            this.groupBox1.Controls.Add(this.ClassNameLBL);
            this.groupBox1.Controls.Add(this.ClassName);
            this.groupBox1.Controls.Add(this.namespaceLBL);
            this.groupBox1.Controls.Add(this.ClassNamespace);
            this.groupBox1.Controls.Add(this.SeparateFIle);
            this.groupBox1.Controls.Add(this.NamespaceList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // ConstrAuto
            // 
            this.ConstrAuto.AutoSize = true;
            this.ConstrAuto.Checked = true;
            this.ConstrAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConstrAuto.Location = new System.Drawing.Point(166, 117);
            this.ConstrAuto.Name = "ConstrAuto";
            this.ConstrAuto.Size = new System.Drawing.Size(256, 21);
            this.ConstrAuto.TabIndex = 7;
            this.ConstrAuto.Text = "Constructor auto params and assign";
            this.toolTip1.SetToolTip(this.ConstrAuto, "Aumatically generate constructor parameters based on the fields/properties,\r\nand " +
        "automatically assign those parameters to the properties/fields inside the constr" +
        "uctor.");
            this.ConstrAuto.UseVisualStyleBackColor = true;
            this.ConstrAuto.CheckedChanged += new System.EventHandler(this.ConstrAuto_CheckedChanged);
            // 
            // InclConstr
            // 
            this.InclConstr.AutoSize = true;
            this.InclConstr.Checked = true;
            this.InclConstr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InclConstr.Location = new System.Drawing.Point(13, 117);
            this.InclConstr.Name = "InclConstr";
            this.InclConstr.Size = new System.Drawing.Size(147, 21);
            this.InclConstr.TabIndex = 6;
            this.InclConstr.Text = "Include constructor";
            this.InclConstr.UseVisualStyleBackColor = true;
            this.InclConstr.CheckedChanged += new System.EventHandler(this.InclConstr_CheckedChanged);
            // 
            // ClassNameLBL
            // 
            this.ClassNameLBL.AutoSize = true;
            this.ClassNameLBL.Location = new System.Drawing.Point(10, 90);
            this.ClassNameLBL.Name = "ClassNameLBL";
            this.ClassNameLBL.Size = new System.Drawing.Size(85, 17);
            this.ClassNameLBL.TabIndex = 5;
            this.ClassNameLBL.Text = "Class name:";
            // 
            // ClassName
            // 
            this.ClassName.BackColor = System.Drawing.SystemColors.Window;
            this.ClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassName.Location = new System.Drawing.Point(100, 88);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(335, 23);
            this.ClassName.TabIndex = 4;
            this.ClassName.Text = "Class1";
            this.ClassName.TextChanged += new System.EventHandler(this.ClassName_TextChanged);
            // 
            // namespaceLBL
            // 
            this.namespaceLBL.AutoSize = true;
            this.namespaceLBL.Location = new System.Drawing.Point(10, 52);
            this.namespaceLBL.Name = "namespaceLBL";
            this.namespaceLBL.Size = new System.Drawing.Size(87, 17);
            this.namespaceLBL.TabIndex = 3;
            this.namespaceLBL.Text = "Namespace:";
            // 
            // ClassNamespace
            // 
            this.ClassNamespace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassNamespace.Enabled = false;
            this.ClassNamespace.Location = new System.Drawing.Point(100, 50);
            this.ClassNamespace.Name = "ClassNamespace";
            this.ClassNamespace.Size = new System.Drawing.Size(335, 23);
            this.ClassNamespace.TabIndex = 2;
            this.ClassNamespace.TextChanged += new System.EventHandler(this.ClassNamespace_TextChanged);
            // 
            // SeparateFIle
            // 
            this.SeparateFIle.AutoSize = true;
            this.SeparateFIle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SeparateFIle.Location = new System.Drawing.Point(13, 22);
            this.SeparateFIle.Name = "SeparateFIle";
            this.SeparateFIle.Size = new System.Drawing.Size(145, 21);
            this.SeparateFIle.TabIndex = 1;
            this.SeparateFIle.Text = "Separate Class file";
            this.SeparateFIle.UseVisualStyleBackColor = true;
            this.SeparateFIle.CheckedChanged += new System.EventHandler(this.SeparateFIleCB_CheckedChanged);
            // 
            // NamespaceList
            // 
            this.NamespaceList.BackColor = System.Drawing.SystemColors.Control;
            this.NamespaceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamespaceList.CheckOnClick = true;
            this.NamespaceList.Dock = System.Windows.Forms.DockStyle.Right;
            this.NamespaceList.Enabled = false;
            this.NamespaceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NamespaceList.FormattingEnabled = true;
            this.NamespaceList.Items.AddRange(new object[] {
            "System.IO",
            "System.Linq",
            "System.Net",
            "System.Net.Http.Json",
            "System.Text",
            "System.Text.Json",
            "System.Collections",
            "System.Collections.Concurrent",
            "System.Collections.Generic",
            "System.Collections.Immutable",
            "System.Collections.Specialized",
            "System.Security.Cryptography",
            "System.Threading.Tasks",
            "System.Web",
            "System.Xaml",
            "System.Media"});
            this.NamespaceList.Location = new System.Drawing.Point(474, 19);
            this.NamespaceList.Name = "NamespaceList";
            this.NamespaceList.Size = new System.Drawing.Size(307, 126);
            this.NamespaceList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemList);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 172);
            this.panel2.TabIndex = 2;
            // 
            // ItemList
            // 
            this.ItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(0, 0);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(671, 172);
            this.ItemList.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RemoveAll);
            this.panel3.Controls.Add(this.ExportCode);
            this.panel3.Controls.Add(this.RemoveOne);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(671, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 172);
            this.panel3.TabIndex = 1;
            // 
            // RemoveAll
            // 
            this.RemoveAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveAll.ForeColor = System.Drawing.Color.Red;
            this.RemoveAll.Location = new System.Drawing.Point(0, 37);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(113, 37);
            this.RemoveAll.TabIndex = 3;
            this.RemoveAll.Text = "Remove All";
            this.RemoveAll.UseVisualStyleBackColor = true;
            this.RemoveAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // ExportCode
            // 
            this.ExportCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExportCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ExportCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportCode.Location = new System.Drawing.Point(0, 120);
            this.ExportCode.Name = "ExportCode";
            this.ExportCode.Size = new System.Drawing.Size(113, 52);
            this.ExportCode.TabIndex = 1;
            this.ExportCode.Text = "Export";
            this.ExportCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportCode.UseVisualStyleBackColor = true;
            this.ExportCode.Click += new System.EventHandler(this.ExportCode_Click);
            // 
            // RemoveOne
            // 
            this.RemoveOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveOne.Location = new System.Drawing.Point(0, 0);
            this.RemoveOne.Name = "RemoveOne";
            this.RemoveOne.Size = new System.Drawing.Size(113, 37);
            this.RemoveOne.TabIndex = 2;
            this.RemoveOne.Text = "Remove";
            this.RemoveOne.UseVisualStyleBackColor = true;
            this.RemoveOne.Click += new System.EventHandler(this.RemoveOne_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Class Generator";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RemoveOne;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox NamespaceList;
        private System.Windows.Forms.CheckBox SeparateFIle;
        private System.Windows.Forms.TextBox ClassNamespace;
        private System.Windows.Forms.Label namespaceLBL;
        private System.Windows.Forms.Button ExportCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddItemType;
        private System.Windows.Forms.Button ResetAddItem;
        private System.Windows.Forms.TextBox AddItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AddItemTypeMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddItemUsage;
        private System.Windows.Forms.Label ClassNameLBL;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AddMethodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AddMethodType;
        private System.Windows.Forms.CheckBox InclConstr;
        private System.Windows.Forms.CheckBox AddMethodAsync;
        private System.Windows.Forms.Button AddMethod;
        private System.Windows.Forms.Button ResetMethod;
        private System.Windows.Forms.ComboBox AddMethodAcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AddItemAcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RemoveAll;
        private System.Windows.Forms.CheckBox ConstrAuto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AddMethodTypeMod;
        private System.Windows.Forms.CheckBox AddItemSet;
        private System.Windows.Forms.CheckBox AddItemGet;
    }
}

