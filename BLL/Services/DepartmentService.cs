using BLL.Abstract;
using BLL.ViewModels;
using DAL.Abastract;
using DAL.Concrete;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly EFContext _context;
        public DepartmentService()
        {
            _context = new EFContext();
        }
        public IList<DepartmentItemViewModel> GetAll()
        {
            IList<DepartmentItemViewModel> model = null;

            model = _context.Depatments
                .Select(d => new DepartmentItemViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    Image = d.Image
                }).ToList();
            return model;
        }
    }
}
