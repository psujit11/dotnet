class Array{
    void learn1DArray()
    {
        int[] ages=new int[10];
        double[] agesdouble = new double[10];
        float[] agesfloat = new float[] { 20.2f, 30.3f, 40.23f,}; //more explicit way
        float[] agestry={23.4f, 33.4f, 22.2f,};
        ages[0]=34;
        agesdouble[0]=0;
    }

    void learnMulArray()
    {
        int[,] agesmatrix=new int[10,15];
        agesmatrix[0,0]=4566;
        int[,,] agesmatrix3d =new int [10,15,5];// 10 ota item containing 2d matrix of last ko duita dimension\

        string[,]names=new string[,]{{"Bishnu","Rawwal"},{"ram","basnet"}};
    }

    void learnjaggedarray()
    {
        byte[][] personAges= new byte[2][];
        personAges[0]= new byte[2]{34,35};
        personAges[1] = new byte[]{24,25,26};
         
    }
}