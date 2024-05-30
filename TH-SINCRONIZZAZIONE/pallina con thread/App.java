import javax.swing.JFrame;
import javax.swing.SwingUtilities;
import javax.swing.Timer;

public class App {
        public static void main(String[] args) throws InterruptedException {
            //aggingere il pannello
            MyPanel p = new MyPanel();
            
            
            Pallina p1=new Pallina(300, 50, 50, 50,1);
            Pallina p2=new Pallina(660, 120, 50, 50,2);
            Pallina p3=new Pallina(300, 90, 50, 50,3);
            ThreadPallina t1=new ThreadPallina(p,p1);
            ThreadPallina t2=new ThreadPallina(p,p2);
            ThreadPallina t3=new ThreadPallina(p,p3);
            t1.start();
            t2.start();
            t3.start();
      

        //timer
        MyActionListener l2 =new MyActionListener(p);
        Timer t = new Timer(10,l2);
        t.start();

        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI(p);
            }
        });

        t1.join();
        t2.join();
        t3.join();
    
    }

    private static void createAndShowGUI(MyPanel p){
        JFrame f = new JFrame("SPOSTA IL CERCHIO");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      
        
        f.add(p);
        //settare la dimensione uguale al pannello
        f.pack();
        //f.setSize(500,500);
        f.setVisible(true);
    }
}