using System;

namespace T4ResX.Sample.WebSite.BLL.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {

        [RegularExpressionAttribute(T4ResX.Sample.Localization.Models.User.PseudoRegexConstant, ErrorMessageResourceName = "PseudoError", ErrorMessageResourceType = typeof(T4ResX.Sample.Localization.Models.User))]
        [Required( ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(T4ResX.Sample.Localization.Models.User))]
        public string Pseudo { get; set; }
    }
}