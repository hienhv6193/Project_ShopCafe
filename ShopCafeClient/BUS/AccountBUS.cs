using ShopCafeClient.DAO;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopCafeClient.BUS
{
    internal class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new AccountBUS(); }
                return AccountBUS.instance;
            }
            private set { AccountBUS.instance = value; }
        }
        public List<Account> GetAll()
        {
            List<Account> list = AccountDAO.Instance.SelectAll();
            return list;
        }

        public List<Account> Search(String key)
        {
            List<Account> list = AccountDAO.Instance.SelectByKeyWord(key);
            return list;
        }

        public Account GetDetails(int id)
        {
            Account backpack = AccountDAO.Instance.SelectedByCode(id);
            return backpack;
        }

        public bool AddNew(Account account)
        {
            bool result = AccountDAO.Instance.Insert(account);
            return result;
        }

        public bool Update(Account account)
        {
            bool result = AccountDAO.Instance.Update(account);
            return result;
        }


        public bool Delete(int Username)
        {
            bool result = AccountDAO.Instance.Delete(Username);
            return result;
        }
    }
}
