﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Infrastructure.Mapping
{
    public interface IHaveCustomMapping
    {
        void CreateMapping(IConfiguration configuration);
    }

}