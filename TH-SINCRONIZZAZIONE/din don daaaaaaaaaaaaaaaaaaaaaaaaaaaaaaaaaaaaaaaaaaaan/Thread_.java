public class Thread_ extends Thread {


    //attributi
    int tempo = 0;
    String s = "";

    Thread_(int tempo,String s){
        this.tempo=tempo;
        this.s=s;
    }

    @Override
    public void run() {
        boolean test =true;
        while(test){
            System.out.println(s);
            try {
                Thread.sleep(tempo);
            } catch (InterruptedException e) {
            }  
        }
    }
}