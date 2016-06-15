(function () {
    var controllerId = "app.views.knowledgecategory.new";
    angular.module('app').controller(controllerId, [
        '$scope', '$location', 'abp.services.app.kbcategoryitem', 'abp.services.app.knowledgecategory'
    , function ($scope, $location, kbCategoryItemService, knowledgeCategoryService) {
        var vm = this;

        vm.knowledgeCategory = {
            name:''
        };

        vm.kbCategoryItems = {};

        var localize = abp.localization.getSource('KbAbp');

        vm.loadkbCategoryItems = function () {
            abp.ui.setBusy(
               null,
               kbCategoryItemService.getKbCategoryItems({}
               ).success(function (data) {
                   console.log(data);
                   vm.kbCategoryItems = data.kbCategoryItems;
               })
               );
        }();

        vm.saveKnowledgeCategory = function () {
            abp.ui.setBusy(
                null,
                knowledgeCategoryService.createKnowledgeCategory(
                vm.knowledgeCategory
                ).success(function (data) {
                    abp.notify.info(abp.utils.formatString(localize("KnowledgeCategoryCreateMessage"), vm.kbcategory.title));
                    $location.path('/kbqueuelist');
                })
                );
        };
    }]);
})();
