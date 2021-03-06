namespace BoardgameCollectionWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoardgameImplementation")]
    public partial class BoardgameImplementation
    {
        public int BoardgameImplementationID { get; set; }

        public int LocalBoardgameID { get; set; }

        public int LocalImplementationID { get; set; }

        public virtual BoardGame BoardGame { get; set; }

        public virtual Implementation Implementation { get; set; }
    }
}
