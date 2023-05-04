﻿using CarAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.UseCasesPorts
{
    public interface IDeleteCarInputPort
    {
        Task Handle(DeleteCarDTO car);
    }
}
