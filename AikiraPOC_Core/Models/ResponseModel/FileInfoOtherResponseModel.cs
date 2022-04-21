using System;
using System.Collections.Generic;
using System.Text;

namespace AikiraPOC_Core.Models.ResponseModel
{
    public class FileInfoOtherResponseModel
    {
        public FileInfoOtherResponseModel()
        {
            this.DynamicProperties = new List<Dictionary<string, object>>();
        }

        public List<Dictionary<string, object>> DynamicProperties { get; set; }
    }
}
