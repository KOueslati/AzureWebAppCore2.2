// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for UWProgram.
    /// </summary>
    public static partial class UWProgramExtensions
    {
            /// <summary>
            /// Get a set of UW Programs by page, corresponding to different filters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            public static object GetPrograms(this IUWProgram operations, int? skip = default(int?), int? top = default(int?), bool? count = default(bool?), string orderby = default(string), string filter = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgram)s).GetProgramsAsync(skip, top, count, orderby, filter), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a set of UW Programs by page, corresponding to different filters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetProgramsAsync(this IUWProgram operations, int? skip = default(int?), int? top = default(int?), bool? count = default(bool?), string orderby = default(string), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetProgramsWithHttpMessagesAsync(skip, top, count, orderby, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the Program.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programDto'>
            /// The Program.
            /// </param>
            public static object CreateProgram(this IUWProgram operations, ProgramDto programDto)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgram)s).CreateProgramAsync(programDto), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the Program.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programDto'>
            /// The Program.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> CreateProgramAsync(this IUWProgram operations, ProgramDto programDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateProgramWithHttpMessagesAsync(programDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Program by his identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// The Program identifier.
            /// </param>
            public static object GetProgramById(this IUWProgram operations, int programId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgram)s).GetProgramByIdAsync(programId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Program by his identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// The Program identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetProgramByIdAsync(this IUWProgram operations, int programId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetProgramByIdWithHttpMessagesAsync(programId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='item'>
            /// </param>
            public static object UpdateProgram(this IUWProgram operations, int programId, ProgramDto item)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgram)s).UpdateProgramAsync(programId, item), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='item'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> UpdateProgramAsync(this IUWProgram operations, int programId, ProgramDto item, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateProgramWithHttpMessagesAsync(programId, item, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the program.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// The program identifier.
            /// </param>
            public static ApiError DeleteProgram(this IUWProgram operations, int programId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgram)s).DeleteProgramAsync(programId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the program.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// The program identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApiError> DeleteProgramAsync(this IUWProgram operations, int programId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteProgramWithHttpMessagesAsync(programId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
