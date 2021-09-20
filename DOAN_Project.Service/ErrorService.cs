using DOAN_Project.Data.Repositories;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;
using System;

namespace DOAN_Project.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._errorRepository = errorRepository;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}