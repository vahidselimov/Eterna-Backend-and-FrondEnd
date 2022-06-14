using Microsoft.AspNetCore.Http;

namespace Eterna.Extensions
{
    public static class FileExtensions
    {
        public static bool IsOkey(this IFormFile formFile,int mb)
        {
            return formFile.ContentType.Contains("image") && formFile.Length > mb * 1024 * 1024;
        }


    }
}
