using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using log4net.Core;
using Microsoft.Extensions.Logging;
using UWProgramApi.v1_0;
using UWProgramApi.v1_0.Models;
using ILogger = log4net.Core.ILogger;

namespace WebApp.BL
{
    public class UWProgramService : IUWProgramService
    {
        private readonly IUWProgramApiClient _programApiClient;
        private readonly ILogger _log = LoggerManager.GetLogger(Assembly.GetAssembly(typeof(UWProgramService)),typeof(UWProgramService)); 

        public UWProgramService(IUWProgramApiClient programApiClient)
        {
            _programApiClient = programApiClient ?? throw new ArgumentNullException(nameof(programApiClient));
        }

        #region Program

        public IEnumerable<ProgramDto> GetDesiredUWPrograms(int? skip = null, int? top = null, bool? count = null, string orderby = null, string filter = null)
        {

            object result = _programApiClient.UWProgram.GetPrograms(skip, top, count, orderby, filter);
            try
            {
                // TODO
                return ((PageResultProgramDto)result).Items;
            }
            catch (Exception e)
            {
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                
                _log.Log(typeof(UWProgramService), Level.Error, error.Message,e); 

                throw e;
            }
        }

        public async Task<IEnumerable<ProgramDto>> GetDesiredUWProgramsAsync(int? skip = null, int? top = null, bool? count = null, string orderby = null, string filter = null)
        {

            object result = await _programApiClient.UWProgram.GetProgramsAsync();
            try
            {
                return (IEnumerable<ProgramDto>)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public ProgramDto CreateProgram(ProgramDto programViewModel)
        {
            object result = _programApiClient.UWProgram.CreateProgram(programViewModel);
            try
            {
                return (ProgramDto)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public async Task<ProgramDto> CreateProgramAsync(ProgramDto programViewModel)
        {
            object result = await _programApiClient.UWProgram.CreateProgramAsync(programViewModel);
            try
            {
                return (ProgramDto)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public ProgramDto GetProgramById(int programid)
        {
            object result = _programApiClient.UWProgram.GetProgramById(programid);
            try
            {
                return (ProgramDto)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public async Task<ProgramDto> GetProgramByIdAsync(int programid)
        {
            object result = await _programApiClient.UWProgram.GetProgramByIdAsync(programid);
            try
            {
                return (ProgramDto)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public ProgramDto UpdateProgram(int programid, ProgramDto item)
        {
            object result = _programApiClient.UWProgram.UpdateProgram(programid, item);
            try
            {
                return (ProgramDto)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public async Task<ProgramDto> UpdateProgramAsync(int programid, ProgramDto item)
        {
            object result = await _programApiClient.UWProgram.UpdateProgramAsync(programid, item);
            try
            {
                return (ProgramDto)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public UWProgramApi.v1_0.Models.ApiError DeleteProgramById(int programid)
        {
            object result = _programApiClient.UWProgram.DeleteProgram(programid);
            try
            {
                return (UWProgramApi.v1_0.Models.ApiError)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }
        public async Task<UWProgramApi.v1_0.Models.ApiError> DeleteProgramByIdAsync(int programid)
        {
            object result = await _programApiClient.UWProgram.DeleteProgramAsync(programid);
            try
            {
                return (UWProgramApi.v1_0.Models.ApiError)result;
            }
            catch (Exception e)
            {
                //// TODO : Log4Net
                var error = (UWProgramApi.v1_0.Models.ApiError)result;
                _log.Log(typeof(UWProgramService), Level.Error, error.Message, e);
                throw e;
            }
        }

        #endregion
    }
}