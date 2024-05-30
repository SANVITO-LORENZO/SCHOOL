public class Stato {
    int stato;
    //1=incorso //2=completato //3=hackerato

    static Stato instanza=null;
    static Stato ottieniIstanza(){
        if(instanza==null){
            instanza=new Stato();
        }
        return instanza;
    }
    private Stato(){
        stato=1;
    }

    public int getStato() {
        return stato;
    }

}
