(function () {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.kbcategory', 'abp.services.app.kbcategoryitem',
        function ($scope, kbCategoryService, kbCategoryItemService) {
            var vm = this;
            vm.kbCategories = [];

            abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    kbCategoryService.getKbCategories({}).success(function (data) {
                        vm.kbCategories = data.kbCategories;
                        console.log(vm.kbCategories);
                    })
                );

            vm.kbTypeChange = function () {
                abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    kbCategoryItemService.getKbCategoryItems({ KbCategoryId: $scope.kbType }).success(function (data) {
                        vm.kbCategoryItems = data.kbCategoryItems;
                        console.log(vm.kbCategoryItems);
                    })
                );
            };
        }
    ]);
})();