﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Product_residue
{
    interface IBranchProductService
    {
        Task<BranchProduct> GetAll();

    }
}