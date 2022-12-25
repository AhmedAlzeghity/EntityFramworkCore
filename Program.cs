// See https://aka.ms/new-console-template for more information
using EntityFramworkCore;

var _context = new ApplicationDbContext();
var Employee = new Employee{ Name ="Ahmed"};
_context.Employees.Add(Employee);   // add to dbcontext
_context.SaveChanges();            // save to Db 

// Not Asybc AddAsync , SaveAsyc + Await 


