let ticketTag = document.querySelector(".pool-list")
let url = "http://localhost:5051/tickets";

document.addEventListener("DOMContentLoaded", function(){
    renderListTickets();
});

function renderListTickets(){
    let myArray = []
    
    fetch (url)
    .then(res => res.json())
    .then(data => {
        const tickets = data.tickets;
        let ticketTag = document.querySelector(".pool-list")
        tickets.forEach(element => {
            let pool = document.createElement("a")
            pool.href = `detail.html?id=${element.ticketId}`;
            pool.className = "pool"
            pool.style.textDecoration = "none";
            pool.innerHTML = `<img src="${element.url}" alt="Cannot load this image">
                <div class="pool-info">
                <h2>${element.ticketName}</h2>
                <p>${element.description}</p>
                </div>`
            ticketTag.append(pool)
        });
    })
    .catch(err => {
        console.log(err)
    })
    return myArray
}