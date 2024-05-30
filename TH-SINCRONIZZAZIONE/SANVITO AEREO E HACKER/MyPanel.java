import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JPanel;

public class MyPanel extends JPanel {
    Aereo aereo;
    Stato stato;
    public MyPanel() {
        this.aereo = Aereo.ottieniistanza();
        this.stato=Stato.ottieniIstanza();
    }
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        disegnaRiga(0,g,10);
        disegnaRiga(10,g, 70);
        disegnaRiga(20,g, 130);
        disegnaRiga(30,g,190);
        disegnaRiga(40,g,250);
        disegnaRiga(50,g,310);
        disegnaRiga(60,g,370);
        disegnaRiga(70,g,430);
        disegnaRiga(80,g,490);
        disegnaRiga(90,g,550);
    }


    private void disegnaRiga(int indice, Graphics g, int y ){
        for(int i =0;i<10;i++){

            if(aereo.vett[i+indice].agenzia=="A1"){
                g.setColor(Color.GREEN);
                g.fillRect((i*50)+10, y, 50, 50);
            }
            if(aereo.vett[i+indice].agenzia=="A2"){
                g.setColor(Color.RED);
                g.fillRect((i*50)+10, y, 50, 50);
            }
            if(aereo.vett[i+indice].agenzia=="A3"){
                g.setColor(Color.PINK);
                g.fillRect((i*50)+10, y, 50, 50);
            }
            if(aereo.vett[i+indice].agenzia=="A4"){
                g.setColor(Color.YELLOW);
                g.fillRect((i*50)+10, y, 50, 50);
            }
            if(aereo.vett[i+indice].agenzia=="A5"){
                g.setColor(Color.ORANGE);
                g.fillRect((i*50)+10, y, 50, 50);
            }
            g.setColor(Color.BLACK);
            g.drawRect((i*50)+10, y, 50, 50);
            g.drawString(aereo.vett[i+indice].numero+"",(i*50)+30,y+30);
       
        }
    }
    
}
