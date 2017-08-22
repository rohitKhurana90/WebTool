var app = angular.module('automationTool', []);

app.controller('homeCtrl', function ($scope, $http, $window) {
    $scope.firstName = "John";
    $scope.lastName = "Doe";
    $scope.fullName = function () {
        return $scope.firstName + " " + $scope.lastName;
    };

    $scope.title = "Dashboard";

    //$scope.tableData = [
    //    { id: "lSYM-TC001", name: "lSYM-TC001 Akhil", title: $scope.title },
    //    { id: "lSYM-TC002", name: "lSYM-TC002 Akhil", title: $scope.title },
    //    { id: "lSYM-TC003", name: "lSYM-TC003 Akhil", title: $scope.title },
    //    { id: "lSYM-TC004", name: "lSYM-TC004 Akhil", title: $scope.title },
    //    { id: "lSYM-TC005", name: "lSYM-TC0051 Akhil", title: $scope.title },
    //    { id: "lSYM-TC006", name: "lSYM-TC0061 Akhil", title: $scope.title }
    //]

    $scope.count = 0;

    $scope.ButtonClick = function () {
        $http({
            method: "GET",
            url: "/Home/fetchExcelData",
            dataType: 'json',
            headers: { "Content-Type": "application/json" }
        }).then(function mySuccess(response) {
            $scope.tableDataVal = response.data.Misc$;
           alert("Success")
        }, function myError(response) {
            alert("Here")
        });
    }


});





