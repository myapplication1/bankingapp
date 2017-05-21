using System;
namespace app.com.Data.impp
{
    interface IImpRepository1
    {
        string Abort();
        string AlertManage();
        string Commit();
        System.Collections.Generic.IEnumerable<app.com.Data.app_imp_history> GetAllImports(int number);
        DateTime GetCurrentDateTime();
        string GetImportCode(int id);
        app.com.Data.app_imp_history GetImports(int? id);
        string GetLoginUser();
        System.Collections.Generic.IEnumerable<app.com.Data.app_imp_history> Imports();
        string PrcessError();
        bool CheckCustomer(int gender, string firstname_, string lastname, string surname, DateTime dob, string vId, string tel);
    }
}
