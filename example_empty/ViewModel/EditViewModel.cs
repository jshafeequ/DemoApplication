using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace example_empty.ViewModel
{
    public class EditViewModel:CreateViewModel
    {
        public int id { get; set; }
        [NotMapped]
        public string EncryptedId { get; set; }
        public string Existingphotopath { get; set; }
    }
}
