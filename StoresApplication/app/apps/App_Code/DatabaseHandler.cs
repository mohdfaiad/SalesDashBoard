using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class DatabaseHandler
{
    private Database SYSTEM_DB;
    private DbCommand mycommand;
    private DataTable returndetailsDataTable;

    public DatabaseHandler()
    {
        try
        {

            SYSTEM_DB = DatabaseFactory.CreateDatabase("LOCALMACHINE5");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetOrganisationName()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetOrganisationName");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetUser(string userName, string Password)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetUser", userName, Password);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetSetup(int ID)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetSetup", ID);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetAccesslevels()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetAccessLevel");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetUsersGrid(int AcccessLevel, int Area, string name)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetUsersGrid", AcccessLevel, Area, name);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetUserDetailsbyID(int ID)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetUserDetailsbyID", ID);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //
    public DataTable GetBraches()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetBraches");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //
    public DataTable GetTopPerformingTypes()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetTopPerformingTypes");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetByProductType(int id)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetByProductType", id);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetProductType()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetProductType");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetItemCategory()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetItemCategory");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetTotalSales()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetTotalSales");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //
    public DataTable GetUniqueReportDate()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetUniqueReportDate");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetProductById(int Id)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetProductById", Id);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //
    public DataTable GetItemsReport(int id,DateTime date)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetItemsReport",id, date);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetSummarySalesByMonth()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetSummarySalesByMonth");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetsalesReport(string date)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetsalesReport", date);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetProfitByProductType(DateTime date)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetProfitByProductType",date);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void BackupDatabase(string DatabaseName, string Path)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("BackupDatabase", DatabaseName, Path);
            SYSTEM_DB.ExecuteNonQuery(mycommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void SaveUser(string UserName, string firstName, string lastName, string password, int AccessLevel, bool IsActive)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("SaveUser", UserName, firstName,lastName, password, AccessLevel, IsActive);
            SYSTEM_DB.ExecuteNonQuery(mycommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Updatepassword(string username, string password,string newpassword)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("Updatepassword", username,password,newpassword);
            SYSTEM_DB.ExecuteNonQuery(mycommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //
    public void SaveItemCategories(string ItemCode, string Description, int ProductType, decimal BuyingPrice)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("SaveItemCategories", ItemCode, Description, ProductType, BuyingPrice);
            SYSTEM_DB.ExecuteNonQuery(mycommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetsalesDetails(string Code)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetsalesDetails", Code);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable CheckIfItemCodeisValid(string Code)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("CheckIfItemCodeisValid", Code);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetTotalreports()
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("GetTotalreports");
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable CheckIfReportExists(string BranchCode, string ReportMonth)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("CheckIfReportExists", BranchCode, ReportMonth);
            returndetailsDataTable = SYSTEM_DB.ExecuteDataSet(mycommand).Tables[0];
            return returndetailsDataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void SaveUploadedReports(string FileName, string BranchCode, DateTime UploadDate, string ReportMonth)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("SaveUploadedReports", FileName, BranchCode, UploadDate, ReportMonth);
            SYSTEM_DB.ExecuteNonQuery(mycommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void SaveReportItems(string ItemCode, int UnitsSold, decimal BuyingPrice, decimal SellingPrice, decimal TotalSales, decimal TotalCost, DateTime ReportDate, DateTime RecordDate, string BranchCode)
    {
        try
        {
            mycommand = SYSTEM_DB.GetStoredProcCommand("SaveReportItems",ItemCode, UnitsSold, BuyingPrice, SellingPrice, TotalSales, TotalCost, ReportDate, RecordDate, BranchCode );
            SYSTEM_DB.ExecuteNonQuery(mycommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}