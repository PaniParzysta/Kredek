const form = document.getElementById("to_do");

form.addEventListener('submit', (event) => {
    event.preventDefault();
    for (let i = 1; i <= 5; i++) {
        const question = 'thing'+i;
        const answer = form[question].value;
        let answerNr = "answer"+i;
        document.cookie = answerNr + "=" + answer;
    }
    console.log(document.cookie);
    window.location.href = "list_to_do.html";
});