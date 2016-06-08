(function () {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.kbcategory', function ($scope, kbCategoryService) {
            var vm = this;
            vm.kbCategories = [];

            abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    kbCategoryService.getKbCategories({}).success(function (data) {
                        vm.kbCategories = data.kbCategories;
                        console.log(vm.kbCategories);
                    })
                );
        }
    ]);
})();