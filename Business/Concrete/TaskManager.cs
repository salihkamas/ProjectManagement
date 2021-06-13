using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public IResult Add(Task task)
        {
            _taskDal.Add(task);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Task task)
        {
            _taskDal.Delete(task);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Task>> GetAll()
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetAll(),Messages.SuccessList);
        }

        public IDataResult<Task> GetByUserId(int userId)
        {
            return new SuccessDataResult<Task>(_taskDal.Get(x=>x.UserId==userId),Messages.SuccesFind);
        }

        public IResult Update(Task task)
        {
            _taskDal.Update(task);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
