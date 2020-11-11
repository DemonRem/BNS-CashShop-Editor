using BnS_Cash_Shop_Editor.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BnS_Cash_Shop_Editor
{
    public partial class Form1 : Form
    {
        //private SqlConnection                   _conn;
        private dbDataBuilder                   _dbDataBuilder;
        
        private Category                        _SelectedCategory;
        private CategoryDisplay                 _SelectedCategoryDisplay;

        #region /////////////Testing////////////
        private void btn_Test_Click(object sender, EventArgs e)
        {

            //testcategory.Add(conn);
        }

        private void btn_testRemove_Click(object sender, EventArgs e)
        {
            //testcategory.Remove(conn);
        }

        private void btn_testUpdate_Click(object sender, EventArgs e)
        {
            //testcategory.CategoryName = "sweat Shop";
            //testcategory.Update(conn);


        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.dbConnection.Close();
        }
        private void Init()
        {
            //_conn = dbHelper.dbConnect(DataSource: "192.168.1.27");
            //_conn = dbHelper.dbConnection;

            dbHelper.dbConnection.Open();

            _dbDataBuilder = new dbDataBuilder(dbHelper.dbConnection);

            CreateCategoryTree();
        }

        private void CreateCategoryTree()
        {
            tv_Category.Nodes.Clear();
            List<TreeNode> nodes = new List<TreeNode>();
            List<int> ChildOfNode = new List<int>();
            foreach (var cat in _dbDataBuilder._category)
            {
                var children = _dbDataBuilder._category.FindAll(x => (string.IsNullOrEmpty(x.ParentCategory) ? -1 : int.Parse(x.ParentCategory)) == cat.CategoryID);
                
                if (children.Count > 0)
                {
                    TreeNode[] _children = new TreeNode[children.Count];
                    for(int c = 0; c < children.Count; c++)
                    {
                        _children[c] = new TreeNode(_dbDataBuilder._categoryDisplays.Find(x => x.CategoryID == children[c].CategoryID).CategoryDisplayName);
                        ChildOfNode.Add(children[c].CategoryID);
                    }
                    nodes.Add(new TreeNode(_dbDataBuilder._categoryDisplays.Find(x => x.CategoryID == cat.CategoryID).CategoryDisplayName, _children));
                }
                else if(!ChildOfNode.Exists(x => x == cat.CategoryID))
                {
                    nodes.Add(new TreeNode(_dbDataBuilder._categoryDisplays.Find(x => x.CategoryID == cat.CategoryID).CategoryDisplayName));
                }
            }

            tv_Category.Nodes.AddRange(nodes.ToArray());
        }

   

        private void tv_Category_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tv_Category.SelectedNode == null) return;
                var _id = _dbDataBuilder._categoryDisplays.Find(x => x.CategoryDisplayName == tv_Category.SelectedNode.Text);
                var _data = _dbDataBuilder._category.Find(x => x.CategoryID == _id.CategoryID);

                tb_CategoryID.Text          = _data.CategoryID          .ToString();
                tb_CategoryName.Text        = _data.CategoryName        .ToString();
                tb_AppGroupCode.Text        = _data.AppGroupCode        .ToString();
                tb_IsDisplayable.Text       = _data.IsDisplayable       .ToString();
                tb_DisplayOrder.Text        = _data.DisplayOrder        .ToString();
                tb_Changed.Text             = _data.Changed             .ToString();
                tb_ChangerAdminAccount.Text = _data.ChangerAdminAccount .ToString();
                tb_CurrencyGroupId.Text     = _data.CurrencyGroupId     .ToString();
                tb_ParentCategory.Text      = _data.ParentCategory      .ToString();
                tb_CategoryData.Text        = _data.CategoryData        .ToString();

                tb_CatDescription.Text      = _id.CategoryDisplayDescription.ToString();

                tb_Add_Parent.Text = _data.CategoryID.ToString();

                _SelectedCategory = _data;
                _SelectedCategoryDisplay     = _id;

            }
            catch{}
        }

        private void btn_UpdateCategory_Click(object sender, EventArgs e)
        {   
            try
            {
                SetSelectedCategoryData();
                _SelectedCategory.Update(dbHelper.dbConnection);

                SetSelectedCategoryDisplay(_SelectedCategory.CategoryID, 11);
                _SelectedCategoryDisplay.Update(dbHelper.dbConnection);

                SetSelectedCategoryDisplay(_SelectedCategory.CategoryID, 1);
                _SelectedCategoryDisplay.Update(dbHelper.dbConnection);

                dbHelper.ClearCache(dbHelper.dbConnection.DataSource);
                CreateCategoryTree();
            }
            catch{}
        }

        private void btn_InsertCategory_Click(object sender, EventArgs e)
        {
            try
            {
                SetSelectedCategoryData();
                var ID = _SelectedCategory.Add(dbHelper.dbConnection);

                SetSelectedCategoryDisplay(ID,11);
                _SelectedCategoryDisplay.Add(dbHelper.dbConnection);

                SetSelectedCategoryDisplay(ID);
                _SelectedCategoryDisplay.Add(dbHelper.dbConnection);

                dbHelper.ClearCache(dbHelper.dbConnection.DataSource);
                CreateCategoryTree();
            }
            catch{}
        }

        private void SetSelectedCategoryDisplay(int ID,int langCode = 1)
        {
            _SelectedCategoryDisplay.CategoryID                  = ID;
            _SelectedCategoryDisplay.LanguageCode                = langCode;
            _SelectedCategoryDisplay.CategoryDisplayName         = tb_CategoryName.Text;
            _SelectedCategoryDisplay.CategoryDisplayDescription  = tb_CatDescription.Text;
        }

        private void SetSelectedCategoryData()
        {
            _SelectedCategory.CategoryID                 = int.Parse(tb_CategoryID.Text);
            _SelectedCategory.CategoryName               = tb_CategoryName.Text;
            _SelectedCategory.AppGroupCode               = tb_AppGroupCode.Text;
            _SelectedCategory.IsDisplayable              = int.Parse(tb_IsDisplayable.Text);
            _SelectedCategory.DisplayOrder               = int.Parse(tb_DisplayOrder.Text);
            _SelectedCategory.Changed                    = tb_Changed.Text;
            _SelectedCategory.ChangerAdminAccount        = tb_ChangerAdminAccount.Text;
            _SelectedCategory.CurrencyGroupId            = tb_CurrencyGroupId.Text;
            _SelectedCategory.ParentCategory             = tb_ParentCategory.Text;
            _SelectedCategory.CategoryData               = tb_CategoryData.Text;
        }

        private void btn_ReloadCategory_Click(object sender, EventArgs e)
        {
            dbHelper.ClearCache();
            CreateCategoryTree();
        }

        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                _SelectedCategoryDisplay.Remove(dbHelper.dbConnection);
                _SelectedCategory.Remove(dbHelper.dbConnection);

                dbHelper.ClearCache(dbHelper.dbConnection.DataSource);
                CreateCategoryTree();
            }
            catch{}
        }

        private void btn_Add_Add_Click(object sender, EventArgs e)
        {
            try{
                var _category = new Category();

                _category.CategoryName = tb_Add_Name.Text;
                _category.AppGroupCode = "bnsgrnTH";
                _category.IsDisplayable = 1;
                _category.DisplayOrder = 1;
                _category.ChangerAdminAccount = "CashShopEditor";
                _category.CurrencyGroupId = "71";
                _category.ParentCategory = tb_Add_Parent.Text;
                _category.CategoryData = "{\"CategoryType\":[\"01\"]}";

                var id = _category.Add(dbHelper.dbConnection);

                var _categoryDisplay = new CategoryDisplay();

                _categoryDisplay.CategoryID = id;
                _categoryDisplay.LanguageCode = 1;
                _categoryDisplay.CategoryDisplayName = tb_Add_Name.Text;
                _categoryDisplay.CategoryDisplayDescription = tb_Add_Desc.Text;

                _categoryDisplay.Add(dbHelper.dbConnection);

                _categoryDisplay.LanguageCode = 11;

                _categoryDisplay.Add(dbHelper.dbConnection);


                dbHelper.ClearCache(dbHelper.dbConnection.DataSource);
                CreateCategoryTree();
            }
            catch { }
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            dbLogin.instance.Show();
            this.Hide();
        }
    }
}
