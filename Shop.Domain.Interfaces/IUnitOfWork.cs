﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Interfaces
{
  public interface IUnitOfWork
  {
    void BeginTransaction();
    void Commit();
    void Rollback();
  }
}
