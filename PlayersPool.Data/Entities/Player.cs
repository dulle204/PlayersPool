using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayersPool.Data
{
    [Table("Player")]
    public partial class Player
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(60)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public int ClubId { get; set; }

        public int CountryId { get; set; }

        public virtual Club Club { get; set; }

        public virtual Country Country { get; set; }
    }
}
