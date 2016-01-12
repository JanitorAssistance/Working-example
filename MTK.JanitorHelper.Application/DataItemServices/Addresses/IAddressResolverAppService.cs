/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper Application project.
 *
 * Created: 9. December 2015
 * Authors: Marko Kylmalahti
 */

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MTK.JanitorHelper.DataItemBase.Address;
using MTK.JanitorHelper.DataItemServices.Addresses.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemServices.Addresses
{
    public interface IAddressResolverAppService : IApplicationService
    {
        // ListResultOutput<CustomerListDto> GetCustomers(GetCustomersInput input);

        //Task CreateCustomer(CreateCustomerInput input);
        //Task DeleteCustomer(IdInput input);
        //ListResultOutput<StreetAddressListDto> GetAddress(GetAddressInput input);
        int GetCity(GetAddressInput input);
    }
}
