using ProductCategories2019.Resource;
using System.ComponentModel.DataAnnotations;

namespace ProductCategories2019.Models
{
    internal class ProductsMetadata
    {
            [Required(ErrorMessageResourceType = typeof(WebResource),
            ErrorMessageResourceName ="ProductNameEmpty")]
            [Display(Name = "ProductName",ResourceType =typeof(WebResource))]
            [StringLength(0, ErrorMessage = "{0}最多{1}個字元")]
            public string ProductName { get; set; }



            [Display(Name = "商品單價")]
            [DisplayFormat(DataFormatString ="{0:C}")]
            public decimal? UnitPrice { get; set; }
            
            
            [Display(Name = "訂購單位")]
            [Range(1,100,ErrorMessage ="{0}必須介於{1},{2}之間")]
            public short? UnitsInStock { get; set; }

    }
}