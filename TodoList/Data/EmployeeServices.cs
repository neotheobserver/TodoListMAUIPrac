using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Data.Model;

namespace TodoList.Data
{
    public class EmployeeServices
    {
        public static List<EmployeeModels> AllEmployees()
        {
            return new List<EmployeeModels> {

                new EmployeeModels { FullName = "Ram Pyakurel", Email = "ram@hari.com", PhoneNumber = "981-978-9907", Age = 22,
                    Department = "IT", isAdmin = false, isSupervisor = true, Gender = "Male" },
                new EmployeeModels { FullName = "Fannie Trusler", Email = "ftrusler0@sina.com.cn", PhoneNumber = "610-695-6384",
                    Age = 23, Department = "Research and Development", isAdmin = false, isSupervisor = false, Gender = "Polygender" },
                new EmployeeModels { FullName = "Maryrose Hawkslee", Email = "mhawkslee1@qq.com", PhoneNumber = "865-384-8504",
                    Age = 24, Department = "Accounting", isAdmin = false, isSupervisor = false, Gender = "Female" },
                new EmployeeModels { FullName = "Roldan Sewall", Email = "rsewall4@fema.gov", PhoneNumber = "289-645-5788",
                    Age = 27, Department = "Business Development", isAdmin = false, isSupervisor = true, Gender = "Male" },
                new EmployeeModels { FullName = "Rosaleen Kilius", Email = "rkilius5@telegraph.co.uk", PhoneNumber = "128-795-8250",
                    Age = 28, Department = "Research and Development", isAdmin = false, isSupervisor = false, Gender = "Female" },
                new EmployeeModels { FullName = "Tallie Timpany", Email = "ttimpany9@reuters.com", PhoneNumber = "652-914-4209",
                    Age = 29, Department = "Support", isAdmin = false, isSupervisor = false, Gender = "Female" },
                new EmployeeModels { FullName = "Vernen Adkin", Email = "vadkin8@msu.edu", PhoneNumber = "838-710-9181",
                    Age = 30, Department = "Product Management", isAdmin = false, isSupervisor = false, Gender = "Male" },
                new EmployeeModels { FullName = "Korey Keasy", Email = "kkeasy2@webnode.com", PhoneNumber = "917-372-6239",
                    Age = 25, Department = "Services", isAdmin = false, isSupervisor = false, Gender = "Genderqueer" },
                new EmployeeModels { FullName = "Daren Ewing", Email = "dewing3@latimes.com", PhoneNumber = "862-938-7894",
                    Age = 26, Department = "Engineering", isAdmin = false, isSupervisor = false, Gender = "Agender" },
                new EmployeeModels { FullName = "Alienos Alieana", Email = "alien@from.mars", PhoneNumber = "toot-toot-toot",
                    Age = -2147483648, Department = "Ruler", isAdmin = true, isSupervisor = true, Gender = "Alien" }, //+2147483647
            };
        }

        //sort 2 methods

        public static List<EmployeeModels> FilterEmployees(string name)
		{
            return EmployeeServices.AllEmployees().Where(x=>(x.FullName.Contains(name, StringComparison.OrdinalIgnoreCase))).ToList();
		}


        public static List<EmployeeModels> SortList()
        {
            return EmployeeServices.AllEmployees().OrderBy(x => x.Age).ToList();
        }

		public static List<EmployeeModels> SortListDes()
		{
			return EmployeeServices.AllEmployees().OrderByDescending(x => x.Age).ToList();
		}

	}  
}

