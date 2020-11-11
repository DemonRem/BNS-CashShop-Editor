using System.Collections.Generic;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor.Helper
{
    class dbDataBuilder
    {
        public List<Category> _category;
        public List<CategoryDisplay> _categoryDisplays;
        public List<Goods> _goods;
        public List<GoodsDisplay> _goodsDisplays;
        public List<GoodsItems> _goodsItems;
        public List<GoodsCategory> _goodsCategories;
        public List<GoodsSalePricePolicy> _goodsSalePricePolicies;
        public List<Items> _items;
        public List<ItemDisplay> _itemDisplays;

        private SqlConnection _conn;

        public dbDataBuilder(SqlConnection conn)
        {
            this._conn = conn;
            loadCategoryData();
            LoadItemBuilders();
        }

        private void loadCategoryData()
        {
            BuildCategory();
            BuildCategoryDisplay();
        }

        private void LoadItemBuilders()
        {
            BuildGoods();
            BuildGoodsDisplay();
            BuildGoodsItems();
            BuildGoodsCategory();
            BuildGoodsSalePricePolicy();
            BuildItems();
            BuildItemDisplay();
        }

        private void BuildCategory()
        {
            _category = new List<Category>();

            var _data = dbHelper.GetTableData("Categories", _conn);
            int _count = _data.Count / 10;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var cat = new Category();

                cat.CategoryID = int.Parse(_data[_indx++]);
                cat.CategoryName = _data[_indx++];
                cat.AppGroupCode = _data[_indx++];
                cat.IsDisplayable = _data[_indx++] == "True" ? 1 : 0;
                cat.DisplayOrder = int.Parse(_data[_indx++]);
                cat.Changed = _data[_indx++];
                cat.ChangerAdminAccount = _data[_indx++];
                cat.CurrencyGroupId = _data[_indx++];
                cat.ParentCategory = _data[_indx++];
                cat.CategoryData = _data[_indx++];
                _category.Add(cat);

                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildCategoryDisplay()
        {
            _categoryDisplays = new List<CategoryDisplay>();

            var _data = dbHelper.GetTableData("CategoryDisplay", "LanguageCode", "11", _conn);
            int _count = _data.Count / 4;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var catd = new CategoryDisplay();
                catd.CategoryID = int.Parse(_data[_indx++]);
                catd.LanguageCode = int.Parse(_data[_indx++]);
                catd.CategoryDisplayName = _data[_indx++];
                catd.CategoryDisplayDescription = _data[_indx++];
                _categoryDisplays.Add(catd);

                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildGoods()
        {
            _goods = new List<Goods>();

            var _data = dbHelper.GetTableData("Goods", _conn);
            int _count = _data.Count / 19;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _g = new Goods();

                _g.GoodsID = int.Parse(_data[_indx++]);
                _g.GoodsName = _data[_indx++];
                _g.GoodsAppGroupCode = _data[_indx++];
                _g.GoodsType = int.Parse(_data[_indx++]);
                _g.DeliveryType = int.Parse(_data[_indx++]);
                _g.SaleStatus = int.Parse(_data[_indx++]);
                _g.EffectiveFrom = _data[_indx++];
                _g.EffectiveTo = _data[_indx++];
                _g.SaleableQuantity = int.Parse(_data[_indx++]);
                _g.RefundUnitCode = int.Parse(_data[_indx++]);
                _g.IsRefundable = _data[_indx++] == "True" ? 1 : 0;
                _g.IsAvailableRecurringPayment = _data[_indx++] == "True" ? 1 : 0;
                _g.Changed = _data[_indx++];
                _g.ChangerAdminAccount = _data[_indx++];
                _g.GoodsDescription = _data[_indx++];
                _g.GoodsData = _data[_indx++];
                _g.ParentGoodsID = _data[_indx++];
                _g.GoodsPurchaseType = int.Parse(_data[_indx++]);
                _g.SelectableItemQuantity = _data[_indx++];
                _g.GoodsPurchaseCheckMask = int.Parse(_data[_indx++]);
                _goods.Add(_g);
                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildGoodsDisplay()
        {
            _goodsDisplays = new List<GoodsDisplay>();

            var _data = dbHelper.GetTableData("GoodsDisplay", _conn);
            int _count = _data.Count / 4;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _gd = new GoodsDisplay();
                _gd.GoodsID = int.Parse(_data[_indx++]);
                _gd.LanguageCode = int.Parse(_data[_indx++]);
                _gd.GoodsDisplayName = _data[_indx++];
                _gd.GoodsDisplayDescription = _data[_indx++];
                _goodsDisplays.Add(_gd);
                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildGoodsItems()
        {
            _goodsItems = new List<GoodsItems>();

            var _data = dbHelper.GetTableData("GoodsItems", _conn);
            int _count = _data.Count / 9;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _gi = new GoodsItems();
                _gi.GoodsId = int.Parse(_data[_indx++]);
                _gi.ItemId = int.Parse(_data[_indx++]);
                _gi.ItemQuantity = int.Parse(_data[_indx++]);
                _gi.ItemExpirationType = int.Parse(_data[_indx++]);
                _gi.ItemExpireAt = _data[_indx++];
                _gi.ItemExpirationDuration = _data[_indx++];
                _gi.ItemData = _data[_indx++];
                _gi.DeliveryPriority = int.Parse(_data[_indx++]);
                _gi.LimitedGameServerMask = _data[_indx++];
                _gi.IsSelectableItem = _data[_indx++];
                _goodsItems.Add(_gi);
                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildGoodsCategory()
        {
            _goodsCategories = new List<GoodsCategory>();

            var _data = dbHelper.GetTableData("GoodsCategories", _conn);
            int _count = _data.Count / 4;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _gc = new GoodsCategory();
                _gc.GoodsId = int.Parse(_data[_indx++]);
                _gc.CategoryId = int.Parse(_data[_indx++]);
                _gc.DisplayOrder = int.Parse(_data[_indx++]);
                _goodsCategories.Add(_gc);
                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildGoodsSalePricePolicy()
        {
            _goodsSalePricePolicies = new List<GoodsSalePricePolicy>();

            var _data = dbHelper.GetTableData("GoodsSalePricePolicies", _conn);
            int _count = _data.Count / 14;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _gp = new GoodsSalePricePolicy();
                _gp.GoodsId = int.Parse(_data[_indx++]);
                _gp.CurrencyGroupId = int.Parse(_data[_indx++]);
                _gp.PricePolicyType = int.Parse(_data[_indx++]);
                _gp.EffectiveFrom = _data[_indx++];
                _gp.EffectiveTo = _data[_indx++];
                _gp.SalePrice = _data[_indx++];
                _gp.DiscountValueType = _data[_indx++];
                _gp.DiscountValue = _data[_indx++];
                _gp.DiscountKey = _data[_indx++];
                _gp.RewardValueType = _data[_indx++];
                _gp.RewardValue = _data[_indx++];
                _gp.RewardTargetKey = _data[_indx++];
                _gp.RewardTargetKeyType = _data[_indx++];
                _gp.GameGradeKey = _data[_indx++];
                _goodsSalePricePolicies.Add(_gp);
                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildItems()
        {
            _items = new List<Items>();

            var _data = dbHelper.GetTableData("Items", _conn);
            int _count = _data.Count / 9;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _i = new Items();
                _i.ItemId = int.Parse(_data[_indx++]);
                _i.ItemName = _data[_indx++];
                _i.ItemAppGroupCode = _data[_indx++];
                _i.ItemType = int.Parse(_data[_indx++]);
                _i.IsConsumable = _data[_indx++] == "True" ? 1 : 0;
                _i.BasicPrice = _data[_indx++];
                _i.BasicCurrencyGroupId = _data[_indx++];
                _i.Changed = _data[_indx++];
                _i.ChangerAdminAccount = _data[_indx++];
                _i.ItemDescription = _data[_indx++];
                _items.Add(_i);
                if (_indx + 1 > _data.Count) break;
            }
        }

        private void BuildItemDisplay()
        {
            _itemDisplays = new List<ItemDisplay>();

            var _data = dbHelper.GetTableData("ItemDisplay", _conn);
            int _count = _data.Count / 4;
            int _indx = 0;

            for (int i = 0; i < _count; i++)
            {
                var _ip = new ItemDisplay();
                _ip.ItemId = int.Parse(_data[_indx++]);
                _ip.LanguageCode = int.Parse(_data[_indx++]);
                _ip.ItemDisplayName = _data[_indx++];
                _ip.ItemDisplayDescription = _data[_indx++];
                _itemDisplays.Add(_ip);
                if (_indx + 1 > _data.Count) break;
            }
        }
    }
}
