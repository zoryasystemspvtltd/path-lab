using ILab.Extensionss.Data;
using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using PathlabApi.Data;

namespace ILab.Data
{
    public class PathLabDataService : ILabDataService
    {
        public readonly PathLabDataHandler dataHandler;
        public PathLabDataService(PathLabDataHandler handler
            , ILogger<PathLabDataService> logger)
            : base(handler, logger)
        {
            dataHandler = handler;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual ModuleIdentity Identity { get { return dataHandler.Identity; } set { dataHandler.Identity = value; } }
        public async Task<dynamic> GetUploadedfile(string module, long id)
        {
            var data = await Get(module, id);
            return data;

        }
        public override Type? GetType(string model)
        {
            var asm = typeof(PathLabDataService).Assembly;

            var type = asm.GetTypes()
                .FirstOrDefault(p => p.Name.Equals(model, StringComparison.OrdinalIgnoreCase)
                    && p.IsSubclassOf(typeof(LabModel)));

            if (type == null) { return null; }

            return type;
        }
       
        public override async Task<long> EditPartialAsync(string module, long id, dynamic data, CancellationToken token)
        {
            try
            {
                var type = GetType(module);
                if (type == null) { return -1; }

                var jsonString = data.ToString();
                var jsonData = JsonConvert.DeserializeObject(jsonString, type);

                var existingData = await Get(module, id);
                existingData.Member = jsonData.Member;
                existingData.Status = jsonData?.Status; 

                var method = typeof(PathLabDataHandler).GetMethod(nameof(PathLabDataHandler.EditPartialAsync));
                var generic = method?.MakeGenericMethod(type);
                object[] parameters = { existingData, module, token };
                var task = (Task<long>)generic.Invoke(handler, parameters);

                var result = await task;

                return result;
            }
            catch (Exception ex)
            {
                logger.LogError("Exception in EditPartialAsync method and details: " + ex.Message);
                return 0;
            }
        }

        public virtual async Task<long> SaveDataAsync(string model, dynamic data, CancellationToken token)
        {
            try
            {
                var type = GetType(model);
                if (type == null) { return -1; }

                var method = typeof(PathLabDataHandler).GetMethod(nameof(PathLabDataHandler.AddAsync));
                var generic = method?.MakeGenericMethod(type);
                object[] parameters = { data, token };
                var task = (Task<long>)generic.Invoke(handler, parameters);

                var result = await task;

                return result;
            }
            catch (Exception ex)
            {
                logger.LogError("Exception in SaveDataAsync method and details: " + ex.Message);
                return 0;
            }
        }
       
        public dynamic GetChallanReportDateWise(DateTime startDate, DateTime endDate)
        {
            try
            {
                var method = typeof(PathLabDataHandler).GetMethod(nameof(PathLabDataHandler.GetChallanReportDateWise));
                object[] parameters = [startDate, endDate];
                return method?.Invoke(handler, parameters);
            }
            catch (Exception ex)
            {
                logger.LogError("Exception in GetChallanReportDateWise method and details: " + ex.Message);
                return 0;
            }

        }
        internal dynamic GetAllAssignedUsers(string module, long id)
        {
            try
            {
                var method = typeof(PathLabDataHandler).GetMethod(nameof(PathLabDataHandler.GetAllAssignedUsers));
                object[] parameters = [module, id];
                return method?.Invoke(handler, parameters);
            }
            catch (Exception ex)
            {
                logger.LogError("Exception in GetAllAssignedUsers method and details: " + ex.Message);
                return 0;
            }
        }       
    }
}
