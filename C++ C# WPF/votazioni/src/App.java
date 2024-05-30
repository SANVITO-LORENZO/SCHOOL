/*
 * E' quindi richiesta la progettazione della classe CElezione che conterrà l'elenco dei voti (max 50).
La classe deve disporre dei metodi per:
1. inserire un nuovo voto (il nome del candidato ricevuto come parametro) in coda (push)
2. visualizzare l'elenco completo
3. ordinare l'elenco
4. data un nome restituire la quantità (es: "rossi" -> 16 voti )
5. eliminare un voto in base al nome (la prima occorrenza che si trova)
6. copiare il contenuto di una votazione in un’altra
7. Visualizza il risultato completo ( per ogni candidato -> Nome Candidato: N° voti)
 */

 class App{

    public static void main(String[] args){
        CElezione ele= new CElezione();
        ele.addVoto("a");
        ele.addVoto("b");
        ele.addVoto("c");
        ele.addVoto("d");
        System.out.println(ele.visualizzaElenco());
        System.out.println("gg");
    }
 }