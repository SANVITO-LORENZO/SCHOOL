
let vett=[
    "Milano",
    "Monza",
    "Como",
    "Bergamo",
    "Brescia",
    "Mantova",
    "Varese",
    "Cremona",
    "Pavia",
    "Lecco",
    "Sondrio",
    "Lodi",
    "Gallarate",
    "Legnano",
    "Rho",
    "Desenzano del Garda",
    "Sesto San Giovanni",
    "Cinisello Balsamo",
    "Busto Arsizio"
    
]

document.addEventListener("DOMContentLoaded",function(){

    let query1= document.querySelector("#inserimento_partenza");
    let query2= document.querySelector("#inserimento_destinazione");
    let select= document.createElement("select");
    select.classList.add("combobox");
    select.id="tmp1";


    for (const citta of vett) {
        let option = document.createElement("option");
        option.textContent=citta;
        option.value=citta;
        select.appendChild(option);
    }
    query1.appendChild(select);

    let select2= document.createElement("select");
    select2.classList.add("combobox");
    select2.id="tmp2";


    for (const citta of vett) {
        let option = document.createElement("option");
        option.textContent=citta;
        option.value=citta;
        select2.appendChild(option);
    }

    query2.appendChild(select2);
});


function controllo(){
    let tmp1= document.getElementById("tmp1").value;
    let tmp2= document.getElementById("tmp2").value;

    if(tmp1!=tmp2){
        
        if(localStorage.getItem("partenza")==undefined){
            localStorage.setItem("partenza","");
        }
        if(localStorage.getItem("destinazione")==undefined){
            localStorage.setItem("destinazione","");
        }

        localStorage.setItem("partenza",tmp1);
        localStorage.setItem("destinazione",tmp2);
        
        window.location.href="pagina3.html"
    }
    else
        alert("SELEZIONARE DUE OPZIONI DIVERSE")

}