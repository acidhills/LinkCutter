linkCutterApp.provider('userProvider', [
    function () {
        var _url = null;
        this.setUrl = function (url) {
            _url = url;
        };
        this.$get = ['$http', function ($http) {
            _url = _url || '';
            return {
                add: function () {
                    return $http.post(_url + '/api/user');
                }
            }
        }];
    }
])
