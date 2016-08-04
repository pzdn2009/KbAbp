(function () {
    var controllerId = "app.views.knowledge.list";
    angular.module('app').controller(controllerId, [
        '$scope', '$location', '$stateParams', 'marked', 'abp.services.app.knowledgecategory', 'abp.services.app.knowledge'
    , function ($scope, $location, $stateParams, marked, knowledgeCategoryService, knowledgeService) {
        var vm = this;

        vm.knowledgeCategories = {};
        vm.knowledges = {};

        var localize = abp.localization.getSource('KbAbp');

        //1.knowledge category get the categories.
        vm.loadKnowledgeCategories = function () {
            abp.ui.setBusy(
                null,
                knowledgeCategoryService.getKnowledgeCategories({ KbCategoryItemId: $stateParams.id }).success(function (data) {
                    vm.knowledgeCategories = data.knowledgeCategories;
                })
            );
        };
        vm.loadKnowledgeCategories();

        //2.bind click 
        vm.knowledgeCategoryClick = function (knowledgeCategory) {
            
            vm.activeKnowledgeCategory = knowledgeCategory.name;

            abp.ui.setBusy(
                null,
                knowledgeService.getKnowledges(
                { knowledgeCategoryId: knowledgeCategory.id }
                ).success(function (data) {
                    vm.knowledges = data.knowledges;
                })
                );
        };
    }]);
})();
