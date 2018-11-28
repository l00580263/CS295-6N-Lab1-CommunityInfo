using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class PersonEntry
    {
        #region Properties
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string ImageURL { get; set; }
        [Required]
        public string Description { get; set; }
        #endregion
    }
}
