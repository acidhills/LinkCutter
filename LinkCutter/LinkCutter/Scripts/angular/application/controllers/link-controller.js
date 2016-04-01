linkCutterApp.controller("linkController", ['linkProvider', 'userProvider', '$cookies','userCookie',
    function (linkProvider, userProvider,cookies,cookieName) {
        var self = this;
        self.text = '';
        self.user = cookies.get(cookieName);
        if (!self.user)
        {
            userProvider.add().then(function (result) {
                self.user = result.data.id;
                cookies.put(cookieName, self.user);
                
            });
        }
        self.newLink = function () {
            linkProvider.add({
                userId: self.user,
                link: self.text
            }).then(function (result) {
                self.text = result.data.shortUrl;
            });
        };
    }
]);