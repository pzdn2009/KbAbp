(function () {

    var controllerId = 'app.views.task.new';
    angular.module('app').controller(controllerId, [
        '$scope', '$location', 'abp.services.app.task',
        function ($scope, $location, taskService) {
            var vm = this;

            vm.task = {
                description: ''
            };

            var localize = abp.localization.getSource('KbAbp');

            vm.saveTask = function () {
                abp.ui.setBusy(
                    null,
                    taskService.createTask(
                        vm.task
                    ).success(function () {
                        abp.notify.info(abp.utils.formatString(localize("TaskCreatedMessage"), vm.task.description));
                        $location.path('/');
                    })
                );
            };
        }
    ]);
})();