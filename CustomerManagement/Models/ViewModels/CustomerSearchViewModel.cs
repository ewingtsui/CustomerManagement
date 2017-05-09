using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManagement.Models.ViewModels
{
    public class CustomerSearchViewModel
    {
        public string 客戶名稱 { get; set; }
        public string 統一編號 { get; set; }
        public string 地址 { get; set; }
        public string Email { get; set; }
    }
}