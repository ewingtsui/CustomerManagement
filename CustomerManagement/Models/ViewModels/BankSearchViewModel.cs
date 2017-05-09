using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManagement.Models.ViewModels
{
    public class BankSearchViewModel
    {
        public string 銀行名稱 { get; set; }
        public Nullable<int> 銀行代碼 { get; set; }
        public Nullable<int> 分行代碼 { get; set; }
        public string 帳戶名稱 { get; set; }
        public string 帳戶號碼 { get; set; }
    }
}