import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

public class rullo {
    int x,y,w,h;
    public rullo(int x, int y, int w, int h) {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.valore=1;
    }

    int valore;


    public int getValore() {
        return valore;
    }

    synchronized void cambiavalore(){
        valore++;
        if(valore>=7){
            valore=1;
        }
    }

    public void disegnati(Graphics g){
        g.setColor(Color.WHITE);
        g.fillRect(x, y, w, h);
        g.setColor(Color.BLACK);
        g.drawRect(x, y, w, h);

        g.setFont(new Font("arial",0,30));
        g.drawString(valore+"", x, y+h);
    }
}
