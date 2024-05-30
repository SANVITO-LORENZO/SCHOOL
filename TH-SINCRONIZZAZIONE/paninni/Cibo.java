public class Cibo {
    
    int id;
    int tmpProduzione, tmpConsumazione;
    String nome;


    protected Cibo(int idUnivoco, int tmpProduzione, int tmpConsumazione, String nome) {
        this.id = idUnivoco;
        this.tmpProduzione = tmpProduzione;
        this.tmpConsumazione = tmpConsumazione;
        this.nome = nome;
    }


    public int getId() {
        return id;
    }

    public int getTmpProduzione() {
        return tmpProduzione;
    }

    public int getTmpConsumazione() {
        return tmpConsumazione;
    }

    public String getNome() {
        return nome;
    }

}