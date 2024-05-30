public class StazioneMeteoroliga {

    //creo un costante | alla fine di questa scrivo f
    final float ZERO_ASSOLUTO= -273.15f;
    //creo il puntatore del vettore a NULL
    private float temp[];

    //costruttore
    public StazioneMeteoroliga(int numEl)
    {
        //inizialli il vettore
        temp = new float[numEl];
    }

    //set e get
    public boolean setTemperatura(float temperatura, int index)
    {
        //index = indice -> da 0 in su
        if(index<0)
            return false;

        if(index>=temp.length)
            return false;

        if(temperatura < ZERO_ASSOLUTO)
            return false;

        temp[index]=temperatura;
        return true;
    }

    public float getMax()
    {
        int indexMax=0;
        for (int i=1;i<temp.length;i++)
        {
            if(temp[i]> temp[indexMax])
            {
                indexMax=i;
            }
        }
        return temp[indexMax];
    }

    public float getMin()
    {
        int indexMin=0;
        for (int i=1;i<temp.length;i++)
        {
            if(temp[i]> temp[indexMin])
            {
                indexMin=i;
            }
        }
        return temp[indexMin];
    }

    public float getMedia()
    {
        float somma=0;
        for (int i=0;i<temp.length;i++)
        {
            somma+=temp[i];
        }
        return somma/temp.length;
    }

    public float[] getValoriSopraMedia()
    {
        float media=getMedia();
        int numEl=GetSopraMedia();
        float ret[] = new float[numEl];
        int j=0;
        for(int i=0;i<temp.length;i++)
        {
            if(temp[i]>media)
            {
                ret[j]=temp[i];
                j++;
            }
        }
        return ret;

    }
    
    public int GetSopraMedia()
    {
        int num=0;
        float media=getMedia();
        for(int i =0;i<temp.length;i++)
        {
            if(temp[i]>media)
            num++;
        }
        return num;
    }


    public float[] ordineCrescente()
    {
     float ret[] = new float[temp.length];
     for(int i=0;i<temp.length;i++)
     {
        for(int j=i+1;j<temp.length;j++)
        {
            if(temp[i]>temp[j])
            {
                float tmp=temp[i];
                temp[i]=temp[j];
                temp[j]=tmp;
            }
        }     
     }
        return ret;
    }
}
