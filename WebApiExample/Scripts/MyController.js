/// <reference path="angularjs2.min.js" />


//var app = angular.module('myApp', []);//create an angular application
//app.controller("myctrl", function ($scope)
//{
//    $scope.firstname = "Siddhanth";
//}
//    )

var app = angular.module('myApp', []);
app.controller('myCtrl', function ($scope, $http) {
    $http.get("http://localhost:57925/api/employeeDetails")
        .then(function (response) {
            alert(response.data);
            $scope.EmployeeData = response.data;
        })

    $scope.Save = function () {
        $http({
            method: "POST",
            url: "http://localhost:57925/api/employeeDetails",
            data: {
                DeptId: $scope.DeptId,
                EmpName: $scope.EmpName,
                EmpSalary: $scope.EmpSalary
            }
        }).then(function mySuccess(response) {
            alert('Inserted Successfully');
        }),function myError(response) {
            alert('Not Inserted');
        }
    }
})