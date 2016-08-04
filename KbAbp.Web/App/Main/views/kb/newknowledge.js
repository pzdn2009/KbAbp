(function () {
    var controllerId = "app.views.knowledge.new";
    angular.module('app').controller(controllerId, [
        '$scope', '$location', 'marked', 'abp.services.app.kbcategoryitem', 'abp.services.app.knowledgecategory',
        'abp.services.app.knowledge'
    , function ($scope, $location, marked, kbCategoryItemService, knowledgeCategoryService, knowledgeService) {
        var vm = this;

        vm.knowledge = {
            name: '',
            detail: ''
        };

        vm.kbCategoryItems = {};
        vm.knowledgeCategories = {};

        var localize = abp.localization.getSource('KbAbp');

        vm.loadkbCategoryItems = function () {
            abp.ui.setBusy(
               null,
               kbCategoryItemService.getKbCategoryItems({}
               ).success(function (data) {
                   vm.kbCategoryItems = data.kbCategoryItems;
               })
               );
        }();

        vm.kbCategoryItemsChange = function () {
            abp.ui.setBusy(
                null,
                knowledgeCategoryService.getKnowledgeCategories({ KbCategoryItemId: $scope.kbCategoryItemId }).success(function (data) {
                    vm.knowledgeCategories = data.knowledgeCategories;
                })
            );
        };

        vm.saveKnowledge = function () {
            //assign
            vm.knowledge.detail = $scope.markdown;
            abp.ui.setBusy(
                null,
                knowledgeService.createKnowledge(
                vm.knowledge
                ).success(function (data) {
                    abp.notify.info(abp.utils.formatString(localize("KnowledgeCreateMessage"), vm.knowledge.name));
                    $location.path('/');
                })
                );
        };

    }]);
})();
