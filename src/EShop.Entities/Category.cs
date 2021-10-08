﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Entities
{
    public class Category : BaseEntity
    {
        #region Fields

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public int? ParentId { get; set; }

        #endregion

        #region Relations

        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Children { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        #endregion
    }
}