linkCutterApp.controller("linksController", ['linkProvider', 'userProvider', '$cookies', 'userCookie',
    function (linkProvider, userProvider, cookies, cookieName) {
        var self = this;
        self.user = cookies.get(cookieName);
        self.links = [];
        
        if (self.user) {
            linkProvider.getLinks(self.user).success(function (result) {                
                self.links = result;
            });
        }
    }
]);