﻿using System.Collections.Generic;
using SikhUnit.Domain.Entity;

namespace SikhUnit.Domain.Interface.Service
{
    public interface IImageService
    {
        List<Image> GetAllImages();
    }
}