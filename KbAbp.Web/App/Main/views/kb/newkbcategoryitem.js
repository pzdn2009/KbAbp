(function () {
    var controllerId = "app.views.kbcategoryitem.new";
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.kbcategory', 'abp.services.app.kbcategoryitem'
    , function ($scope, kbCategoryService, kbCategoryItemService) {
        var vm = this;

        vm.kbcategoryitem = {
            name: ''
        };

        //绑定类别
        vm.refreshKbCategories = function () {
            abp.ui.setBusy(
                null,
                kbCategoryService.getKbCategories({}).success(function (data) {
                    vm.kbCategories = data.kbCategories;
                })
            );
        };

        vm.refreshKbCategories();

        var localize = abp.localization.getSource('KbAbp');

        vm.saveKbCategoryItem = function () {
            console.log(vm.kbcategoryitem);
            abp.ui.setBusy(
                null,
                kbCategoryItemService.createKbCategoryItem({ name: vm.kbcategoryitem.name, kbCategoryId: vm.kbcategoryitem.kbCategoryId }).success(function (data) {
                    abp.notify.info(abp.utils.formatString(localize("KBCategoryItemCreateMessage"), vm.kbcategoryitem.name));
                })
                );
        };
    }]);
})();
