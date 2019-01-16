// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for UWProgramQuotaShare.
    /// </summary>
    public static partial class UWProgramQuotaShareExtensions
    {
            /// <summary>
            /// Get all  quota shares by program identifier
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// program identifier
            /// </param>
            public static object GetQuotaShares(this IUWProgramQuotaShare operations, int programId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgramQuotaShare)s).GetQuotaSharesAsync(programId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all  quota shares by program identifier
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// program identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetQuotaSharesAsync(this IUWProgramQuotaShare operations, int programId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQuotaSharesWithHttpMessagesAsync(programId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update current quota share
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='quotaShareDto'>
            /// </param>
            public static object Update(this IUWProgramQuotaShare operations, int programId, QuotaShareDto quotaShareDto)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgramQuotaShare)s).UpdateAsync(programId, quotaShareDto), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update current quota share
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='quotaShareDto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> UpdateAsync(this IUWProgramQuotaShare operations, int programId, QuotaShareDto quotaShareDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(programId, quotaShareDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a quota share
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='quotaShareDto'>
            /// </param>
            public static object CreateQuotaShare(this IUWProgramQuotaShare operations, int programId, QuotaShareDto quotaShareDto)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgramQuotaShare)s).CreateQuotaShareAsync(programId, quotaShareDto), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a quota share
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='quotaShareDto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> CreateQuotaShareAsync(this IUWProgramQuotaShare operations, int programId, QuotaShareDto quotaShareDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateQuotaShareWithHttpMessagesAsync(programId, quotaShareDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get quota share by his identifier
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// program identifier
            /// </param>
            /// <param name='layerId'>
            /// layer identifier
            /// </param>
            public static object GetQuotaShareById(this IUWProgramQuotaShare operations, int programId, int layerId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgramQuotaShare)s).GetQuotaShareByIdAsync(programId, layerId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get quota share by his identifier
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// program identifier
            /// </param>
            /// <param name='layerId'>
            /// layer identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetQuotaShareByIdAsync(this IUWProgramQuotaShare operations, int programId, int layerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQuotaShareByIdWithHttpMessagesAsync(programId, layerId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete quto share by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='layerId'>
            /// </param>
            public static ApiError Delete(this IUWProgramQuotaShare operations, int programId, int layerId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IUWProgramQuotaShare)s).DeleteAsync(programId, layerId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete quto share by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='programId'>
            /// </param>
            /// <param name='layerId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApiError> DeleteAsync(this IUWProgramQuotaShare operations, int programId, int layerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(programId, layerId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}