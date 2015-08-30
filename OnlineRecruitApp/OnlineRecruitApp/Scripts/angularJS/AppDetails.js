
angular
    .module('MyApp.ctrl.crud', [])
    .controller('loginController', [
        '$scope', function ($scope) {

            $scope.Applicantlist = [];

            $scope.load;

            $scope.load = function () {

                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Applicant/Applicantlist',
                    success: function (data) {
                        $scope.Applicantlist = data
                        $scope.$apply();
                    }
                });
            }
            $scope.load();

            $scope.applicant = {
                FirstName: '',
                LastName: '',
                PhoneNo: '',
                EmailID: '',
                EducationalQualification: '',
                PreviousCompany: '',
                YearsOfExperience: '',
                ApplicantAddress: '',
                ApplicantResume: '',
                Comments: ''

            }

            $scope.clear = function () {
                $scope.applicant.FirstName = '';
                $scope.applicant.LastName = '';
                $scope.applicant.PhoneNo = '';
                $scope.applicant.EmailID = '';
                $scope.applicant.EducationalQualification = '';
                $scope.applicant.PreviousCompany = '';
                $scope.applicant.YearsOfExperience = '';
                $scope.applicant.ApplicantAddress = '';
                $scope.applicant.ApplicantResume = '';
                $scope.applicant.Comments = '';

            };

           
        }
    ]);