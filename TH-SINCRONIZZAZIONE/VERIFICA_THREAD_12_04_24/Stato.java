public class Stato {
    boolean stato;
    //false se il tavolo non è ancora pieno
    //true quando il tavolo sarà pieno

    static Stato istanza= null;
    static synchronized Stato getIstanza(){
        if (istanza==null)
            istanza=new Stato();
        return istanza;
    }

    private Stato(){
        this.stato= false;
    }
}
