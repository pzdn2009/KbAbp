(function () {
    var controllerId = "app.views.kbqueue.new";
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.kbqueue'
    , function ($scope, kbQueueService) {
        var vm = this;

        vm.kbqueue = {
            title: '',
            url: ''
        };

        var localize = abp.localization.getSource('KbAbp');

        vm.saveKbQueue = function () {
            abp.ui.setBusy(
                null,
                kbQueueService.createKbQueue(
                vm.kbqueue
                ).success(function (data) {
                    abp.notify.info(abp.utils.formatString(localize("KbQueueCreateMessage"), vm.kbcategory.title));
                    $location.path('/kbqueuelist');
                })
                );
        };
    }]);
})();
