using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCRUD.Data;

namespace BlazorCRUD.Services
{
    public class EmpServices
    {
        protected readonly ApplicationDbContext _dbcontext;
       
        public EmpServices(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }

        public List<EmpClass> GetEmployeess()
        {
            return _dbcontext.EmpTable.ToList();
        }

        public bool AddEmployee(EmpClass ecadd)
        {
            _dbcontext.EmpTable.Add(ecadd);
            _dbcontext.SaveChanges();
            return true;
        }

        public EmpClass Getempdetails(int empid)
        {
            EmpClass objedit = new EmpClass();
            return _dbcontext.EmpTable.FirstOrDefault(e => e.EmpId == empid);
        }

        public bool UpdateEmployee(EmpClass updateemp)
        {
            var Getemp= _dbcontext.EmpTable.FirstOrDefault(e => e.EmpId == updateemp.EmpId);
            if(Getemp !=null)
            {
                Getemp.EmpName = updateemp.EmpName;
                Getemp.Department = updateemp.Department;
                Getemp.Salary = updateemp.Salary;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool DeleteEmployee(EmpClass deleteemp)
        {
            var Getemp = _dbcontext.EmpTable.FirstOrDefault(e => e.EmpId == deleteemp.EmpId);
            if (Getemp != null)
            {
                _dbcontext.Remove(Getemp);
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
