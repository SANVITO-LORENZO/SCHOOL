public class MyVett {
    
    //ATTRIBUTI
    int numel=0;
    int []vett;

    //COSTRUTTORE
    public MyVett() {
        vett= new int[1000];
    }

    synchronized public void addVett(int num){
            vett[numel]=num;
            numel++;
    }

    public int getel(int indice){
        return vett[indice] ;   
}
}
