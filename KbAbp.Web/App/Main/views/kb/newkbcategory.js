(function () {
    var controllerId = "app.views.kbcategory.new";
    angular.module('app').controller(controllerId, [
        '$scope','abp.services.app.kbcategory'
    , function ($scope,kbCategoryService) {
        var vm = this;

        console.log(kbCategoryService);
        vm.kbcategory = {
            name: ''
        };

        var localize = abp.localization.getSource('KbAbp');

        vm.saveKbCategory = function () {
            abp.ui.setBusy(
                null,
                kbCategoryService.createKbCategory(
                vm.kbcategory
                ).success(function (data) {
                    abp.notify.info(abp.utils.formatString(localize("KBCategoryCreateMessage"), vm.kbcategory.name));
                })
                );
        };
    }]);
})();
