linkCutterApp.provider('linkProvider', [
    function () {
        var _url = null;
        this.setUrl = function (url) {
            _url = url;
        };
        this.$get = ['$http', function ($http) {
            _url = _url || '';
            return {
                add: function (options) {
                    $http.defaults.headers.post["Content-Type"] = "application/x-www-form-urlencoded";
                    //зачем '='? вопрос к microsoft, форм дата никогда не намапится если форма не имеет вида x=y(даже если x пустая строка)
                    return $http.post(_url + '/api/user/' + options.userId + '/link', '='+ options.link);
                },
                
                getLinks: function (userid) {
                    return $http.get(_url + '/api/user/' + userid + '/links');
                }
            }
        }];
    }
])
