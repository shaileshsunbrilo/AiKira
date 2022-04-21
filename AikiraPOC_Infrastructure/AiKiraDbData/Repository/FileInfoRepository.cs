using AikiraPOC_Core.Entities;
using AikiraPOC_Core.Interfaces.Persistence;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AikiraPOC_Infrastructure.CosmosDbData.Repository
{
    public class FileInfoRepository : AiKiraDbRepository<FileInfoRequestModel>, IFileInfoRepository
    {
        //private string strconn;

        //public FileInfoRepository(string strconnection)
        //{
        //    this.strconn = strconnection;
        //}
        //private readonly IFileInfoRepository _fileinfo;

        //public FileInfoRepository(IFileInfoRepository fileinfo)
        //{
        //    this._fileinfo = fileinfo;
        //}
        //public async System.Threading.Tasks.Task<IEnumerable> GetFileInfoAsync(int PSId)
        //{
        //    string Connstr = Environment.GetEnvironmentVariable("ConnectionStrings:TestAikiraConnection");
        //    //string cstr ="";
        //    var parameters = new DynamicParameters();
        //    parameters.Add("@PsId",PSId, DbType.Int32, ParameterDirection.Input);
        //    string sqlQuery = "[dbo].[GetFileInfo]";
        //    using (IDbConnection db = new SqlConnection(Connstr))
        //    {
        //        var result = await db.QueryAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
        //        //dynamic jsonToReturn = JsonConvert.SerializeObject(result);
        //        //return new JsonResult(jsonToReturn);
        //        return result;
        //    }
            
        //}

    }
}
