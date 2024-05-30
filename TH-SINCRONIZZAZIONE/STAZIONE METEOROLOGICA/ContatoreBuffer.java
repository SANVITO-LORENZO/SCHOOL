public class ContatoreBuffer {
    int contatore;

    public ContatoreBuffer() {
        this.contatore = 0;
    }

    public int getContatore() {
        return contatore;
    }

    public void setContatore(int contatore) {
        this.contatore = contatore;
    }
    public void add() {
        contatore++;
    }
}
