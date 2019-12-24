using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Products_N_Categories.Models {
    public class NewProductCategoryModel {
        public Category NewCategory { get; set; }
        public List<Category> Category { get; set; }

        public Product newProduct { get; set; }
        public List<Product> Productss { get; set; }

    }

}