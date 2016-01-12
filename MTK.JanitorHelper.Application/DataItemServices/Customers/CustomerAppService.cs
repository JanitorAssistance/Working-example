using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using MTK.JanitorHelper.DataItemBase.Customers;
using MTK.JanitorHelper.DataItemServices.Customers.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;
using System.Threading.Tasks;
using MTK.JanitorHelper.DataItemBase.Address;

namespace MTK.JanitorHelper.DataItemServices.Customers
{
    class CustomerAppService : JanitorHelperAppServiceBase, ICustomerAppService
    {
        private readonly IRepository<Customer> customerRepository;
        private readonly IRepository<StreetAddress> streetAddressRepository;

        public CustomerAppService(IRepository<Customer> customerRepo, IRepository<StreetAddress> streetAddressRepo)
        {
            this.customerRepository = customerRepo;
            this.streetAddressRepository = streetAddressRepo;
        }

        public async Task CreateCustomer(CreateCustomerInput input)
        {
            // var streetAddress = this.streetAddressRepository.
            var streetAddress = this.streetAddressRepository.GetAll().Where(sa => sa.Name.Contains(input.StreetAddressName));

            var customer = input.MapTo<Customer>();
            if (streetAddress.Count() == 0)
            {
                //var streetAddress = new StreetAddress() { Name = input.StreetAddressName };
                //var streetAddressMap = streetAddress.MapTo<StreetAddress>();
                customer.StreetAddressId = this.streetAddressRepository.InsertAndGetId(new StreetAddress() { Name = input.StreetAddressName });
            }
            else
                customer.StreetAddressId = streetAddress.FirstOrDefault().Id;
             
            await this.customerRepository.InsertAsync(customer);
        }

        public async Task DeleteCustomer(IdInput input)
        {
            await this.customerRepository.DeleteAsync(input.Id);
        }

        public ListResultOutput<CustomerListDto> GetCustomers(GetCustomersInput input)
        {
            var customers = this.customerRepository
                .GetAll()
                
                .WhereIf(
                    input.Filter != null,
                    p => p.FirstName.Contains(input.Filter) ||
                            p.LastName.Contains(input.Filter) ||
                            p.EmailAddress.Contains(input.Filter)
                )
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList();

            return new ListResultOutput<CustomerListDto>(customers.MapTo<List<CustomerListDto>>());
        }

        public string GetStreetAddressName(int streetAddressId)
        {
            if (streetAddressId != 0 )
                return this.streetAddressRepository.Get(streetAddressId).Name.ToString();
            else
                return string.Empty;
        }

    }
}


