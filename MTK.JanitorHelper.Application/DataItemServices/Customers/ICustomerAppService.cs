/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper EntityFramework project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MTK.JanitorHelper.DataItemServices.Customers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemServices.Customers
{
    public interface ICustomerAppService : IApplicationService
    {
        ListResultOutput<CustomerListDto> GetCustomers(GetCustomersInput input);

        Task CreateCustomer(CreateCustomerInput input);
        Task DeleteCustomer(IdInput input);

        string GetStreetAddressName(int input);
    }
}//MTK.JanitorHelper.DataItemServices.Customers
