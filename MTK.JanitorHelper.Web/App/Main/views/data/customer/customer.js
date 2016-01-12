/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper Web project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

(function () {
    var controllerId = 'app.views.data.customer';
    angular.module('app').controller(controllerId, [
        '$scope', '$uibModal', 'abp.services.app.customer',
        function ($scope, $uibModal, customerService) {
            var vm = this;
         
            vm.customers = [];

            vm.streetNameResolved;

            //vm.getStreetAddress = function (id) {
            //    customerService.getStreetAddressName(id).success(function(result){
            //        return result;
            //    });
            //};


     

            vm.getCustomers = function () {
                customerService.getCustomers({
                    filter: vm.filterText
                }).success(function (result) {
                    vm.customers = result.items;
                });
            };

         

            function getCustomers() {
                customerService.getCustomers({ filter: vm.filterText }).success(function (result) {
                    vm.customers = result.items;
                });
            }

            vm.deleteCustomer = function (item) {
                abp.message.confirm(abp.localization.localize('AreYouSureToDeletePerson', 'JanitorHelper', item.lastName, item.firstName),
                    function (isConfirmed) {
                        if (isConfirmed) {
                            customerService.deleteCustomer({
                                id: item.id
                            }).success(function () {
                                abp.notify.success(abp.localization.localize('SuccessfullyDeleted'));
                                getCustomers();
                            });
                        }
                    }
                );
            };

            vm.openCreateCustomerModal = function () {
                var uibModalInstance = $uibModal.open({
                    templateUrl: '~/App/Main/views/data/customer/createCustomerModal.cshtml',
                    controller: 'app.views.data.customer.createCustomerModal as vm',
                    backdrop: 'static'
                });

                uibModalInstance.result.then(function () {
                    getCustomers();
                });
            };

            getCustomers();
         
        }


    ]);
})();

