﻿#region Using directives

using System.Collections.Generic;
using System.Linq;
using RetailPOS.BusinessLayer.Service.Admin;
using RetailPOS.CommonLayer.DataTransferObjects;
using RetailPOS.CommonLayer.Mapper;

#endregion

namespace RetailPOS.BusinessLayer.ServiceImpl.Admin
{
    public class CategoryServiceImpl : AdminBaseService, ICategoryService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<ProductCategoryDTO> ICategoryService.GetCategories()
        {
            IList<ProductCategoryDTO> lstCategories = new List<ProductCategoryDTO>();
            ObjectMapper.Map(base.CategoryRepository.GetList().ToList(), lstCategories);
            return lstCategories;
        }
    }
}