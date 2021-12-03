using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SoftJail.Common;

namespace SoftJail.Data.Models
{
    public class Department
    {
        public Department()
        {
            this.Cells = new HashSet<Cell>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DEPARTMENT_NAME_MAX_LENGTH)]
        public string Name{ get; set; }

        public virtual ICollection<Cell> Cells { get; set; }

    }
}


