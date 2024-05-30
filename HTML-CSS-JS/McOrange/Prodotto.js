class Prodotto{

    constructor (nome, prezzo, pathImg, contatore){

        this.nome = nome;
        this.prezzo = prezzo;
        this.pathImg = pathImg;
        this.contatore = contatore;
    }


}

function aumenta(nome){
    aggiorna(nome);
}

function diminuisci(nome){
    aggiornameno(nome);
}

function aggiorna(nome){
    let cont = document.getElementById(nome);
    let tmp = localStorage.getItem(nome);
    tmp= parseInt(tmp);
    tmp+=1;
    localStorage.setItem(nome,tmp);
    cont.innerHTML= localStorage.getItem(nome);
}

function aggiornameno(nome){
    let cont = document.getElementById(nome);
    let tmp = localStorage.getItem(nome);
    tmp= parseInt(tmp);
    if(tmp>0)
        tmp-=1;
    localStorage.setItem(nome,tmp);
    cont.innerHTML= localStorage.getItem(nome);
}
