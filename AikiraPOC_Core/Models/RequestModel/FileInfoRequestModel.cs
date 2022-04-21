using AikiraPOC_Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AikiraPOC_Core.Entities
{
    public class FileInfoRequestModel : BaseEntity
    {
        public int intPSId { get; set; }
        public Int64? intProjectId { get; set; }
        public int? intBatchId { get; set; }
        public int? intFileId { get; set; }

    }
}
