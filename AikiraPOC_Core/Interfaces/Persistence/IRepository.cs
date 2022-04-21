using AikiraPOC_Core.Entities;
using AikiraPOC_Core.Entities.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AikiraPOC_Core.Interfaces.Persistence
{
    public interface IRepository //where T : FileInfoEntity //where T : BaseEntity
    {
        //string strconnection { get; set; }
                
        dynamic GetFileInfo(FileInfoRequestModel fileInfoRequestModel);
    }
}
