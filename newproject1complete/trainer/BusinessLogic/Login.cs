using System.Numerics;
using System.Xml.Linq;
//using DataEf;
using DataEf;
using Models;
using static Azure.Core.HttpHeader;
using System.Collections.Generic;
using System.Collections;


namespace BusinessLogic;
public class Login
{

    public int LoginSubmit(string EmailID, string Password)
    {
        int usid = 0;
        DataEf.Entities.SoluContext SoluContext = new DataEf.Entities.SoluContext();

        var query = from b in SoluContext.Users where b.EmailId == EmailID && b.Password == Password select b;

        foreach (var q in query)
        {
            usid = q.UserId;

        }

        if (usid > 0)
        {
            return usid;
        }

        else
        {
            return usid;
        }
    }


    public int SignUpSubmit(UserModel user)
    {
        DataEf.Entities.SoluContext SoluContext = new DataEf.Entities.SoluContext();
        DataEf.Entities.User user1 = new DataEf.Entities.User();

        user1.FirstName = user.FirstName;
        user1.LastName = user.LastName;
        user1.EmailId = user.EmailId;
        user1.Password = user.Password;
        user1.PhoneNo = user.PhoneNo;
        user1.City = user.City;

        SoluContext.Users.Add(user1);
        int i = SoluContext.SaveChanges();
        return i;
    }

    public IQueryable<DataEf.Entities.User> SignUpUser()
    {
        DataEf.Entities.SoluContext SoluContext = new DataEf.Entities.SoluContext();

        var query = from b in SoluContext.Users select b;

        return query;

    }

    //public IList GetAll(int id)
    //{
    //    DataEf.Entities.SoluContext cnt = new DataEf.Entities.SoluContext();


    //    var query1 = (from st in cnt.Certs
    //                  where st.UsId == id
    //                  select st).ToList();

    //    var tr = query1.Select(x => new CertModel()
    //    {
    //        CertId = x.CertId,
    //        CertificationName = x.CertificationName,
    //        AcquiredFrom = x.AcquiredFrom,
    //        CertLicence = x.CertLicence
    //    }).ToList();

    //    return tr;
    //}

    public IList getUser(int id)
    {
        DataEf.Entities.SoluContext SoluContext = new DataEf.Entities.SoluContext();

        var query = (from st in SoluContext.Users
                     where st.UserId == id
                     select st).ToList();

        return query;
    }
}








public class LoginClass
{
    public string EmailID { get; set; }
    public string Password { get; set; }

}

