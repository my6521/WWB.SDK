using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;
using WWB.SDK.ArcFaceApi.Models;
using WWB.UnifyApi.Models;

namespace WWB.SDK.ArcFaceApi
{
    public interface IArcFaceApi
    {
        /// <summary>
        /// 新增人脸特征
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("/api/Face/Save")]
        Task<ApiResult> Save([JsonNetContent] FaceSaveRequest request);

        /// <summary>
        /// 删除人脸特征
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/api/Face/Delete")]
        Task<ApiResult> Delete([Required] string id);

        /// <summary>
        /// 1:N人脸特征对比
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("/api/Face/CompareSearch")]
        Task<ApiResult<FaceCompareSearchResponse>> CompareSearch([JsonNetContent] FaceCompareSearchRequest request);
    }
}