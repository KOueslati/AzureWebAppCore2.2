using System.Collections.Generic;
using System.Threading.Tasks;
using UWProgramApi.v1_0.Models;

namespace WebApp.BL
{
    public interface IUWProgramService
    {
        IEnumerable<ProgramDto> GetDesiredUWPrograms(int? skip = null, int? top = null, bool? count = null, string orderby = null, string filter = null);
        Task<IEnumerable<ProgramDto>> GetDesiredUWProgramsAsync(int? skip = null, int? top = null, bool? count = null, string orderby = null, string filter = null);
        ProgramDto CreateProgram(ProgramDto programViewModel);
        Task<ProgramDto> CreateProgramAsync(ProgramDto programViewModel);
        ProgramDto GetProgramById(int programid);
        Task<ProgramDto> GetProgramByIdAsync(int programid);
        ProgramDto UpdateProgram(int programid, ProgramDto item);
        Task<ProgramDto> UpdateProgramAsync(int programid, ProgramDto item);
        UWProgramApi.v1_0.Models.ApiError DeleteProgramById(int programid);
        Task<UWProgramApi.v1_0.Models.ApiError> DeleteProgramByIdAsync(int programid);
    }
}