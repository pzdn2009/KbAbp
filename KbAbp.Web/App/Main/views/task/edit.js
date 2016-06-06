(function () {
    var controllerId = 'app.views.task.edit';
    angular.module('app').controller(controllerId, [
        '$scope', '$stateParams', '$location', 'abp.services.app.task', 'abp.services.app.project',
        function ($scope, $stateParams, $location, taskService, projectService) {

            var vm = this;
            var localize = abp.localization.getSource('KbAbp');

            //任务ID
            vm.taskid = $stateParams.taskid;
            vm.task = null;
            vm.projects = [];

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

            vm.refreshTasks = function () {
                abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    taskService.getTasks({ //Call application service method directly from javascript
                        id: vm.taskid
                    }).success(function (data) {
                        vm.task = data.tasks[0];
                    })
                );
            };

            vm.refreshTasks();

            vm.saveTask = function () {
                abp.ui.setBusy(
                    null,
                    taskService.updateTask(
                        { taskid: vm.task.id, projectID: vm.task.projectID, remark: vm.task.remark, state: vm.task.state }
                    ).success(function () {
                        abp.notify.info(abp.utils.formatString(localize("TaskUpdateMessage"), vm.task.description + vm.task.remark));
                        $location.path('/');
                    })
                );
            };
        }
    ]);
})();