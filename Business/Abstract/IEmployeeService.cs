using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        IResult Add(Employee employee);
        IResult Delete(Employee employee);
        IResult Update(Employee employee);
    }
}
