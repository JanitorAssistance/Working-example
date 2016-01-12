/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper Web project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

(function () {
    var controllerId = 'app.views.data.customer.createCustomerModal';
    angular.module('app').controller(controllerId, [
        '$scope', '$uibModalInstance', 'abp.services.app.customer',
        function ($scope, $uibModalInstance, customerService) {
            var vm = this;
            //vm.test1 = 'testi';
            //vm.city = addressResolverService.getCity(vm.test1);

            vm.saving = false;
            vm.customer = {};

            vm.save = function () {
                vm.saving = true;
                customerService.createCustomer(vm.customer).success(function () {
                    abp.notify.info(abp.localization.localize('SavedSuccessfully'));
                    $uibModalInstance.close();
                }).finally(function () {
                    vm.saving = false;
                });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss();
            };
        }
    ]);
})();