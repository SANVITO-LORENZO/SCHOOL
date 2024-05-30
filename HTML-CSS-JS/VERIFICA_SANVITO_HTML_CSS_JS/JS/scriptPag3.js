function controllo(){
    let controllo=true;
    let tmp = document.getElementById("dataTimePicker").value;
    // let dataTemp= new Date;
    // if(tmp<dataTemp)
    //     controllo=false;
    //TODO CONTROLLO DATA
    if(controllo){
 
        if(localStorage.getItem("data")==undefined){
            localStorage.setItem("data","");
        }

        localStorage.setItem("data",tmp);
        window.location.href="pagina4.html";
    }
    else
        alert("DATA INSERITA ERRATA");
}