﻿using Blog.Core.Interface.IRepository;
using Blog.Core.Interface.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Repository;
using Blog.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    public class AdvertisementServices : BaseServices<Advertisement>, IAdvertisementServices
    {
        IAdvertisementRepository dal;//= new AdvertisementRepository();

        public AdvertisementServices(IAdvertisementRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }



        //public int Add(Advertisement model)
        //{
        //    return dal.Add(model);
        //}

        //public bool Delete(Advertisement model)
        //{
        //    return dal.Delete(model);
        //}

        //public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        //{
        //    return dal.Query(whereExpression);

        //}

        //public bool Update(Advertisement model)
        //{
        //    return dal.Update(model);
        //}


        //public int Sum(int i, int j)
        //{
        //    return dal.Sum(i,j);
        //}


    }
}
