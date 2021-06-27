﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetList();
        IDataResult<List<Category>> GetListByName(string name);

        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
