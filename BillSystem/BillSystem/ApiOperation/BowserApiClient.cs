using BillSystem.Model.Bowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSystem.ApiOperation
{
    public partial class ApiOperation
    {
        string Bank_BranchEntryBaseUri = "api/Bank_BranchEntry/";

        public List<BowserVM> BnkMas_SelectWeb(int CKy, int UsrKy, int ObjKy)
        {
            string actionUri = "BnkMas_SelectWeb";
            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            paramDictionary.Add("CKy", CKy);
            paramDictionary.Add("UsrKy", UsrKy);
            paramDictionary.Add("ObjKy", ObjKy);


            List<BowserVM> list = new List<BowserVM>();
            list = RunApiOperation(
                Bank_BranchEntryBaseUri,
                actionUri,
                paramDictionary,
                list.GetType()) as List<BowserVM>;

            return list;
        }

        public bool BnkMas_InsertWeb(int CKy, int UsrKy, int ObjKy, string bankEntryDetails)
        {
            string actionUri = "BnkMas_InsertWeb";
            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            paramDictionary.Add("CKy", CKy);
            paramDictionary.Add("UsrKy", UsrKy);
            paramDictionary.Add("ObjKy", ObjKy);
            paramDictionary.Add("bankEntryDetails", bankEntryDetails);


            object list = new object();
            list = RunApiOperation(
                Bank_BranchEntryBaseUri,
                actionUri,
                paramDictionary,
                list.GetType()) as object;

            return Convert.ToBoolean(list);
        }

        public bool BnkMas_UpdateWeb(string EnvironmentName, int CKy, int UsrKy, int ObjKy, string bankEntryDetails)
        {
            string actionUri = "BnkMas_UpdateWeb";
            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            paramDictionary.Add("CKy", CKy);
            paramDictionary.Add("UsrKy", UsrKy);
            paramDictionary.Add("ObjKy", ObjKy);
            paramDictionary.Add("bankEntryDetails", bankEntryDetails);

            object list = new object();
            list = RunApiOperation(
                Bank_BranchEntryBaseUri,
                actionUri,
                paramDictionary,
                list.GetType()) as object;

            return Convert.ToBoolean(list);
        }

        public bool BnkMas_DeleteWeb(string EnvironmentName, int CKy, int UsrKy, int ObjKy, string bankEntryDetails)
        {
            string actionUri = "BnkMas_DeleteWeb";
            Dictionary<string, object> paramDictionary = new Dictionary<string, object>();

            paramDictionary.Add("CKy", CKy);
            paramDictionary.Add("UsrKy", UsrKy);
            paramDictionary.Add("ObjKy", ObjKy);
            paramDictionary.Add("bankEntryDetails", bankEntryDetails);

            object list = new object();
            list = RunApiOperation(
                Bank_BranchEntryBaseUri,
                actionUri,
                paramDictionary,
                list.GetType()) as object;

            return Convert.ToBoolean(list);
        }
        
    }
}
