﻿using NLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(); 
    }
}
