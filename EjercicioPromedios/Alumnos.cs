using System;


namespace EjercicioPromedios
{
    class Alumnos
    {
         int x;
        string[] Alumnitos;
        float[,] Califas;
        float[] prom;
        float[] promat=new float[5];
        int i;
        public Alumnos()
        {
            Console.WriteLine("ingrese la cantidad de alumnos a capturar: ");
            x = int.Parse(Console.ReadLine());
            Alumnitos = new string[x];
            Califas = new float[x, 4];
            prom = new float[x];
            Capturar();


        }

        private void Capturar()
        {
            for (i = 0; i < Alumnitos.Length; i++)
            {
                Console.WriteLine("Nombre del " + (i + 1) + " Alumno:");
                Alumnitos[i] = Console.ReadLine();
                for (int j = i; j < (i+1); j++)
                {

                    for (int k = 0; k < 4; k++)
                    {
                        if (k == 0)
                        {
                            Console.WriteLine("ingrese la calificación de Español: ");
                            Califas[j, k] = float.Parse(Console.ReadLine());
                        }
                        if (k == 1)
                        {
                            Console.WriteLine("ingrese la calificación de Matematicas: ");
                            Califas[j, k] = float.Parse(Console.ReadLine());
                        }
                        if (k == 2)
                        {
                            Console.WriteLine("ingrese la calificación de Historia: ");
                            Califas[j, k] = float.Parse(Console.ReadLine());
                        }
                        if (k == 3)
                        {
                            Console.WriteLine("ingrese la calificación de Ingles: ");
                            Califas[j, k] = float.Parse(Console.ReadLine());
                        }
                       


                    }


                }
                Console.Clear();
            }
            Promedios();
            
        }


        private void Promedios()
        {
            
            
            for (i = 0; i < x; i++)
            {
                float y=0;
                for (int j = 0; j < 4; j++)
                {
                    y = y + Califas[i, j];

                }
                    prom[i] = (y/4);
                
            }

              
            
                for (int j = 0; j < 4; j++)
                {

                   float y = 0;

                    for (int k = 0; k < x; k++)
                    {

                            y = y + Califas[k, j]; 

                    }

                   promat[j] = (y / x);
                }

            float z = 0;
            for (i = 0; i < prom.Length; i++)
            {

                z = z + prom[i];

            }

            promat[4] = (z / x);






            Imprimir();

        }


        private void Imprimir()
        {

            Console.WriteLine("Alumno                   Español     Matematicas    Historia      Ingles      Promedios Alumnos");
            for (i = 0; i < Alumnitos.Length; i++)
            {
                Console.Write(Alumnitos[i] + "                  ");


                for (int j = 0; j < x; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (j == i)
                        {
                            Console.Write( Califas[j, k] + "             ");
                        }

                    }


                }
                Console.Write(prom[i] + " ");
                Console.WriteLine("  ");
            }


            Console.Write("Promedio materias          ");

            for (i = 0; i < promat.Length; i++)
            {
                Console.Write(promat[i] + "              ");
            }
            Console.WriteLine(" ");

            Buscar();

        }

        private void Buscar()
        {


            float w = 100;
            int t = 0;
            for (int i = 0; i < 4; i++)
            {
                if ( promat[i]<w)
                {
                    w = promat[i];
                    t++;
                }
            }

            if (t == 1)
            {
                Console.WriteLine("Materia con promedio mas bajo: Español");
            }
            if (t == 2)
            {
                Console.WriteLine("Materia con promedio mas bajo: Matematicas");
            }
            if (t == 3)
            {
                Console.WriteLine("Materia con promedio mas bajo: Historia");
            }
            if (t == 4)
            {
                Console.WriteLine("Materia con promedio mas bajo: Ingles");
            }

            float f = 0;
            int p = 0;
            for (int i = 0; i < 4; i++)
            {
                if ( promat[i]>f)
                {
                    f = promat[i];
                    p++;
                }
            }

            if (p == 1)
            {
                Console.WriteLine("Materia con promedio mas alto: Español");
            }
            if (p == 2)
            {
                Console.WriteLine("Materia con promedio mas alto: Matematicas");
            }
            if (p == 3)
            {
                Console.WriteLine("Materia con promedio mas alto: Historia");
            }
            if (p == 4)
            {
                Console.WriteLine("Materia con promedio mas alto: Ingles");
            }

            float s = 100;
            string d="a";
            for (int i = 0; i < prom.Length; i++)
            {
                if (s > prom[i])
                {
                    s = prom[i];
                    d = Alumnitos[i];
                }
            }
            Console.WriteLine("Alumno con promedio mas bajo: " + d + " con " + s);

            float r = 0;
            string g="a" ;
            for (int i = 0; i < prom.Length; i++)
            {
                if (r < prom[i])
                {
                    r = prom[i];
                    g=Alumnitos[i];
                }
            }
            Console.WriteLine("Alumno con promedio mas alto: " + g + " con " + r);
         
        }

        


    }
}
     

    
