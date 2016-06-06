(function () {

    var controllerId = 'app.views.task.new';
    angular.module('app').controller(controllerId, [
        '$scope', '$location', 'abp.services.app.task', 'abp.services.app.project',
        function ($scope, $location, taskService, projectService) {
            var vm = this;

            vm.projects = [];

            vm.task = {
                description: ''
            };

            //查询项目
            vm.refreshProjects = function () {
                abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    projectService.getProjects({ //Call application service method directly from javascript
                        keyword: null
                    }).success(function (data) {
                        vm.projects = data.projects;

                    })
                );
            };

            vm.refreshProjects();

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