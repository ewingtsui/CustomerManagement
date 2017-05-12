namespace CustomerManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using ValidationAttributes;
    using CustomerManagement.Models;
    using System.Linq;


    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var cnt = db.客戶聯絡人.Where(p => p.Id != this.Id).Count(p => p.客戶Id == this.客戶Id && p.Email == this.Email);

            if (cnt > 0)
            {
                yield return new ValidationResult("同一客戶的聯絡人Email不能重覆", new string[] { "Email" });
            }

            yield break;
        }
    }
    
    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [手機驗證(ErrorMessage = "手機號碼格式錯誤,格式: XXXX-XXXXXX")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
