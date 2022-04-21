using AikiraPOC_Core.Entities;
using AikiraPOC_Core.Entities.Base;
using AikiraPOC_Core.Interfaces.Persistence;
using AikiraPOC_Core.Models.ResponseModel;
using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AikiraPOC_Infrastructure.CosmosDbData.Repository
{
    public class AiKiraDbRepository<T> : IRepository
    {      

        public dynamic GetFileInfo(FileInfoRequestModel fileInfoRequestModel)
        {
            dynamic jsonToReturn = null;
            try
            {
                string Connstr = Environment.GetEnvironmentVariable("sqldb_connection");
                var parameters = new DynamicParameters();
               // if (fileInfoRequestModel.intPSId > 0)
                   parameters.Add("@PsId", fileInfoRequestModel.intPSId, DbType.Int32, ParameterDirection.Input);
              //  else
               //     parameters.Add("@PsId", null, DbType.Int32, ParameterDirection.Input);
              //  if (fileInfoRequestModel.intProjectId > 0)
                    parameters.Add("@ProjectId", fileInfoRequestModel.intProjectId, DbType.Int32, ParameterDirection.Input);
              //  else
                 //   parameters.Add("@ProjectId", null, DbType.Int32, ParameterDirection.Input);
               // if (fileInfoRequestModel.intBatchId > 0)
                    parameters.Add("@BatchId", fileInfoRequestModel.intBatchId, DbType.Int32, ParameterDirection.Input);
               // else
                //    parameters.Add("@BatchId", null, DbType.Int32, ParameterDirection.Input);
               // if (fileInfoRequestModel.intFileId > 0)
                    parameters.Add("@FileId", fileInfoRequestModel.intFileId, DbType.Int32, ParameterDirection.Input);
                //else
                //    parameters.Add("@FileId", null, DbType.Int32, ParameterDirection.Input);
                string sqlQuery = "[dbo].[GetFileInfo]";
                if (fileInfoRequestModel.intPSId == 6)
                {
                    using (IDbConnection db = new SqlConnection(Connstr))
                    {
                        IList<FileInfoJournalResponseModel> result = db.Query<FileInfoJournalResponseModel>(sqlQuery, parameters, commandType: CommandType.StoredProcedure).AsList<FileInfoJournalResponseModel>();
                        jsonToReturn = JsonConvert.SerializeObject(result);
                    }
                }
                else if (fileInfoRequestModel.intPSId == 2)
                {
                    using (IDbConnection db = new SqlConnection(Connstr))
                    {
                        IList<FileInfoBookResponseModel> result = db.Query<FileInfoBookResponseModel>(sqlQuery, parameters, commandType: CommandType.StoredProcedure).AsList<FileInfoBookResponseModel>();
                        jsonToReturn = JsonConvert.SerializeObject(result);

                    }

                }
                else
                {
                    List<FileInfoOtherResponseModel> objFileInfoOtherResponseModel = new List<FileInfoOtherResponseModel>();
                    using (IDbConnection db = new SqlConnection(Connstr))
                    {
                        var result = db.Query(sqlQuery, parameters, commandType: CommandType.StoredProcedure);

                        foreach (var item in result.AsList())
                        {
                            FileInfoOtherResponseModel objLocalFileInfoOtherResponseModel = new FileInfoOtherResponseModel();
                            foreach (var localVar in item)
                            {
                                Dictionary<string, object> dict = new Dictionary<string, object>();
                                dict.Add(localVar.Key, localVar.Value);
                                objLocalFileInfoOtherResponseModel.DynamicProperties.Add(dict);
                            }
                            objFileInfoOtherResponseModel.Add(objLocalFileInfoOtherResponseModel);
                        }
                        jsonToReturn = JsonConvert.SerializeObject(objFileInfoOtherResponseModel);
                    }
                }
                return jsonToReturn;
            }
            catch (Exception ex)
            {
                string strMsg = ex.Message.ToString();
                jsonToReturn = JsonConvert.SerializeObject(strMsg);
                return jsonToReturn;
            }
          
        }
    }


}
