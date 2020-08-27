using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorBlog.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDBlog {get; set;}
        [Display(Name="Blog Title")]
        [StringLength(20)]
        [Required(ErrorMessage="{0} is a required field.")]
        public string BlogTitle {get; set;}
        [Display(Name="Blog Content")]
        [StringLength(200)]
        [Required(ErrorMessage="{0} is a required field.")]
        public string BlogContent {get; set;}
    }

}