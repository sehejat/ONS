﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMS.FrameWork;

namespace ONS.Core.Service.Interfaces
{
   public interface IService<T>
    {
        Result<T> Save(T Entity);
        bool Delete(int Id);
        Result<List<T>> GetAll(String key = "");
        Result<T> GetById(int Id);
        bool IsValid(T obj, Result<T> result);
    }
}
