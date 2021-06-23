using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Helper
    {
        public static string ConvertToMD5 (this string contens)
        {
            // tao MD5
            MD5 mh = MD5.Create();

            // chuyển kiểu chuỗi thành kiểu Byte 
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(contens);

            // mã hóa chuỗi đã chuyển 
            byte[] hash = mh.ComputeHash(inputBytes);

            //tạo đối tượng StringBuilder ( làm việc với kiểu dữ liệu lớn )
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++){
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString().ToLower();

        }
    }
}
