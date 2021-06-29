using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPYZU.Models.validators
{
    public class ValidationStrings
    {

        //public const string DateReg = @"^((?=.*\-.*\-)|(?=.*\..*\.)|(?=.*/.*/))(19|20)\d{2}[\-/\.]((0?[13578]|1[02])[\-/\.](0?[1-9]|[12]\d|3[01])|(0?[469]|11)[\-/\.](0?[1-9]|[12]\d|30)|(0?2)[\-/\.](0?[1-9]|[12]\d))$";
        //public const string DateErrMsg = "格式:yyyy-MM-dd(也可以用.或/作为分隔符,还需要注意年份必须是19XX或20XX)";

        public const string DateReg = @"^(19|20)\d{2}-(((0[13578]|1[02])-(0[1-9]|[12]\d|3[01]))|((0[469]|11)-(0[1-9]|[12]\d|30))|(02-(0[1-9]|[12]\d)))$";
        public const string DateErrMsg = "Format:yyyy-MM-dd，Pay attention- year, month, and day";

        public const string PwdReg = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\W_]).*$";
        public const string PwdErrMsg = "{0}Should contain uppercase letters、Lowercase letters, numbers and special characters!";

        public const string EmailReg = @"^\w+([\.\-]\w+)*@\w+(\.\w+)*\.[a-z]{2,3}$";
        public const string EmailErrMsg = "Email wrong format";

        public const string PhoneReg = @"^1[3-9]\d{9}|(0\d{2,3}\-?)?\d{7,8}$";
        public const string PhoneErrMsg = "{0}Must be an 11-digit mobile phone number or fixed phone number (with or without an area code)";

        public const string QQReg = @"^[1-9]\d{3,14}$";
        public const string QQErrMsg = "{0}Must be 4~15 digits";

        public const string ImgUrlReg = @"^.*\.(jpg|jpeg|png|PNG)$";
        public const string ImgUrlErrMsg = "{0}Must be a jpg, jpeg or png format file";

        public const string UniqueErrMsg = "{0}Can not be Same!";

        public const string RemoteArea = "Remote";

        public const string MaxLen = "{0}Cannot exceed {1} characters!";
        public const string MinLen = "{0} cannot be less than {1} characters!";
        public const string Unique = "{0} cannot be repeated!";
    }
}