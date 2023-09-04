using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> ListAllCategory();
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);

        Category GetById(int Id);

    }
}
