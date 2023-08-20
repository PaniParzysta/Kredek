let allPhotos = {};

var currentPhotoNumber = 0;

const Time = 6000;

const updateTime = 1200;

let apiEndpoint = 'https://jsonplaceholder.typicode.com/photos';

let currentPhoto = {};

let numberOfPhotos = 0;


function onLoad() {
    loadPhotos()
        .then(data => setUpPhotoDisplay(data));
}

function loadPhotos() {
    return fetch(apiEndpoint)
        .then(response => response.json())
        .catch(error => console.log(error));
}

function setUpPhotoDisplay(photos){
    allPhotos = photos;
    numberOfPhotos = photos.length;

    const src = photos[0].url + '.png';
    let imgTag = document.createElement('img');
    imgTag.src = src;
    document.body.appendChild(imgTag);
    document.getElementById("title").innerHTML = photos[0].title;
    
    setInterval(changePhoto, Time);
}

function updatePhotoDiv() {
    fadeout();
    setTimeout(updateHtml, updateTime);
}

function changePhoto() {
    currentPhotoNumber = currentPhotoNumber + 1;
    currentPhoto = allPhotos[currentPhotoNumber];
    updatePhotoDiv();
}

function fadeout() {
    document.getElementById("fade").style.opacity=0;
}

function updateHtml() {
    const src = currentPhoto.url + '.png';
    let imgTag = document.createElement('img');
    imgTag.src = src;
    document.body.appendChild(imgTag);
    document.getElementById("title").innerHTML = currentPhoto.title;
    document.getElementById("fade").style.opacity = 1;
}