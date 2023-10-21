namespace tipdonusumleri;

class Program
{
    static void Main(string[] args)
    {
        //implicit conversin
        Console.WriteLine("****İmplict Convertion****");

        byte a=5;
        sbyte b=30;
        short c=10;

        int d=a+b+c;
        Console.WriteLine("d:"+d);

        long l=d;
        Console.WriteLine("l:"+l);

        float f=l;
        Console.WriteLine("f:"+f);

        string s="turan";
        Console.WriteLine("s:"+s);

        char c1='T';
        Console.WriteLine("c1:"+c1);

        object o=s+c1+f;

        Console.WriteLine("o:"+o);




        //Exmplicit Conversin
        Console.WriteLine("****Exmplicit Convertion****");

        int i1=5;
        byte b1=(byte)i1;
        Console.WriteLine("b1:"+b1);

        int i2=100;
        byte b2=(byte)i2;
        Console.WriteLine("b2:"+b2);

        float f1=10.5f;
        byte b3=(byte)f1;
        Console.WriteLine("b3:"+b3);

        //ToString 
        Console.WriteLine("****ToString****");

        int i3=15;
        string s2=i3.ToString();
        Console.WriteLine("s2:"+s2);

        string s3=12.5.ToString();
        Console.WriteLine("s3:"+s3);

        //System Convert

        Console.WriteLine("****System Convert***");
        
        string s4="10", s5="21";
        int i4,i5,toplam;

        i4= Convert.ToInt32(s4);

        i5= Convert.ToInt32(s5);
        toplam=i4+i5;

        Console.WriteLine("i4:"+i4);
        Console.WriteLine("i5:"+i5);
        Console.WriteLine("Topla:"+toplam);
        
        //Func. olusturma
        ParseMethod();
    }
    
    public static void ParseMethod(){
        string s1="10",s2="10,24";
        int i1;
        double d1;

        i1=Int32.Parse(s1);
        Console.WriteLine( "i1:"+i1);

        d1=Double.Parse(s2);
        Console.WriteLine("d1:"+d1);


    }
}
