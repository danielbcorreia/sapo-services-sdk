﻿// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511

(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/tests/DeleteVideo/DeleteVideo.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.
            //var elementById = document.getElementById("form_videoDelete");
            //elementById.addEventListener("submit", this.deleteVideo);
        },

        unload: function () {
            // TODO: Respond to navigations away from this page.
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        }
    });
})();

function videoDelete() {
    var client = new Videos.ServiceClient(GlobalAuth.username, GlobalAuth.password, GlobalAuth.accessKey);

    var randname = document.getElementById("randnameParam").value;

    client.asyncDeleteVideo(randname || undefined).then(function (resultCode) {
        document.getElementById("videoDeleteResult").innerHTML = resultCode;
    });
}
