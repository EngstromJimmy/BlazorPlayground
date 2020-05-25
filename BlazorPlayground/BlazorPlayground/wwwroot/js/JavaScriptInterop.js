
//<SetFocus>
function SetFocus(id) {
    document.getElementById(id).focus();
}
//</SetFocus>

//<OpenInNewWindow>
window.OpenInNewWindow = (url, message) => {
    var newwindow = window.open('', '_blank');
    newwindow.document.write(message);
    newwindow.location.href = url;
}
//</OpenInNewWindow>