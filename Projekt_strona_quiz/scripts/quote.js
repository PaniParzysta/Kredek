let allQuotes = {};
var currentQuoteNumber = 0;
const quotetime = 6000;
const updateQuoteTime = 1200;
let apiEndpoint = 'https://type.fit/api/quotes';
let currentQuote = {};
let numberOfQuotes = 0;

function onLoad(){
    loadQuotes()
        .then(data => setUpQuoteDisplay(data));
}

function loadQuotes(){
    return  fetch(apiEndpoint)
        .then(response => response.json())
        .catch(error => console.log(error));
}

function setUpQuoteDisplay(quotes){
    allQuotes = quotes;
    numberOfQuotes = quotes.length;
    document.getElementById("quote").innerHTML = quotes[0].text;
    document.getElementById("author").innerHTML = quotes[0].author;
    setInterval(changeQuote, quotetime);
}

function updateQuoteDiv(){
    fadeOut();
    setTimeout(updateHtml, updateQuoteTime)
}

function changeQuote(){
    currentQuoteNumber = currentQuoteNumber +1;
    currentQuoteNumber = currentQuoteNumber % numberOfQuotes;
    currentQuote = allQuotes[currentQuoteNumber];
    updateQuoteDiv();
}

function fadeOut(){
    document.getElementById("fade").style.opacity=0;
}

function updateHtml(){
    document.getElementById("quote").innerHTML = currentQuote.text;
    document.getElementById("author").innerHTML = currentQuote.author;
    document.getElementById("fade").style.opacity ='1';
}