function controllo(){
    let nome= document.getElementById("inpN").value;
    let cognome= document.getElementById("inpC").value;

    let controllo = "true";

    //TODO CONTROLLI E MODIFICARE IL VALORE DI CONTROLLO COSI DA FARE USCIRE L'ERRORE A SCHERMO

    if (controllo == "true"){
        
        if(localStorage.getItem("nome")==undefined){
            localStorage.setItem("nome","");
        }
        if(localStorage.getItem("cognome")==undefined){
            localStorage.setItem("cognome","");
        }

        localStorage.setItem("nome",nome);
        localStorage.setItem("cognome",cognome);
        window.location.href="pagina2.html"
    }
    else
        alert(controllo)
}