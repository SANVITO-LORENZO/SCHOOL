let vett={
    prenotazioni:[]
};
let cont=0;
let tmp=20;


function stampa(){

    document.querySelector("#countdown").innerHTML=tmp;
    let nome=localStorage.getItem("nome");
    let cognome=localStorage.getItem("cognome");
    let partenza=localStorage.getItem("partenza");
    let destinazione=localStorage.getItem("destinazione");
    let data=localStorage.getItem("data");

    let label= document.createElement("label");
    label.textContent= nome+" "+ cognome+" "+ partenza+" " + destinazione+" " + data+" ";
    document.querySelector("#contenuto").innerHTML="";
    let query=document.querySelector("#contenuto");
    query.appendChild(label);

    tmp--;
    if(tmp<0){

        clearInterval();
        window.location.href="index.html"
    }   
}

document.addEventListener("DOMContentLoaded",function(){
    setInterval(stampa,1000);
})

function invioDati(){

   let nome=localStorage.getItem("nome");
   let cognome=localStorage.getItem("cognome");
   let partenza=localStorage.getItem("partenza");
   let destinazione=localStorage.getItem("destinazione");
   let data=localStorage.getItem("data");

    let tmp = new informazione(nome,cognome,partenza,destinazione,data)
    let vett = JSON.stringify(localStorage.getItem("vettTOT"));
    vett.prenotazioni=tmp;
    vett =JSON.parse(vett);
    localStorage.setItem("vettTOT",vett);
    clearInterval();
    window.location.href="index.html"
}

