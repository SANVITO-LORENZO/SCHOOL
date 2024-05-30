document.addEventListener("DOMContentLoaded", function(){
    let query = document.querySelector(".items");


    for (const cibo of listino.bibite) {
  
        localStorage.setItem(cibo.nome,"0")

        let div = document.createElement("div");
        let label = document.createElement("label");
        label.textContent = cibo.nome;
        label.classList.add("nomecibo");
        let cont = document.createElement("label");
        cont.textContent=localStorage.getItem(cibo.nome);
        cont.id=cibo.nome;
        let img = document.createElement("img");
        let button = document.createElement("button");
        button.textContent = '+';
        button.addEventListener("DOMContentLoaded",aumenta(cibo.nome));
        let button2 = document.createElement("button");
        button2.textContent = '-';
        button.addEventListener("DOMContentLoaded",diminuisci(cibo.nome));
        img.src = cibo.pathImg;
        div.appendChild(img); 
        div.appendChild(label);  
        div.appendChild(button);
        div.appendChild(cont);
        div.appendChild(button2);
        query.appendChild(div);
    }

});