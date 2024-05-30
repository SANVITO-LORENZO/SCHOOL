class Prodotto{

    constructor (nome, prezzo, pathImg, contatore){

        this.nome = nome;
        this.prezzo = prezzo;
        this.pathImg = pathImg;
        this.contatore = contatore;
    }
}

function aumenta(nome, prodotto){
    let cont = document.getElementById(nome);
    let dati = getdati();

    if(dati[prodotto]== undefined){
        dati[prodotto]={};  
    }

    if(dati[prodotto][nome]== undefined){
        dati[prodotto][nome]=0;
    }
    
    dati[prodotto][nome]= parseInt(dati[prodotto][nome]) + 1;
    savedata(dati);

    cont.textContent= dati[prodotto][nome];
}


function diminuisci(nome, prodotto){
    let cont = document.getElementById(nome);
    let dati = getdati();

    if(dati[prodotto]== undefined){
        dati[prodotto]={};  
    }

    if(dati[prodotto][nome]== undefined){
        dati[prodotto][nome]=0;
    }
    if(dati[prodotto][nome]>0)
        dati[prodotto][nome]= parseInt(dati[prodotto][nome]) - 1;
    savedata(dati);

    cont.textContent= dati[prodotto][nome];
}

function aggiornameno(nome, prodotto){
    let cont = document.getElementById(nome);
    let tmp = getdati().prodotto.nome;
    tmp= parseInt(tmp);
    if(tmp>0)
        tmp-=1;
    localStorage.setItem(nome,tmp);
    cont.textContent= localStorage.getItem(nome);
}
