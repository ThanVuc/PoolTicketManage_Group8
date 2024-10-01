document.addEventListener("DOMContentLoaded", function(){

    const urlParams = new URLSearchParams(window.location.search);
    let id = urlParams.get("id");
    const url = `http://localhost:5051/tickets/${id}`;
    handle(url)
})


function handle(url){
    fetch(url)
    .then(res => res.json())
    .then(data => {
        const ticketInfo = data.ticket;
        const pool = ticketInfo.pool;
        
        let home = document.querySelector("#home");
        home.querySelector("h1").innerHTML = `Welcome to you to ${pool.poolName}`;
        home.querySelector("img").src = pool.url;

        let introduce = document.querySelector("#introduce");
        introduce.querySelector("p").innerHTML = pool.description

        let swimmingPool = document.querySelector("#swimming-pool");
        swimmingPool.querySelector("h2").innerHTML = "Swimming Pool"
        swimmingPool.querySelector("#open").lastChild.innerHTML = pool.openTime
        swimmingPool.querySelector("#close").lastChild.innerHTML = pool.closeTime


    })
    .catch(err => {
        console.log(err)
    })
}