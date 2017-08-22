using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTool.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace WebTool.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        

        public JsonResult fetchExcelData()
        {
            FetchData obj = new FetchData();
            DataSet ds = obj.ReadExcelFile();
            //var val = ds.Tables[0].Rows[0]["Name"];
            //object op = ds;
            //IEnumerable<DataRow> sequence = null;
            //foreach (DataTable t in ds.Tables){

            //   sequence = t.AsEnumerable();
            //}
            var json = new JavaScriptSerializer().Serialize(getListFromDataSet(ds));

            return Json(getListFromDataSet(ds), JsonRequestBehavior.AllowGet);
        }

        private Dictionary<string,List<TestCase>> getListFromDataSet(DataSet ds) {
            Dictionary<String, List<TestCase>> testCaseMap = new Dictionary<string, List<TestCase>>();
            foreach (DataTable table in ds.Tables) {
             
                List<TestCase> testCases = new List<TestCase>();
                foreach (DataRow row in table.Rows) {
                    TestCase cases = new TestCase();
                    cases.TestCaseID = row["TestCaseID"].ToString();
                    cases.TestCaseName = row["TestCaseName"].ToString();
                    cases.IterationType = row["IterationType"].ToString();
                    cases.IterationValue = row["IterationValue"].ToString();
                    cases.Run = row["Run"].ToString();
                    cases.Status = row["Status"].ToString();
                    testCases.Add(cases);
                }
                testCaseMap.Add(table.TableName, testCases);
            }
            return testCaseMap;
        }
    }
}