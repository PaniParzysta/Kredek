//funkcja odświerzajaca zegar
function RefreshClock() {
    var refresh = 1000; 
    mytime = setTimeout('Clock()', refresh);
}

//funkcja wyświetlająca aktualny czas na stronie
function Clock() {
    var x = new Date()
    document.getElementById('clock').innerHTML = x;
    RefreshClock();
}

//funkcja która przy kliknięciu zmienia obrazek 
function StartPictures() {
    document.getElementById("foodImages").src = "Images/lm.jpg";
    document.getElementById("foodImages").onclick = Pictures;
}

//funkcja która przy kliknięciu zmienia obrazek 
function Pictures() {
    document.getElementById("foodImages").src = "Images/gn.jpg";
    document.getElementById("foodImages").onclick = Pictures2;
}

//funkcja która przy kliknięciu zmienia obrazek 
function Pictures2() {
    document.getElementById("foodImages").src = "Images/spag.jpg";
    document.getElementById("foodImages").onclick = StartPictures;
}

//wyświetla co minutę komunikat
setInterval(() => {
    alert("Miłego dnia :)");
}, 60000);