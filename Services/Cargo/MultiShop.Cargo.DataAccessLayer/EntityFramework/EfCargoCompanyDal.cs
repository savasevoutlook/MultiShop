﻿using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Repositories;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework;

public class EfCargoCompanyDal : GenericRepository<CargoCompany>, ICargoCompanyDal
{
    #region Ctor

    public EfCargoCompanyDal(CargoContext cargoContext) : base(cargoContext)
    {
        
    }

    #endregion
}
