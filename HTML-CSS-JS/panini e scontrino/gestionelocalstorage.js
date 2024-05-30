function getdati(){
    if(localStorage.getItem("dati")== null)
        return null
    else
        return JSON.parse(localStorage.getItem("dati"));
}

function  savedata(dati){
    let s= JSON.stringify(dati);
    localStorage.setItem("dati",s);
}

let dati= getdati()
if(dati==null){
    dati={};
}

if(dati["panini"] == undefined){
    dati["panini"]={};
    savedata(dati);
}