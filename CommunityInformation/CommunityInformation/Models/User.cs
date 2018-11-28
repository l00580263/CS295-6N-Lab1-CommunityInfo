using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class User
    {
        #region Fields
        #endregion


        #region Properties
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        #endregion
    }
}
