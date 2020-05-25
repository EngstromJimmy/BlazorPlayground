
//<SetFocus>
function SetFocus(id) {
    document.getElementById(id).focus();
}
//</SetFocus>

//<OpenInNewWindow>
window.NavigationManagerExtensions = {};
window.NavigationManagerExtensions.openInNewWindow = (url, message) => {
    var newwindow = window.open('', '_blank');
    newwindow.document.write(message);
    newwindow.location.href = url;
}
//</OpenInNewWindow>

//<saveAsFile>
window.JSRuntimeExtensions = {};
window.JSRuntimeExtensions.saveAsFile=(filename, type, bytesBase64) =>{
    if (navigator.msSaveBlob) {
        //Download document in Edge browser
        var data = window.atob(bytesBase64);
        var bytes = new Uint8Array(data.length);
        for (var i = 0; i < data.length; i++) {
            bytes[i] = data.charCodeAt(i);
        }
        var blob = new Blob([bytes.buffer], { type: type });
        navigator.msSaveBlob(blob, filename);
    }
    else {
        var link = document.createElement('a');
        link.download = filename;
        link.href = "data:" + type + ";base64," + bytesBase64;
        document.body.appendChild(link); // Needed for Firefox
        link.click();
        document.body.removeChild(link);
    }
}
//</saveAsFile>