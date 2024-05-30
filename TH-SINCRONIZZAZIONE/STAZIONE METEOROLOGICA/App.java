public class App {

    public static void main(String[] args) throws InterruptedException {
        
        Misurazioni buffer = new Misurazioni(0);
        Misurazioni corrette = new Misurazioni(0);
        Misurazioni sbagliate = new Misurazioni(0);

        Semaforo mutexBuffer= new Semaforo(1);
        Semaforo mutexCorrette= new Semaforo(1);
        Semaforo mutexSbagliate= new Semaforo(1);
        Semaforo bufferDatoScritto= new Semaforo(0);
        Semaforo bufferDatoLetto= new Semaforo(1);

        ContatoreBuffer contatore= new ContatoreBuffer();

        ThStazione t1= new ThStazione("BAREGGIA",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t2= new ThStazione("MACHERIO",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t3= new ThStazione("SOVICO",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t4= new ThStazione("MARIANO",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t5= new ThStazione("MONZA",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t6= new ThStazione("SEREGNO",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t7= new ThStazione("CARATE",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t8= new ThStazione("IVREA",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t9= new ThStazione("CABIATE",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);
        ThStazione t10= new ThStazione("CANTU",buffer, mutexBuffer, contatore, bufferDatoScritto, bufferDatoLetto);

        ThServer s1=new ThServer(buffer, corrette, sbagliate, mutexBuffer, mutexCorrette, mutexSbagliate, bufferDatoScritto, bufferDatoLetto);
        ThServer s2=new ThServer(buffer, corrette, sbagliate, mutexBuffer, mutexCorrette, mutexSbagliate, bufferDatoScritto, bufferDatoLetto);

        ThStazione[] vett = new ThStazione[10];
        vett[0]=t1;
        vett[1]=t2;
        vett[2]=t3;
        vett[3]=t4;
        vett[4]=t5;
        vett[5]=t6;
        vett[6]=t7;
        vett[7]=t8;
        vett[8]=t9;
        vett[9]=t10;

        for(int x =0; x<10; x++){
            vett[x].start();
        }
        s1.start();
        s2.start();

        System.out.println("MISURAZIONI CORRETTE:");
        for(int x=0;x<corrette.numel;x++){
            corrette.toString(x);
        }
        System.out.println("MISURAZIONI ERRATE:");
        for(int x=0;x<sbagliate.numel;x++){
            corrette.toString(x);
        }
    }
}