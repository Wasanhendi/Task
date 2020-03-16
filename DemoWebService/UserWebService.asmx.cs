using DemoWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DemoWebService
{
    /// <summary>
    /// Summary description for UserWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
    {
        //public UserWebService() : base( )
        //    {

        //    }
        [WebMethod]
        public bool CreateUser(XElement user)   
        {

            using (ApplicationDbContext Db =new ApplicationDbContext()) {
                try
                {
                    //User ouser = new User();
                    //user.City = city;
                    //ouser.Country = county;
                    //ouser.Mobile = mobile;
                    //ouser.Name = name;
                    //ouser.Email = email;
                    //ouser.Street = street;
                    //ouser.BirthOfDate = DateTime.Now;
                    //Db.Users.Add(ouser);
                    //Db.SaveChanges();
                    string d=user.Value ;
                    return true;
                }
                catch {
                    return false ;
                }
               
            } 
        }
        [WebMethod]
        public List<User> GetAllUser()
        {
            using (ApplicationDbContext Db = new ApplicationDbContext())
            {
                //XmlSerializer xs = new XmlSerializer(typeof(List<User>));
               return  Db.Users.ToList();
                //XDocument d = new XDocument();
                //using (XmlWriter xw = d.CreateWriter())
                //    xs.Serialize(xw, Listuser);

                //XElement elm = d.Root;
                //return (elm);
            }
        }
    }
}
