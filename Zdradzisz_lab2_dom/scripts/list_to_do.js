function onLoad() {
    document.getElementById("1thing").innerHTML = document.cookie.split(";")[1].split("=")[1];
    document.getElementById("2thing").innerHTML = document.cookie.split(";")[2].split("=")[1];
    document.getElementById("3thing").innerHTML = document.cookie.split(";")[3].split("=")[1];
    document.getElementById("4thing").innerHTML = document.cookie.split(";")[4].split("=")[1];
    document.getElementById("5thing").innerHTML = document.cookie.split(";")[5].split("=")[1];
}