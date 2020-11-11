namespace BnS_Cash_Shop_Editor
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
            this.tv_Category = new System.Windows.Forms.TreeView();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_testRemove = new System.Windows.Forms.Button();
            this.btn_testUpdate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gb_Selection = new System.Windows.Forms.GroupBox();
            this.tb_CatDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_DeleteCategory = new System.Windows.Forms.Button();
            this.btn_InsertCategory = new System.Windows.Forms.Button();
            this.btn_UpdateCategory = new System.Windows.Forms.Button();
            this.tb_CategoryData = new System.Windows.Forms.TextBox();
            this.tb_ParentCategory = new System.Windows.Forms.TextBox();
            this.tb_CurrencyGroupId = new System.Windows.Forms.TextBox();
            this.tb_ChangerAdminAccount = new System.Windows.Forms.TextBox();
            this.tb_Changed = new System.Windows.Forms.TextBox();
            this.tb_DisplayOrder = new System.Windows.Forms.TextBox();
            this.tb_IsDisplayable = new System.Windows.Forms.TextBox();
            this.tb_AppGroupCode = new System.Windows.Forms.TextBox();
            this.tb_CategoryName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CategoryID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Add_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Add_Parent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Add_Name = new System.Windows.Forms.TextBox();
            this.tb_Add_Desc = new System.Windows.Forms.TextBox();
            this.btn_ReloadCategory = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_Selection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_Category
            // 
            this.tv_Category.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv_Category.Location = new System.Drawing.Point(3, 3);
            this.tv_Category.Name = "tv_Category";
            this.tv_Category.Size = new System.Drawing.Size(158, 617);
            this.tv_Category.TabIndex = 0;
            this.tv_Category.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Category_NodeMouseDoubleClick);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(11, 24);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 1;
            this.btn_Test.Text = "Test_Add";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_testRemove
            // 
            this.btn_testRemove.Location = new System.Drawing.Point(176, 24);
            this.btn_testRemove.Name = "btn_testRemove";
            this.btn_testRemove.Size = new System.Drawing.Size(87, 23);
            this.btn_testRemove.TabIndex = 2;
            this.btn_testRemove.Text = "Test_Remove";
            this.btn_testRemove.UseVisualStyleBackColor = true;
            this.btn_testRemove.Click += new System.EventHandler(this.btn_testRemove_Click);
            // 
            // btn_testUpdate
            // 
            this.btn_testUpdate.Location = new System.Drawing.Point(92, 24);
            this.btn_testUpdate.Name = "btn_testUpdate";
            this.btn_testUpdate.Size = new System.Drawing.Size(78, 23);
            this.btn_testUpdate.TabIndex = 3;
            this.btn_testUpdate.Text = "Test_Update";
            this.btn_testUpdate.UseVisualStyleBackColor = true;
            this.btn_testUpdate.Click += new System.EventHandler(this.btn_testUpdate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 649);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Settings);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gb_Selection);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_ReloadCategory);
            this.tabPage1.Controls.Add(this.tv_Category);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lb_Items);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(458, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 609);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category Content";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Location = new System.Drawing.Point(171, 138);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 83);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Remove Item";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 20);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(171, 227);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 186);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Item";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(171, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 116);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name";
            // 
            // lb_Items
            // 
            this.lb_Items.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.Location = new System.Drawing.Point(3, 16);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(162, 590);
            this.lb_Items.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Test);
            this.groupBox2.Controls.Add(this.btn_testUpdate);
            this.groupBox2.Controls.Add(this.btn_testRemove);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(167, 552);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 63);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // gb_Selection
            // 
            this.gb_Selection.Controls.Add(this.tb_CatDescription);
            this.gb_Selection.Controls.Add(this.label14);
            this.gb_Selection.Controls.Add(this.btn_DeleteCategory);
            this.gb_Selection.Controls.Add(this.btn_InsertCategory);
            this.gb_Selection.Controls.Add(this.btn_UpdateCategory);
            this.gb_Selection.Controls.Add(this.tb_CategoryData);
            this.gb_Selection.Controls.Add(this.tb_ParentCategory);
            this.gb_Selection.Controls.Add(this.tb_CurrencyGroupId);
            this.gb_Selection.Controls.Add(this.tb_ChangerAdminAccount);
            this.gb_Selection.Controls.Add(this.tb_Changed);
            this.gb_Selection.Controls.Add(this.tb_DisplayOrder);
            this.gb_Selection.Controls.Add(this.tb_IsDisplayable);
            this.gb_Selection.Controls.Add(this.tb_AppGroupCode);
            this.gb_Selection.Controls.Add(this.tb_CategoryName);
            this.gb_Selection.Controls.Add(this.label13);
            this.gb_Selection.Controls.Add(this.label12);
            this.gb_Selection.Controls.Add(this.label11);
            this.gb_Selection.Controls.Add(this.label10);
            this.gb_Selection.Controls.Add(this.label9);
            this.gb_Selection.Controls.Add(this.label8);
            this.gb_Selection.Controls.Add(this.label7);
            this.gb_Selection.Controls.Add(this.label6);
            this.gb_Selection.Controls.Add(this.label5);
            this.gb_Selection.Controls.Add(this.label4);
            this.gb_Selection.Controls.Add(this.tb_CategoryID);
            this.gb_Selection.Location = new System.Drawing.Point(167, 6);
            this.gb_Selection.Name = "gb_Selection";
            this.gb_Selection.Size = new System.Drawing.Size(285, 391);
            this.gb_Selection.TabIndex = 13;
            this.gb_Selection.TabStop = false;
            this.gb_Selection.Text = "Selection Data";
            // 
            // tb_CatDescription
            // 
            this.tb_CatDescription.Location = new System.Drawing.Point(126, 71);
            this.tb_CatDescription.Name = "tb_CatDescription";
            this.tb_CatDescription.Size = new System.Drawing.Size(147, 20);
            this.tb_CatDescription.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Description";
            // 
            // btn_DeleteCategory
            // 
            this.btn_DeleteCategory.Location = new System.Drawing.Point(6, 355);
            this.btn_DeleteCategory.Name = "btn_DeleteCategory";
            this.btn_DeleteCategory.Size = new System.Drawing.Size(87, 21);
            this.btn_DeleteCategory.TabIndex = 22;
            this.btn_DeleteCategory.Text = "Remove";
            this.btn_DeleteCategory.UseVisualStyleBackColor = true;
            this.btn_DeleteCategory.Click += new System.EventHandler(this.btn_DeleteCategory_Click);
            // 
            // btn_InsertCategory
            // 
            this.btn_InsertCategory.Location = new System.Drawing.Point(99, 355);
            this.btn_InsertCategory.Name = "btn_InsertCategory";
            this.btn_InsertCategory.Size = new System.Drawing.Size(180, 21);
            this.btn_InsertCategory.TabIndex = 21;
            this.btn_InsertCategory.Text = "Insert";
            this.btn_InsertCategory.UseVisualStyleBackColor = true;
            this.btn_InsertCategory.Click += new System.EventHandler(this.btn_InsertCategory_Click);
            // 
            // btn_UpdateCategory
            // 
            this.btn_UpdateCategory.Location = new System.Drawing.Point(6, 314);
            this.btn_UpdateCategory.Name = "btn_UpdateCategory";
            this.btn_UpdateCategory.Size = new System.Drawing.Size(273, 35);
            this.btn_UpdateCategory.TabIndex = 20;
            this.btn_UpdateCategory.Text = "Update";
            this.btn_UpdateCategory.UseVisualStyleBackColor = true;
            this.btn_UpdateCategory.Click += new System.EventHandler(this.btn_UpdateCategory_Click);
            // 
            // tb_CategoryData
            // 
            this.tb_CategoryData.Location = new System.Drawing.Point(126, 279);
            this.tb_CategoryData.Name = "tb_CategoryData";
            this.tb_CategoryData.Size = new System.Drawing.Size(147, 20);
            this.tb_CategoryData.TabIndex = 19;
            // 
            // tb_ParentCategory
            // 
            this.tb_ParentCategory.Location = new System.Drawing.Point(126, 253);
            this.tb_ParentCategory.Name = "tb_ParentCategory";
            this.tb_ParentCategory.Size = new System.Drawing.Size(147, 20);
            this.tb_ParentCategory.TabIndex = 18;
            // 
            // tb_CurrencyGroupId
            // 
            this.tb_CurrencyGroupId.Location = new System.Drawing.Point(126, 227);
            this.tb_CurrencyGroupId.Name = "tb_CurrencyGroupId";
            this.tb_CurrencyGroupId.Size = new System.Drawing.Size(147, 20);
            this.tb_CurrencyGroupId.TabIndex = 17;
            // 
            // tb_ChangerAdminAccount
            // 
            this.tb_ChangerAdminAccount.Location = new System.Drawing.Point(126, 201);
            this.tb_ChangerAdminAccount.Name = "tb_ChangerAdminAccount";
            this.tb_ChangerAdminAccount.ReadOnly = true;
            this.tb_ChangerAdminAccount.Size = new System.Drawing.Size(147, 20);
            this.tb_ChangerAdminAccount.TabIndex = 16;
            // 
            // tb_Changed
            // 
            this.tb_Changed.Location = new System.Drawing.Point(126, 175);
            this.tb_Changed.Name = "tb_Changed";
            this.tb_Changed.ReadOnly = true;
            this.tb_Changed.Size = new System.Drawing.Size(147, 20);
            this.tb_Changed.TabIndex = 15;
            // 
            // tb_DisplayOrder
            // 
            this.tb_DisplayOrder.Location = new System.Drawing.Point(126, 149);
            this.tb_DisplayOrder.Name = "tb_DisplayOrder";
            this.tb_DisplayOrder.Size = new System.Drawing.Size(147, 20);
            this.tb_DisplayOrder.TabIndex = 14;
            // 
            // tb_IsDisplayable
            // 
            this.tb_IsDisplayable.Location = new System.Drawing.Point(126, 123);
            this.tb_IsDisplayable.Name = "tb_IsDisplayable";
            this.tb_IsDisplayable.Size = new System.Drawing.Size(147, 20);
            this.tb_IsDisplayable.TabIndex = 13;
            // 
            // tb_AppGroupCode
            // 
            this.tb_AppGroupCode.Location = new System.Drawing.Point(126, 97);
            this.tb_AppGroupCode.Name = "tb_AppGroupCode";
            this.tb_AppGroupCode.Size = new System.Drawing.Size(147, 20);
            this.tb_AppGroupCode.TabIndex = 12;
            // 
            // tb_CategoryName
            // 
            this.tb_CategoryName.Location = new System.Drawing.Point(126, 45);
            this.tb_CategoryName.Name = "tb_CategoryName";
            this.tb_CategoryName.Size = new System.Drawing.Size(147, 20);
            this.tb_CategoryName.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "CategoryData";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "ParentCategory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "CurrencyGroupId";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "ChangerAdminAccount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Changed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "DisplayOrder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "IsDisplayable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "AppGroupCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CategoryName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CategoryID";
            // 
            // tb_CategoryID
            // 
            this.tb_CategoryID.Location = new System.Drawing.Point(126, 19);
            this.tb_CategoryID.Name = "tb_CategoryID";
            this.tb_CategoryID.Size = new System.Drawing.Size(147, 20);
            this.tb_CategoryID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Add_Add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Add_Parent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Add_Name);
            this.groupBox1.Controls.Add(this.tb_Add_Desc);
            this.groupBox1.Location = new System.Drawing.Point(167, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 143);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // btn_Add_Add
            // 
            this.btn_Add_Add.Location = new System.Drawing.Point(6, 97);
            this.btn_Add_Add.Name = "btn_Add_Add";
            this.btn_Add_Add.Size = new System.Drawing.Size(267, 40);
            this.btn_Add_Add.TabIndex = 14;
            this.btn_Add_Add.Text = "Add";
            this.btn_Add_Add.UseVisualStyleBackColor = true;
            this.btn_Add_Add.Click += new System.EventHandler(this.btn_Add_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Parent:";
            // 
            // tb_Add_Parent
            // 
            this.tb_Add_Parent.Location = new System.Drawing.Point(126, 19);
            this.tb_Add_Parent.Name = "tb_Add_Parent";
            this.tb_Add_Parent.Size = new System.Drawing.Size(147, 20);
            this.tb_Add_Parent.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // tb_Add_Name
            // 
            this.tb_Add_Name.Location = new System.Drawing.Point(126, 45);
            this.tb_Add_Name.Name = "tb_Add_Name";
            this.tb_Add_Name.Size = new System.Drawing.Size(147, 20);
            this.tb_Add_Name.TabIndex = 8;
            this.tb_Add_Name.Text = "[Unnamed]";
            // 
            // tb_Add_Desc
            // 
            this.tb_Add_Desc.Location = new System.Drawing.Point(126, 71);
            this.tb_Add_Desc.Name = "tb_Add_Desc";
            this.tb_Add_Desc.Size = new System.Drawing.Size(147, 20);
            this.tb_Add_Desc.TabIndex = 9;
            this.tb_Add_Desc.Text = "[None]";
            // 
            // btn_ReloadCategory
            // 
            this.btn_ReloadCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ReloadCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReloadCategory.Location = new System.Drawing.Point(72, 592);
            this.btn_ReloadCategory.Name = "btn_ReloadCategory";
            this.btn_ReloadCategory.Size = new System.Drawing.Size(85, 25);
            this.btn_ReloadCategory.TabIndex = 4;
            this.btn_ReloadCategory.Text = "Reload";
            this.btn_ReloadCategory.UseVisualStyleBackColor = true;
            this.btn_ReloadCategory.Click += new System.EventHandler(this.btn_ReloadCategory_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(850, 623);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Goods";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Settings.Location = new System.Drawing.Point(99, 561);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(58, 25);
            this.btn_Settings.TabIndex = 16;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 649);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BnS Cash shop Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gb_Selection.ResumeLayout(false);
            this.gb_Selection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Category;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_testRemove;
        private System.Windows.Forms.Button btn_testUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_ReloadCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Add_Parent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Add_Name;
        private System.Windows.Forms.TextBox tb_Add_Desc;
        private System.Windows.Forms.GroupBox gb_Selection;
        private System.Windows.Forms.TextBox tb_CategoryID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CategoryData;
        private System.Windows.Forms.TextBox tb_ParentCategory;
        private System.Windows.Forms.TextBox tb_CurrencyGroupId;
        private System.Windows.Forms.TextBox tb_ChangerAdminAccount;
        private System.Windows.Forms.TextBox tb_Changed;
        private System.Windows.Forms.TextBox tb_DisplayOrder;
        private System.Windows.Forms.TextBox tb_IsDisplayable;
        private System.Windows.Forms.TextBox tb_AppGroupCode;
        private System.Windows.Forms.TextBox tb_CategoryName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateCategory;
        private System.Windows.Forms.Button btn_InsertCategory;
        private System.Windows.Forms.Button btn_DeleteCategory;
        private System.Windows.Forms.TextBox tb_CatDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Add_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_Settings;
    }
}

