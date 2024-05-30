public class CPersona {

    /* arrey che conterrà i voti */
    int vett;
    /* numero di elementi che contiene l'arrey */
    int numel;
    /* numero di elementi massimi dell'arrey */
    int maxel;

    String nome

    /*
     * costruttore non parametrico di CPersona
     */
    CPersona(String nomee){
        int numel=0;
        int maxel=5;
        vett=new int [maxel];
        nome=nomee
    }

    /*
     * metodo che mi permette di aggiungere all'arrey di voti della persona un voto
     * con il numero intero passato come parametro
     */
    void addVoto(int voto){
        if(numel==maxel){
            ridimensiona(maxel+5);
        }
        vett[numel]=voto;
        numel++;
    }
    /*
     * metodo che permette di togliere l'ultimo voto inserito nell'arrey di voti
    */
    void togliVoto(){
        numel--;
    }
    
    /*
     * metodo che mi permette di modificare la lunghezza dell'arrey
     */
    void ridimensiona(int lunghezza){
        int v=new int[lunghezza];
        for(int x=0;x<numel;x++){
            v[x]=vett[x];
        }
        delete[]vett;
        vett=v;
        maxel=lunghezza;
    }


    /*
     * metodo che ritorna il numero di elementi contenuti nell'arrey di voti
     */
    int getVoti(){
        return numel;
    }

    String getnome(){
        return nome;
    }

}
