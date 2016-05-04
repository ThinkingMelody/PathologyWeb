using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PathologyWebAPI.Controllers
{
    [EnableCors(origins: "http://192.9.12.225/", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        SqlConnection myConn;
        SqlCommand myCom;
        // GET: api/Users
        public string Get()
        {
            myConn = new SqlConnection();
            myCom = new SqlCommand();
            myConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connPathology"].ConnectionString;

            myCom.Connection = myConn;

            DataTable dtResult = new DataTable("DoctorInfo");
            StringBuilder sbResult = new StringBuilder();

            sbResult.Append("SELECT top 8 UserName, '不讓你知道!' as Password, UserAlias, 醫師代碼 as DoctorCode, Lic ");
            sbResult.Append("FROM Users ");


            myCom.CommandText = sbResult.ToString();

            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = myCom;

            myAdapter.Fill(dtResult);

            return JsonConvert.SerializeObject(dtResult);
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }

    }
}
