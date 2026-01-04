using System.Collections.Generic;
using System.Data;
using TTNT_DAL;

namespace TTNT_BUS
{
    public class DataBUS
    {
        DataHelperDAL dal = new DataHelperDAL();
        DecisionTreeBUS algo = new DecisionTreeBUS();

        public DataTable LayDuLieu(string path)
        {
            return dal.ReadExcelToDataTable(path);
        }

        public string GetBestAttribute(DataTable data, List<string> attributes, string targetColumn, out string log)
        {
            return algo.GetBestAttribute(data, attributes, targetColumn, out log);
        }
    }
}