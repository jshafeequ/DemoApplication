
using example_empty.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace example_empty.ViewModel
{
    public class CreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Dept Department { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }
        //public string SelectedValue { get; set; }
        //public SelectList Values { get; set; }
    }

    }

