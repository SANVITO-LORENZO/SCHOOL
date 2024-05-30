import java.awt.Dimension;
import java.awt.Graphics;
import javax.swing.JPanel;

public class MyPanel extends JPanel {
        /**attributi */
    Pallina []vett=new Pallina[3];
    int numel=0;

    /**costruttore */
    public MyPanel() {
    }

    /**metodo che setta le dimensioni iniziali della finestra */
    @Override
    public Dimension getPreferredSize(){
        return new Dimension(800,800);
    }

    public void addpallina(Pallina p){
        if(numel<3){
            vett[numel]=p;
            numel++;
        }
    }
    /**metodo che disegna la figura */
    public void paintComponent(Graphics g){
        super.paintComponent(g);
        for(int num =0;num<numel;num++){
        g.setColor(vett[num].getBackgroundColor());
        g.fillOval(vett[num].getX(), vett[num].getY(), vett[num].getWidth(), vett[num].getHeight());
        g.setColor(vett[num].getBorderColor());
        g.drawOval(vett[num].getX(), vett[num].getY(), vett[num].getWidth(), vett[num].getHeight());
        }
    }
}
    
