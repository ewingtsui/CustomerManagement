using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerManagement.Models.ValidationAttributes
{
    public class 手機驗證Attribute : DataTypeAttribute
    {
        public 手機驗證Attribute() : base(DataType.Text)
        {
        }

        public override bool IsValid(object value)
        {
            var str = (string)value;
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"[0-9]{4}\-[0-9]{6}");
        }
    }
}