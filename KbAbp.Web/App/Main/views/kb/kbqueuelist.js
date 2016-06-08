(function () {
    var controllerId = "app.views.kbqueue.list";
    angular.module('app').controller(controllerId, [
        '$scope','abp.services.app.kbqueue'
    , function ($scope, kbQueueService) {

        var vm = this;
        vm.kbQueues = [];
        vm.localize = abp.localization.getSource('KbAbp');

        vm.refreshKbQueues = function () {
            abp.ui.setBusy( //Set whole page busy until getTasks complete
                null,
                kbQueueService.getKbQueues({}).success(function (data) {
                    vm.kbQueues = data.kbQueues;
                })
            );
        };

        vm.getKbQueueCountText = function () {
            return abp.utils.formatString(vm.localize('Xtasks'), vm.kbQueues.length);
        };

        vm.refreshKbQueues();

    }]);
})();
