using System;
using System.Data;
using System.IO;
using System.Text;
using ExcelDataReader; // Phải cài NuGet ExcelDataReader và ExcelDataReader.DataSet

namespace TTNT_DAL
{
    public class DataHelperDAL
    {
        public DataTable ReadExcelToDataTable(string filePath)
        {
            // Đăng ký bảng mã để đọc tiếng Việt và định dạng Excel cũ
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Chuyển toàn bộ file Excel thành DataSet
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true // Dùng dòng 1 làm tên cột
                        }
                    });

                    // Lấy bảng đầu tiên (Sheet 1)
                    if (result.Tables.Count > 0)
                        return result.Tables[0];
                    return null;
                }
            }
        }
    }
}