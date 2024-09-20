using System;

public class Hello{
    public static void Main(){
        
        
        //マス数（標準入力）------------------------------------------------------------------------
        int masu = int.Parse(Console.ReadLine());


        //配列（ビンゴカード）------------------------------------------------------------------------
	    string[,] array = new string[masu,masu];//[縦,横]
	
	    for(int j = 0; j < masu; j++)//縦列
        {
	        string line = Console.ReadLine();
	        
	        for(int i = 0; i < masu; i++)//横列
            {
                
                string[] bingo=line.Split(' ');
        
	            array[j,i] = bingo[i];
            }
        }  
   

        //抽選回数（標準入力）------------------------------------------------------------------------
        int not = int.Parse(Console.ReadLine());
        

        //配列（抽選番号）------------------------------------------------------------------------
        string[] atr = new string[not];

        for(int k = 0; k < not; k++)
        {
            atr[k] = Console.ReadLine();
	    }


        //ビンゴになっているか-------------------------------------------
        //横
        //縦
        //斜め1
        //斜め2
        
        
        int atr_line =0;//ライン上　一致数
        int atrmax =0;//ライン上　一致数　最大
        
        //横-------------------------------------------------------------------

        
        for(int i = 0; i < masu; i++)//縦
        {
            
            atr_line =0;
            
            for(int j = 0; j < masu; j++)
            {
                for(int o = 0; o < not; o++)//抽選番号
                {
                    if(array[i,j] ==atr[o])
                    {
                        atr_line+=1;
                    }
                }
            }
            

            if(atr_line >= atrmax)
            {
                atrmax=atr_line;
            }
	    }
        

        //縦-------------------------------------------------------------------


        for(int i = 0; i < masu; i++)//縦
        {
            
            atr_line =0;
            
            for(int j = 0; j < masu; j++)
            {
                for(int o = 0; o < not; o++)//抽選番号
                {
                    if(array[j,i] ==atr[o])
                    {
                        atr_line+=1;
                    }
                }
            }
            
            if(atr_line >= atrmax)
            {
                atrmax=atr_line;
            }
	    }
        

        //斜め1-------------------------------------------------------------------

        
        int tate=0;
        int yoko=0;
        
        atr_line =0;
        
        for(int i = 0; i < masu; i++)//縦
        {
            for(int o = 0; o < not; o++)//抽選番号
            {
                if(array[tate,yoko] ==atr[o])
                {
                    atr_line+=1;
                }
            }
            
            tate+=1;
            yoko+=1;

            if(atr_line >= atrmax)
            {
                atrmax=atr_line;
            }
	    }
	    

        //斜め2-------------------------------------------------------------------


        tate=masu-1;
        yoko=0;
        
        atr_line =0;
        
        for(int i = 0; i < masu; i++)//縦
        {
            for(int o = 0; o < not; o++)//抽選番号
            {
                if(array[tate,yoko] ==atr[o])
                {
                    atr_line+=1;
                }
            }
            
            tate-=1;
            yoko+=1;

            if(atr_line >= atrmax)
            {
                atrmax=atr_line;
            }
	    }
	    
	    
        //結果出力-------------------------------------------------------------------
        
        if(atrmax ==masu)
        {
            Console.Write("yes"); 
        }
        else
        {
            Console.Write("no"); 
        }
    

    }//public static void Main()
}//public class Hello