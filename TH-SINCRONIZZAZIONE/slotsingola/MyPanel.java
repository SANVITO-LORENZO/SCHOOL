import java.awt.Font;
import java.awt.Graphics;

import javax.swing.JPanel;

public class MyPanel  extends JPanel{
    public bottone btt;

    public rullo r1;
    public rullo r2;
    public rullo r3;

    String risultato="";
    
    public MyPanel(){
        btt= new bottone(100, 100, 200, 30);
        r1=new rullo(20, 200, 50, 50);
        r2=new rullo(80, 200, 50, 50);
        r3=new rullo(140, 200, 50, 50);
    }


    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        btt.disegnati(g);

        r1.disegnati(g);
        r2.disegnati(g);
        r3.disegnati(g);

        g.setFont(new Font("Arial",0,30));
        g.drawString(risultato,100,180);

        g.drawString("€"+ Portafolio.getInstanza().getSoldi(),0,40);
    }

}