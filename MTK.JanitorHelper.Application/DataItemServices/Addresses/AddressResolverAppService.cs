/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper Application project.
 *
 * Created: 9. December 2015
 * Authors: Marko Kylmalahti
 */

using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using MTK.JanitorHelper.DataItemBase.Address;
using MTK.JanitorHelper.DataItemServices.Addresses.Dto;
using MTK.JanitorHelper.DataItemServices.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemServices.Addresses
{
    class AddressResolverAppService : JanitorHelperAppServiceBase, IAddressResolverAppService
    {

        private readonly IRepository<StreetAddress> streetAddressRepository;
        private readonly IRepository<City> citiesRepository;

        protected AddressResolverAppService(IRepository<StreetAddress> streetAddressesRepo, IRepository<City> citiesRepo)
        {
            this.streetAddressRepository = streetAddressesRepo;

            this.citiesRepository = citiesRepo;
        }
        //  private readonly IRepository<City> citiesRepository;


        public int GetCity(GetAddressInput input)
        {

            var output = this.citiesRepository
                 .GetAll()
                .WhereIf(
                    input.Filter != null,
                    p => p.Name.Contains(input.Filter) 
                )
               .ToList()
                ;


            ListResultOutput<StreetAddressListDto> list = new ListResultOutput<StreetAddressListDto>(output.MapTo<List<StreetAddressListDto>>());
            return list.Items.ElementAt(0).Id;

        }
        
        // this.citiesRepository = new IRepository<StreetAddress>();

        //public ListResultOutput<CustomerListDto> GetCustomers(GetCustomersInput input)
        //{
        //    var customers = customerRepository
        //        .GetAll()
        //        .WhereIf(
        //            input.Filter != null,
        //            p => p.FirstName.Contains(input.Filter) ||
        //                    p.LastName.Contains(input.Filter) ||
        //                    p.EmailAddress.Contains(input.Filter)
        //        )
        //        .OrderBy(p => p.FirstName)
        //        .ThenBy(p => p.LastName)
        //        .ToList();

        //    return new ListResultOutput<CustomerListDto>(customers.MapTo<List<CustomerListDto>>());
        //}
    }

}//MTK.JanitorHelper.DataItemServices.Addresses