using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModals;
namespace MVCDB.DbOperations
{
    public class StudentRepo
    {

        //Insert
        public int addStudent(StudentModal student)
        {
            try
            {
                using (var context = new KrunalDhote351Entities())
                {
                    Student std = new Student()
                    {
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        Email = student.Email,
                        Address = student.Address,
                        Gender = student.Gender,
                        Password = student.Password,
                    };
                    context.Students.Add(std);
                    context.SaveChanges();

                    return std.id;
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }


        }

        //Retrive
        public List<StudentModal> getStudentData()
        {
            using (var context = new KrunalDhote351Entities())
            {
                try
                {
                    var data = context.Students.Select(d => new StudentModal()
                    {
                        id = d.id,
                        FirstName = d.FirstName,
                        LastName = d.LastName,
                        Email = d.Email,
                        Address = d.Address,
                        Gender = d.Gender
                    }).ToList();
                    return data;
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                
            }
        }


        //Get One Student Data
        public StudentModal getStudent(int id)
        {
            using (var context = new KrunalDhote351Entities())
            {
                try
                {
                    var data = context.Students.Where(d=>d.id==id).Select(d => new StudentModal()
                    {
                        id = d.id,
                        FirstName = d.FirstName,
                        LastName = d.LastName,
                        Email = d.Email,
                        Address = d.Address,
                        Gender = d.Gender
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }

            }
        }

        //Delete

        public bool deleteStudentData(int id)
        {
                try
                {
                    using (var context = new KrunalDhote351Entities())
                    {
                        var data = context.Students.FirstOrDefault(d => d.id == id);
                        if (data != null)
                        {
                            context.Students.Remove(data);
                            context.SaveChanges();
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
        }


        //Update
        public bool updateStudentData(int id,StudentModal modal)
        {
            try
            {
                using (var context = new KrunalDhote351Entities())
                {
                    var data = context.Students.FirstOrDefault(d => d.id == id);
                    if (data != null)
                    {
                        data.FirstName = modal.FirstName;
                        data.LastName = modal.LastName;
                        data.Email = modal.Email;
                        data.Address = modal.Address;
                        data.Gender = modal.Gender;
                        data.Password = data.Password;
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
