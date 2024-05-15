

using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
[Route("[Action]")]
[ApiController]


public class University : ControllerBase
{
    Context db = new Context();
    [HttpPost]
    public string Insert(SelectUnit x)
    {
        if (db.Tbl_SelctUnit.Any(y => y.StudentCode == x.StudentCode && y.CourseName==x.CourseName))
            return "repited StuudentCode";
      
        db.Tbl_SelctUnit.Add(x);
        db.SaveChanges();
        return "Done";



    }
    [HttpGet]
    public List<SelectUnit> GetAll()
    {

        return db.Tbl_SelctUnit.ToList();

    }
    [HttpDelete]
    public string Delete(int ID)
    {
        var x = db.Tbl_SelctUnit.Find(ID);
        db.Tbl_SelctUnit.Remove(x);
        db.SaveChanges();
        return "Done";


    }
    [HttpPut]
    public string Update(SelectUnit x)
    {
        var result = db.Tbl_SelctUnit.Find(x.ID);
        result.Name = x.Name;
        result.Family = x.Family;
        result.StudentCode = x.StudentCode;
        result.CourseName = x.CourseName;
        db.Tbl_SelctUnit.Update(result);
        db.SaveChanges();
        return "Done";


    }

}