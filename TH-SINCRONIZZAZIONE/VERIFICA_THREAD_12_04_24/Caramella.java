public class Caramella {
    boolean prenotata;//TRUE= PRENOTATA FALSE= NON PRENOTATA
    String postIt;

    public Caramella() {
        this.prenotata = false;
        this.postIt = "";
    }

    public void setPrenotata(boolean prenotata) {
        this.prenotata = prenotata;
    }
    public void setpostIt(String postIt) {
        this.postIt = postIt;
    }
    public boolean isPrenotata() {
        return prenotata;
    }

    public String getpostIt() {
        return postIt;
    }

    public void cambiaStato(){
        if (prenotata)
            prenotata= false;
        else
            prenotata=true;
    }

}
