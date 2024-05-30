public class dipendente{
    int id;
    boolean sesso;
    int tempo;

    public int getId() {
        return id;
    }
    public boolean isSesso() {
        return sesso;
    }
    public int getTempo() {
        return tempo;
    }

    public dipendente(int id, boolean sesso, int tempo) {
        this.id = id;
        this.sesso = sesso;
        this.tempo = tempo;
    }

    public void aumentaTempo(int tmp){
        this.tempo+=tmp;
    }

}